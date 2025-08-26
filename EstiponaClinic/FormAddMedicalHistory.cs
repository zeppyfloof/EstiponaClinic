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
        private List<string> availablePatients = new();

        public FormAddMedicalHistory(List<string> existingPatients)
        {
            InitializeComponent();
            LoadPatients(existingPatients);
        }

        private void LoadPatients(List<string> existingPatients)
        {
            string patientFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "patients.json"
            );

            if (File.Exists(patientFile))
            {
                var patients = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText(patientFile));
                if (patients != null)
                {
                    availablePatients = patients
                        .Select(p => (string)p.name)
                        .Where(name => !existingPatients.Contains(name))
                        .ToList();

                    comboBoxPatientName.Items.Clear();
                    comboBoxPatientName.Items.AddRange(availablePatients.ToArray());
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPatientName.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            NewHistory = new FormMedicalHistory.MedicalHistory
            {
                PatientName = comboBoxPatientName.SelectedItem.ToString()!,
                Condition = textBoxCondition.Text.Trim(),
                DateRecorded = dateTimePickerDate.Value,
                Allergies = textBoxAllergies.Text.Trim(),
                Abnormalities = textBoxAbnormalities.Text.Trim(),
                BloodPressure = textBoxBloodPressure.Text.Trim(),
                DrugsTaken = textBoxDrugsTaken.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
