using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormAddMedicalHistory : Form
    {
        public FormMedicalHistory.MedicalHistory? NewHistory { get; private set; }

        public FormAddMedicalHistory()
        {
            InitializeComponent();
        }

        public FormAddMedicalHistory(FormMedicalHistory.MedicalHistory existing) : this()
        {
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
            NewHistory = new FormMedicalHistory.MedicalHistory
            {
                PatientName = textBoxPatientName.Text.Trim(),
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
