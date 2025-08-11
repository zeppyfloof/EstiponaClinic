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

        public FormPatients()
        {
            InitializeComponent();
            comboBoxPatientsGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            InitializeDataGridView();
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

        private void buttonPatientsSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPatientsFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatientsPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatientsAddress.Text) ||
                string.IsNullOrWhiteSpace(comboBoxPatientsGender.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = new Patient
            {
                PatientName = textBoxPatientsFullName.Text.Trim(),
                PatientNumber = textBoxPatientsPhoneNumber.Text.Trim(),
                PatientAddress = textBoxPatientsAddress.Text.Trim(),
                PatientBirthDay = dateTimePickerBirthDate.Value,
                PatientGender = comboBoxPatientsGender.Text,
                PatientAllergies = textBoxPatientsAllergies.Text.Trim()
            };

            patients.Add(patient);
            SavePatients();
            RefreshDataGridView();

            textBoxPatientsFullName.Clear();
            textBoxPatientsPhoneNumber.Clear();
            textBoxPatientsAddress.Clear();
            comboBoxPatientsGender.SelectedIndex = -1;
            dateTimePickerBirthDate.Value = DateTime.Now;
            textBoxPatientsAllergies.Clear();

            MessageBox.Show("Patient saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPatientsDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewPatients.SelectedRows[0];
            int index = selectedRow.Index;

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
