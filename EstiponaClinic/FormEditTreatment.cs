using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormEditTreatment : Form
    {
        public FormTreatment.Treatment? EditedTreatment { get; private set; }

        private readonly FormTreatment.Treatment _treatmentToEdit;

        public FormEditTreatment(FormTreatment.Treatment treatmentToEdit)
        {
            InitializeComponent();

            _treatmentToEdit = treatmentToEdit;

            // ✅ Populate categories same as in FormAddTreatment
            comboBoxCategory.Items.AddRange(new string[]
            {
                "General Dentistry",
                "Oral Surgery",
                "Restorative Dentistry",
                "Endodontics",
                "Prosthodontics",
                "Implant Dentistry",
                "Cosmetic Dentistry",
                "Orthodontics",
                "Periodontics",
                "Pediatric Dentistry",
                "Emergency"
            });

            // ✅ Pre-fill fields
            textBoxName.Text = _treatmentToEdit.TreatmentName;
            textBoxDescription.Text = _treatmentToEdit.TreatmentDescription;
            textBoxCost.Text = _treatmentToEdit.TreatmentCost.ToString();

            // ✅ Set the category if it exists, otherwise default to first
            if (!string.IsNullOrWhiteSpace(_treatmentToEdit.Category) &&
                comboBoxCategory.Items.Contains(_treatmentToEdit.Category))
            {
                comboBoxCategory.SelectedItem = _treatmentToEdit.Category;
            }
            else
            {
                comboBoxCategory.SelectedIndex = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
                !decimal.TryParse(textBoxCost.Text, out decimal cost) ||
                comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditedTreatment = new FormTreatment.Treatment
            {
                TreatmentName = textBoxName.Text.Trim(),
                TreatmentDescription = textBoxDescription.Text.Trim(),
                TreatmentCost = cost,
                Category = comboBoxCategory.SelectedItem.ToString() ?? ""
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
