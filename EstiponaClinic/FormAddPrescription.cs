using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormAddPrescription : Form
    {
        private readonly List<Patient> patients;
        private readonly List<Treatment> treatments;

        public Prescription? NewPrescription { get; private set; }

        public FormAddPrescription(List<Patient> patients, List<Treatment> treatments)
        {
            InitializeComponent();
            this.patients = patients;
            this.treatments = treatments;

            comboBoxPatient.DataSource = patients;
            comboBoxPatient.DisplayMember = "PatientName";
            comboBoxPatient.ValueMember = "PatientName";

            comboBoxTreatment.DataSource = treatments;
            comboBoxTreatment.DisplayMember = "TreatmentName";
            comboBoxTreatment.ValueMember = "TreatmentName";

            comboBoxTreatment.SelectedIndexChanged += (s, e) =>
            {
                if (comboBoxTreatment.SelectedItem is Treatment t)
                {
                    textBoxCost.Text = t.TreatmentCost;
                }
            };
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedIndex < 0 || comboBoxTreatment.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(textBoxMedicines.Text) || string.IsNullOrWhiteSpace(textBoxQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPatient = (Patient)comboBoxPatient.SelectedItem;
            var selectedTreatment = (Treatment)comboBoxTreatment.SelectedItem;

            NewPrescription = new Prescription
            {
                PatientName = selectedPatient.PatientName,
                TreatmentName = selectedTreatment.TreatmentName,
                Cost = selectedTreatment.TreatmentCost,
                Medicines = textBoxMedicines.Text.Trim(),
                Quantity = textBoxQuantity.Text.Trim()
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
