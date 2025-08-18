using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormAddTreatment : Form
    {
        public FormTreatment.Treatment? NewTreatment { get; private set; }

        public FormAddTreatment()
        {
            InitializeComponent();
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

            NewTreatment = new FormTreatment.Treatment
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
