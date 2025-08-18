using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormEditTreatment : Form
    {
        public FormTreatment.Treatment? EditedTreatment { get; private set; }

        public FormEditTreatment(FormTreatment.Treatment treatmentToEdit)
        {
            InitializeComponent();

            textBoxName.Text = treatmentToEdit.TreatmentName;
            textBoxDescription.Text = treatmentToEdit.TreatmentDescription;
            textBoxCost.Text = treatmentToEdit.TreatmentCost.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
                !decimal.TryParse(textBoxCost.Text, out decimal cost))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditedTreatment = new FormTreatment.Treatment
            {
                TreatmentName = textBoxName.Text.Trim(),
                TreatmentDescription = textBoxDescription.Text.Trim(),
                TreatmentCost = cost
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
