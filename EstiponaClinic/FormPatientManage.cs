using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormPatientManage : Form
    {
        public FormPatients.Patient PatientData { get; private set; }
        private bool isEditMode;

        public FormPatientManage(FormPatients.Patient patient = null)
        {
            InitializeComponent();

            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            if (patient != null)
            {
                // Populate fields for editing
                textBoxName.Text = patient.PatientName;
                textBoxNumber.Text = patient.PatientNumber;
                textBoxAddress.Text = patient.PatientAddress;
                dateTimePickerDOB.Value = patient.PatientBirthDay;
                comboBoxGender.Text = patient.PatientGender;
                textBoxAllergies.Text = patient.PatientAllergies;

                isEditMode = true;
                btnSave.Text = "Update";
            }
            else
            {
                isEditMode = false;
                btnSave.Text = "Save";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGender.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            PatientData = new FormPatients.Patient
            {
                PatientName = textBoxName.Text.Trim(),
                PatientNumber = textBoxNumber.Text.Trim(),
                PatientAddress = textBoxAddress.Text.Trim(),
                PatientBirthDay = dateTimePickerDOB.Value,
                PatientGender = comboBoxGender.Text,
                PatientAllergies = textBoxAllergies.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
