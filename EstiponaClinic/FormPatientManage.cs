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
                btnCancel.Text = "Delete";   // 👈 change Cancel into Delete
            }
            else
            {
                isEditMode = false;
                btnSave.Text = "Save";
                btnCancel.Text = "Cancel";   // 👈 stays Cancel for new patients
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumber.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string action = this.PatientData == null ? "create" : "update";
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to {action} this patient?\n\n" +
                $"Name: {textBoxName.Text}\n" +
                $"Number: {textBoxNumber.Text}",
                "Confirm " + char.ToUpper(action[0]) + action.Substring(1),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
            {
                // ❌ Do NOT close, let user keep editing
                return;
            }

            // ✅ Save data
            PatientData = new FormPatients.Patient
            {
                PatientName = textBoxName.Text.Trim(),
                PatientNumber = textBoxNumber.Text.Trim(),
                PatientAddress = textBoxAddress.Text.Trim(),
                PatientBirthDay = dateTimePickerBirthDate.Value,
                PatientGender = comboBoxGender.Text,
                PatientAllergies = textBoxAllergies.Text.Trim()
            };

            this.DialogResult = DialogResult.OK; // closes only if confirmed
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this patient?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Abort; // 👈 special case for delete
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

    }
}
