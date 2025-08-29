using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormEditPatient : Form
    {
        // Edits the passed-in instance directly
        private readonly FormPatients.Patient patient;

        public FormEditPatient(FormPatients.Patient patientToEdit)
        {
            InitializeComponent();
            comboBoxPatientsGender.Items.Clear();
            comboBoxPatientsGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            patient = patientToEdit;

            // Pre-fill fields with current values
            textBoxPatientsFullName.Text = patient.Name;
            textBoxPatientsPhoneNumber.Text = patient.Phone;
            textBoxPatientsAddress.Text = patient.Address;
            dateTimePickerBirthDate.Value = patient.BirthDate == default ? DateTime.Now : patient.BirthDate;
            comboBoxPatientsGender.Text = patient.Gender;
            textBoxPatientsNotes.Text = patient.Notes;  // ✅ changed
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPatientsFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatientsPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatientsAddress.Text) ||
                string.IsNullOrWhiteSpace(comboBoxPatientsGender.Text))
            {
                MessageBox.Show("Please fill in all required fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Apply edits back to the original object
            patient.Name = textBoxPatientsFullName.Text.Trim();
            patient.Phone = textBoxPatientsPhoneNumber.Text.Trim();
            patient.Address = textBoxPatientsAddress.Text.Trim();
            patient.BirthDate = dateTimePickerBirthDate.Value;
            patient.Gender = comboBoxPatientsGender.Text;
            patient.Notes = textBoxPatientsNotes.Text.Trim();  // ✅ changed

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
