using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormAddPatient : Form
    {
        // Expose input values as properties
        public string PatientName => textBoxPatientsFullName.Text.Trim();
        public string PatientNumber => textBoxPatientsPhoneNumber.Text.Trim();
        public string PatientAddress => textBoxPatientsAddress.Text.Trim();
        public DateTime PatientBirthDay => dateTimePickerBirthDate.Value;
        public string PatientGender => comboBoxPatientsGender.Text;
        public string PatientAllergies => textBoxPatientsAllergies.Text.Trim();

        public FormAddPatient()
        {
            InitializeComponent();
            comboBoxPatientsGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientName) ||
                string.IsNullOrWhiteSpace(PatientNumber) ||
                string.IsNullOrWhiteSpace(PatientAddress) ||
                string.IsNullOrWhiteSpace(PatientGender))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK; // ✅ triggers in FormPatients
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
