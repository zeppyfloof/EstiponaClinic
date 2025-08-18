using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormAppointment : Form
    {
        private List<Appointment> appointments = new();
        private readonly string jsonFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "appointments.json"
        );

        public FormAppointment()
        {
            InitializeComponent();

            this.Load += FormAppointment_Load;
            buttonAppointmentsAdd.Click += buttonAppointmentsAdd_Click;
            buttonAppointmentsEdit.Click += buttonAppointmentsEdit_Click;
            buttonAppointmentsDelete.Click += buttonAppointmentsDelete_Click;

            InitializeDataGridView();
        }

        private void FormAppointment_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath)!);
            LoadAppointments();
        }

        private void InitializeDataGridView()
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
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json) ?? new();
                }
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAppointments()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath)!);
                string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving appointments: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    appt.TreatmentCost,
                    appt.AppointmentDate.ToShortDateString(),
                    appt.AppointmentTime.ToShortTimeString()
                );
            }
        }

        // ADD
        private void buttonAppointmentsAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new FormAddAppointment())
            {
                if (addForm.ShowDialog() == DialogResult.OK && addForm.NewAppointment != null)
                {
                    appointments.Add(addForm.NewAppointment);
                    SaveAppointments();
                    RefreshDataGridView();
                    MessageBox.Show("Appointment added successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // EDIT
        private void buttonAppointmentsEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to edit.", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewAppointments.SelectedRows[0].Index;
            if (index < 0 || index >= appointments.Count) return;

            var apptToEdit = appointments[index];

            using (var editForm = new FormEditAppointment(apptToEdit))
            {
                if (editForm.ShowDialog() == DialogResult.OK && editForm.EditedAppointment != null)
                {
                    appointments[index] = editForm.EditedAppointment;
                    SaveAppointments();
                    RefreshDataGridView();
                    MessageBox.Show("Appointment updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // DELETE
        private void buttonAppointmentsDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewAppointments.SelectedRows[0].Index;

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
                    MessageBox.Show("Appointment deleted successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Appointment model
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
