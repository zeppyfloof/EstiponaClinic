using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormPrescription : Form
    {
        private readonly string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EstiponaClinic");
        private readonly string prescriptionsFile;
        private readonly string patientsFile;
        private readonly string treatmentsFile;

        private List<Prescription> prescriptions = new();
        private List<Patient> patients = new();
        private List<Treatment> treatments = new();

        public FormPrescription()
        {
            InitializeComponent();

            prescriptionsFile = Path.Combine(appDataFolder, "prescriptions.json");
            patientsFile = Path.Combine(appDataFolder, "patients.json");
            treatmentsFile = Path.Combine(appDataFolder, "treatments.json");

            Directory.CreateDirectory(appDataFolder);

            ConfigureDataGridView();
            LoadPatients();
            LoadTreatments();
            LoadPrescriptions();

            buttonPrescriptionSave.Click += buttonPrescriptionSave_Click;
            buttonPrescriptionDelete.Click += buttonPrescriptionDelete_Click;
        }

        private void ConfigureDataGridView()
        {
            dataGridViewPrescription.Columns.Clear();
            dataGridViewPrescription.Columns.Add("TreatmentName", "Treatment");
            dataGridViewPrescription.Columns.Add("PatientName", "Patient");
            dataGridViewPrescription.Columns.Add("Cost", "Cost");
            dataGridViewPrescription.Columns.Add("Medicines", "Medicines");
            dataGridViewPrescription.Columns.Add("Quantity", "Quantity");

            dataGridViewPrescription.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrescription.MultiSelect = false;
        }

        private void LoadPatients()
        {
            if (File.Exists(patientsFile))
                patients = JsonConvert.DeserializeObject<List<Patient>>(File.ReadAllText(patientsFile)) ?? new();

            comboBoxPrescriptionPatient.DataSource = null;
            comboBoxPrescriptionPatient.DataSource = patients;
            comboBoxPrescriptionPatient.DisplayMember = "PatientName";
            comboBoxPrescriptionPatient.ValueMember = "PatientName";
        }

        private void LoadTreatments()
        {
            if (File.Exists(treatmentsFile))
                treatments = JsonConvert.DeserializeObject<List<Treatment>>(File.ReadAllText(treatmentsFile)) ?? new();

            comboBoxPrescriptionTreatment.DataSource = null;
            comboBoxPrescriptionTreatment.DataSource = treatments;
            comboBoxPrescriptionTreatment.DisplayMember = "TreatmentName";
            comboBoxPrescriptionTreatment.ValueMember = "TreatmentName";

            comboBoxPrescriptionTreatment.SelectedIndexChanged += (s, e) =>
            {
                if (comboBoxPrescriptionTreatment.SelectedItem is Treatment t)
                {
                    textBoxPrescriptionCost.Text = t.TreatmentCost;
                }
            };
        }

        private void LoadPrescriptions()
        {
            if (File.Exists(prescriptionsFile))
                prescriptions = JsonConvert.DeserializeObject<List<Prescription>>(File.ReadAllText(prescriptionsFile)) ?? new();

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewPrescription.Rows.Clear();
            foreach (var p in prescriptions)
            {
                dataGridViewPrescription.Rows.Add(p.TreatmentName, p.PatientName, p.Cost, p.Medicines, p.Quantity);
            }
        }

        private void buttonPrescriptionSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPrescriptionTreatment.SelectedIndex < 0 ||
                comboBoxPrescriptionPatient.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(textBoxPrescriptionMedicines.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrescriptionQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTreatment = comboBoxPrescriptionTreatment.SelectedItem as Treatment;
            var selectedPatient = comboBoxPrescriptionPatient.SelectedItem as Patient;

            var newPrescription = new Prescription
            {
                TreatmentName = selectedTreatment!.TreatmentName,
                PatientName = selectedPatient!.PatientName,
                Cost = selectedTreatment.TreatmentCost,
                Medicines = textBoxPrescriptionMedicines.Text,
                Quantity = textBoxPrescriptionQuantity.Text
            };

            prescriptions.Add(newPrescription);
            File.WriteAllText(prescriptionsFile, JsonConvert.SerializeObject(prescriptions, Formatting.Indented));

            LoadPrescriptions();
            ClearInputs();

            MessageBox.Show("Prescription saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPrescriptionDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrescription.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prescription to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewPrescription.SelectedRows[0].Index;
            if (index >= 0 && index < prescriptions.Count)
            {
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this prescription?\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (confirmResult == DialogResult.Yes)
                {
                    prescriptions.RemoveAt(index);
                    File.WriteAllText(prescriptionsFile, JsonConvert.SerializeObject(prescriptions, Formatting.Indented));
                    LoadPrescriptions();

                    MessageBox.Show("Prescription deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void ClearInputs()
        {
            comboBoxPrescriptionTreatment.SelectedIndex = -1;
            comboBoxPrescriptionPatient.SelectedIndex = -1;
            textBoxPrescriptionCost.Clear();
            textBoxPrescriptionMedicines.Clear();
            textBoxPrescriptionQuantity.Clear();
        }
    }

    public class Prescription
    {
        public string TreatmentName { get; set; } = string.Empty;
        public string PatientName { get; set; } = string.Empty;
        public string Cost { get; set; } = string.Empty;
        public string Medicines { get; set; } = string.Empty;
        public string Quantity { get; set; } = string.Empty;
    }

    public class Patient
    {
        public string PatientName { get; set; } = string.Empty;
    }

    public class Treatment
    {
        public string TreatmentName { get; set; } = string.Empty;
        public string TreatmentCost { get; set; } = string.Empty;
    }
}
