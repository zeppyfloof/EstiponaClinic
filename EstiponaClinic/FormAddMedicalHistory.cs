using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormAddMedicalHistory : Form
    {
        public FormMedicalHistory.MedicalHistory? NewHistory { get; private set; }
        private readonly List<ComboItem> availablePatients = new();

        public FormAddMedicalHistory(List<int> existingPatients)
        {
            InitializeComponent();
            LoadPatients(existingPatients);
        }

        private void LoadPatients(List<int> existingPatients)
        {
            string patientFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "patients.json"
            );

            if (!File.Exists(patientFile)) return;

            var json = File.ReadAllText(patientFile);
            var patients = JsonConvert.DeserializeObject<List<FormPatients.Patient>>(json) ?? new();

            comboBoxPatientName.Items.Clear();
            availablePatients.Clear();

            foreach (var p in patients)
            {
                // skip if already linked to a history (by PatientID)
                if (existingPatients.Contains(p.PatientID)) continue;

                var item = new ComboItem { PatientID = p.PatientID, DisplayName = p.Name };
                availablePatients.Add(item);
                comboBoxPatientName.Items.Add(item);
            }

            comboBoxPatientName.DisplayMember = nameof(ComboItem.DisplayName);
            comboBoxPatientName.ValueMember = nameof(ComboItem.PatientID);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPatientName.SelectedItem is not ComboItem selected)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            NewHistory = new FormMedicalHistory.MedicalHistory
            {
                // MedicalHistoryID is assigned by the parent form after dialog OK
                PatientID = selected.PatientID,
                PatientName = selected.DisplayName,
                Condition = textBoxCondition.Text.Trim(),
                DateRecorded = dateTimePickerDate.Value,
                Allergies = textBoxAllergies.Text.Trim(),
                Abnormalities = textBoxAbnormalities.Text.Trim(),
                BloodPressure = textBoxBloodPressure.Text.Trim(),
                DrugsTaken = textBoxDrugsTaken.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private class ComboItem
        {
            public int PatientID { get; set; }
            public string DisplayName { get; set; } = string.Empty;
            public override string ToString() => DisplayName;
        }
    }
}
