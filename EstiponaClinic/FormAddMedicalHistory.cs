using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormAddMedicalHistory : Form
    {
        public MedicalHistory NewHistory { get; private set; }

        public FormAddMedicalHistory()
        {
            InitializeComponent();
        }

        public FormAddMedicalHistory(MedicalHistory history) : this()
        {
            textBoxPatientName.Text = history.PatientName;
            textBoxCondition.Text = history.Condition;
            dateTimePickerDate.Value = history.DateRecorded;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewHistory = new MedicalHistory
            {
                PatientName = textBoxPatientName.Text.Trim(),
                Condition = textBoxCondition.Text.Trim(),
                DateRecorded = dateTimePickerDate.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
