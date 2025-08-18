using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormEditPatient : Form
    {
        // Return the edited patient
        public FormPatients.Patient EditedPatient { get; private set; }

        private readonly FormPatients.Patient originalPatient;

        public FormEditPatient(FormPatients.Patient patientToEdit)
        {
            InitializeComponent();
            comboBoxPatientsGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            originalPatient = patientToEdit;

            // Pre-fill fields
            textBoxPatientsFullName.Text = patientToEdit.PatientName;
            textBoxPatientsPhoneNumber.Text = patientToEdit.PatientNumber;
            textBoxPatientsAddress.Text = patientToEdit.PatientAddress;
            dateTimePickerBirthDate.Value = patientToEdit.PatientBirthDay;
            comboBoxPatientsGender.Text = patientToEdit.PatientGender;
            textBoxPatientsAllergies.Text = patientToEdit.PatientAllergies;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPatientsFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatientsPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatientsAddress.Text) ||
                string.IsNullOrWhiteSpace(comboBoxPatientsGender.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditedPatient = new FormPatients.Patient
            {
                PatientName = textBoxPatientsFullName.Text.Trim(),
                PatientNumber = textBoxPatientsPhoneNumber.Text.Trim(),
                PatientAddress = textBoxPatientsAddress.Text.Trim(),
                PatientBirthDay = dateTimePickerBirthDate.Value,
                PatientGender = comboBoxPatientsGender.Text,
                PatientAllergies = textBoxPatientsAllergies.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
