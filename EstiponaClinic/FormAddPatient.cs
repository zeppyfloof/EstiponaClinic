using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormAddPatient : Form
    {
        // Expose input values as properties (used by FormPatients)
        public string PatientName => textBoxPatientsFullName.Text.Trim();
        public string PatientNumber => textBoxPatientsPhoneNumber.Text.Trim();
        public string PatientAddress => textBoxPatientsAddress.Text.Trim();
        public string PatientEmail => textBoxPatientsEmail.Text.Trim();  // ✅ added
        public DateTime PatientBirthDay => dateTimePickerBirthDate.Value;
        public string PatientGender => comboBoxPatientsGender.Text;
        public string PatientNotes => textBoxPatientsNotes.Text.Trim();
        public string PatientBloodPressure => textBoxBloodPressure.Text.Trim();
        public string PatientHeartRate => textBoxHeartRate.Text.Trim();
        public string PatientTemperature => textBoxTemperature.Text.Trim();
        public string PatientRespiratoryRate => textBoxRespiratoryRate.Text.Trim();
        public string PatientWeight => textBoxWeight.Text.Trim();
        public string PatientHeight => textBoxHeight.Text.Trim();


        public FormAddPatient()
        {
            InitializeComponent();
            comboBoxPatientsGender.Items.Clear();
            comboBoxPatientsGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientName) ||
                string.IsNullOrWhiteSpace(PatientNumber) ||
                string.IsNullOrWhiteSpace(PatientAddress) ||
                string.IsNullOrWhiteSpace(PatientEmail) ||   // ✅ validation
                string.IsNullOrWhiteSpace(PatientGender))
            {
                MessageBox.Show("Please fill in all required fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
