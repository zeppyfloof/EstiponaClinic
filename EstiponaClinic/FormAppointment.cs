using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormAppointment : Form
    {
        private readonly string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EstiponaClinic");
        private readonly string appointmentsFile;
        private readonly string patientsFile;
        private readonly string treatmentsFile;

        private List<Appointment> appointments = new();
        private List<FormPatients.Patient> patients = new();
        private List<FormTreatment.Treatment> treatments = new();

        public FormAppointment()
        {
            InitializeComponent();

            appointmentsFile = Path.Combine(appDataFolder, "appointments.json");
            patientsFile = Path.Combine(appDataFolder, "patients.json");
            treatmentsFile = Path.Combine(appDataFolder, "treatments.json");

            Directory.CreateDirectory(appDataFolder);

            ConfigureDataGridView();
            LoadPatients();
            LoadTreatments();
            LoadAppointments();

            buttonAppointmentSave.Click += buttonAppointmentSave_Click;
            buttonAppointmentDelete.Click += buttonAppointmentDelete_Click;
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

        private void LoadPatients()
        {
            if (File.Exists(patientsFile))
                patients = JsonConvert.DeserializeObject<List<FormPatients.Patient>>(File.ReadAllText(patientsFile)) ?? new();

            comboBox1.Items.Clear();
            foreach (var p in patients)
                comboBox1.Items.Add(p.PatientName);
        }

        private void LoadTreatments()
        {
            if (File.Exists(treatmentsFile))
                treatments = JsonConvert.DeserializeObject<List<FormTreatment.Treatment>>(File.ReadAllText(treatmentsFile)) ?? new();

            comboBox2.Items.Clear();
            foreach (var t in treatments)
                comboBox2.Items.Add(t.TreatmentName);
        }

        private void LoadAppointments()
        {
            if (File.Exists(appointmentsFile))
                appointments = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(appointmentsFile)) ?? new();

            RefreshDataGridView();
        }

        private void SaveAppointments()
        {
            File.WriteAllText(appointmentsFile, JsonConvert.SerializeObject(appointments, Formatting.Indented));
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

            decimal cost = treatments.Find(t => t.TreatmentName == comboBox2.SelectedItem!.ToString())?.TreatmentCost ?? 0;

            var appointment = new Appointment
            {
                PatientName = comboBox1.SelectedItem!.ToString()!,
                TreatmentName = comboBox2.SelectedItem!.ToString()!,
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

            int index = dataGridViewAppointments.SelectedRows[0].Index;
            if (index >= 0 && index < appointments.Count)
            {
                if (MessageBox.Show("Delete this appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    appointments.RemoveAt(index);
                    SaveAppointments();
                    RefreshDataGridView();
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
