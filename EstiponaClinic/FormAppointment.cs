using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormAppointment : Form
    {
        private List<Appointment> appointments = new List<Appointment>();
        private readonly string jsonFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "appointments.json"
        );

        private readonly string patientsFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "patients.json"
        );

        private readonly string treatmentsFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "treatments.json"
        );

        private List<FormTreatment.Treatment> treatments = new List<FormTreatment.Treatment>();

        public FormAppointment()
        {
            InitializeComponent();

            this.buttonAppointmentSave.Click += new System.EventHandler(this.buttonAppointmentSave_Click);
            this.buttonAppointmentDelete.Click += new System.EventHandler(this.buttonAppointmentDelete_Click);

            LoadPatientsAndTreatments();
            ConfigureDataGridView();
            LoadAppointments();
        }

        private void LoadPatientsAndTreatments()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            // Load patients
            if (File.Exists(patientsFilePath))
            {
                var patients = JsonConvert.DeserializeObject<List<FormPatients.Patient>>(File.ReadAllText(patientsFilePath));
                if (patients != null)
                {
                    foreach (var p in patients)
                        comboBox1.Items.Add(p.PatientName);
                }
            }

            // Load treatments and store for cost lookup
            if (File.Exists(treatmentsFilePath))
            {
                treatments = JsonConvert.DeserializeObject<List<FormTreatment.Treatment>>(File.ReadAllText(treatmentsFilePath)) ?? new List<FormTreatment.Treatment>();
                foreach (var t in treatments)
                    comboBox2.Items.Add(t.TreatmentName);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridViewAppointments.Columns.Clear();
            dataGridViewAppointments.Columns.Add("PatientName", "Patient");
            dataGridViewAppointments.Columns.Add("TreatmentName", "Treatment");
            dataGridViewAppointments.Columns.Add("TreatmentCost", "Cost");
            dataGridViewAppointments.Columns.Add("AppointmentDate", "Date");
            dataGridViewAppointments.Columns.Add("AppointmentTime", "Time");
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.MultiSelect = false;
        }

        private void LoadAppointments()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json) ?? new List<Appointment>();
                }
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAppointments()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath) ?? "");
                string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            dataGridViewAppointments.Rows.Clear();
            foreach (var appt in appointments)
            {
                dataGridViewAppointments.Rows.Add(
                    appt.PatientName,
                    appt.TreatmentName,
                    appt.TreatmentCost.ToString("F2"),
                    appt.AppointmentDate.ToString("yyyy-MM-dd"),
                    appt.AppointmentTime.ToString("hh:mm tt")
                );
            }
        }

        private void buttonAppointmentSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a patient and a treatment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = dateTimePickerAppointmentDate.Value.Date;
            DateTime selectedTime = dateTimePickerAppointmentTime.Value;
            DateTime combinedDateTime = selectedDate.Add(selectedTime.TimeOfDay);

            if (combinedDateTime < DateTime.Now)
            {
                MessageBox.Show("Appointment date and time cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lookup treatment cost
            string selectedTreatmentName = comboBox2.SelectedItem!.ToString()!;
            decimal cost = 0;
            var treatment = treatments.Find(t => t.TreatmentName == selectedTreatmentName);
            if (treatment != null)
            {
                cost = treatment.TreatmentCost;
            }

            var appointment = new Appointment
            {
                PatientName = comboBox1.SelectedItem!.ToString()!,
                TreatmentName = selectedTreatmentName,
                TreatmentCost = cost,
                AppointmentDate = selectedDate,
                AppointmentTime = selectedTime
            };

            appointments.Add(appointment);
            SaveAppointments();
            RefreshDataGridView();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePickerAppointmentDate.Value = DateTime.Now;
            dateTimePickerAppointmentTime.Value = DateTime.Now;

            MessageBox.Show("Appointment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAppointmentDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewAppointments.SelectedRows[0];
            int index = selectedRow.Index;

            if (index >= 0 && index < appointments.Count)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete this appointment?\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.Yes)
                {
                    appointments.RemoveAt(index);
                    SaveAppointments();
                    RefreshDataGridView();
                    MessageBox.Show("Appointment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public class Appointment
        {
            public string PatientName { get; set; } = string.Empty;
            public string TreatmentName { get; set; } = string.Empty;
            public decimal TreatmentCost { get; set; }
            public DateTime AppointmentDate { get; set; }
            public DateTime AppointmentTime { get; set; }
        }
    }
}
