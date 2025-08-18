using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormPatients : Form
    {
        private List<Patient> patients = new List<Patient>();
        private readonly string jsonFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "patients.json"

        );
        private void textBoxPatientsSearch_TextChanged(object sender, EventArgs e)
        {
            string query = textBoxPatientsSearch.Text.Trim().ToLower();

            dataGridViewPatients.Rows.Clear();

            var filteredPatients = string.IsNullOrEmpty(query)
                ? patients
                : patients.FindAll(p => p.PatientName.ToLower().Contains(query));

            foreach (var patient in filteredPatients)
            {
                dataGridViewPatients.Rows.Add(
                    patient.PatientName,
                    patient.PatientNumber,
                    patient.PatientAddress,
                    patient.PatientBirthDay.ToShortDateString(),
                    patient.PatientGender,
                    patient.PatientAllergies
                );
            }
        }

        public FormPatients()
        {
            InitializeComponent();

            // Event hookups
            this.Load += FormPatients_Load;
            buttonPatientsSave.Click += buttonPatientsSave_Click;
            buttonPatientsDelete.Click += buttonPatientsDelete_Click;
            buttonPatientsEdit.Click += buttonPatientsEdit_Click;

            InitializeDataGridView();
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath) ?? "");
            LoadPatients();
        }

        private void InitializeDataGridView()
        {
            dataGridViewPatients.Columns.Clear();
            dataGridViewPatients.Columns.Add("PatientName", "Patient");
            dataGridViewPatients.Columns.Add("PatientNumber", "Contact No.");
            dataGridViewPatients.Columns.Add("PatientAddress", "Address");
            dataGridViewPatients.Columns.Add("PatientBirthDay", "Date of Birth");
            dataGridViewPatients.Columns.Add("PatientGender", "Gender");
            dataGridViewPatients.Columns.Add("PatientAllergies", "Allergies");
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.MultiSelect = false;
        }

        private void LoadPatients()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    patients = JsonConvert.DeserializeObject<List<Patient>>(json) ?? new List<Patient>();
                }
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePatients()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath) ?? "");
                string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            dataGridViewPatients.Rows.Clear();
            foreach (var patient in patients)
            {
                dataGridViewPatients.Rows.Add(
                    patient.PatientName,
                    patient.PatientNumber,
                    patient.PatientAddress,
                    patient.PatientBirthDay.ToShortDateString(),
                    patient.PatientGender,
                    patient.PatientAllergies
                );
            }
        }

        // 🔹 Save button opens FormAddPatient
        private void buttonPatientsSave_Click(object sender, EventArgs e)
        {
            using (var addForm = new FormAddPatient())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    var newPatient = new Patient
                    {
                        PatientName = addForm.PatientName,
                        PatientNumber = addForm.PatientNumber,
                        PatientAddress = addForm.PatientAddress,
                        PatientBirthDay = addForm.PatientBirthDay,
                        PatientGender = addForm.PatientGender,
                        PatientAllergies = addForm.PatientAllergies
                    };

                    patients.Add(newPatient);
                    SavePatients();
                    RefreshDataGridView();
                    MessageBox.Show("Patient saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 🔹 Edit button opens FormEditPatient
        private void buttonPatientsEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewPatients.SelectedRows[0].Index;
            if (index < 0 || index >= patients.Count) return;

            var patientToEdit = patients[index];

            using (var editForm = new FormEditPatient(patientToEdit))
            {
                if (editForm.ShowDialog() == DialogResult.OK && editForm.EditedPatient != null)
                {
                    patients[index] = editForm.EditedPatient; // Replace old with updated
                    SavePatients();
                    RefreshDataGridView();
                    MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonPatientsDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewPatients.SelectedRows[0].Index;

            if (index >= 0 && index < patients.Count)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete patient \"{patients[index].PatientName}\"?\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.Yes)
                {
                    patients.RemoveAt(index);
                    SavePatients();
                    RefreshDataGridView();
                    MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 🔹 Patient model
        public class Patient
        {
            public string PatientName { get; set; } = string.Empty;
            public string PatientNumber { get; set; } = string.Empty;
            public string PatientAddress { get; set; } = string.Empty;
            public DateTime PatientBirthDay { get; set; }
            public string PatientGender { get; set; } = string.Empty;
            public string? PatientAllergies { get; set; }
        }
    }
}
