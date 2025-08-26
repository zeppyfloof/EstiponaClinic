using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormEditMedicalHistory : Form
    {
        public FormMedicalHistory.MedicalHistory? UpdatedHistory { get; private set; }

        public FormEditMedicalHistory(FormMedicalHistory.MedicalHistory existing)
        {
            InitializeComponent();

            textBoxPatientName.Text = existing.PatientName;
            textBoxCondition.Text = existing.Condition;
            dateTimePickerDate.Value = existing.DateRecorded;
            textBoxAllergies.Text = existing.Allergies;
            textBoxAbnormalities.Text = existing.Abnormalities;
            textBoxBloodPressure.Text = existing.BloodPressure;
            textBoxDrugsTaken.Text = existing.DrugsTaken;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdatedHistory = new FormMedicalHistory.MedicalHistory
            {
                PatientName = textBoxPatientName.Text, // locked, not editable
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
