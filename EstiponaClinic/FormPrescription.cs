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

            buttonPrescriptionAdd.Click += buttonPrescriptionAdd_Click;
            buttonPrescriptionEdit.Click += buttonPrescriptionEdit_Click;
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
        }

        private void LoadTreatments()
        {
            if (File.Exists(treatmentsFile))
                treatments = JsonConvert.DeserializeObject<List<Treatment>>(File.ReadAllText(treatmentsFile)) ?? new();
        }

        private void LoadPrescriptions()
        {
            if (File.Exists(prescriptionsFile))
                prescriptions = JsonConvert.DeserializeObject<List<Prescription>>(File.ReadAllText(prescriptionsFile)) ?? new();

            RefreshDataGridView();
        }

        private void SavePrescriptions()
        {
            File.WriteAllText(prescriptionsFile, JsonConvert.SerializeObject(prescriptions, Formatting.Indented));
        }

        private void RefreshDataGridView()
        {
            dataGridViewPrescription.Rows.Clear();
            foreach (var p in prescriptions)
            {
                dataGridViewPrescription.Rows.Add(p.TreatmentName, p.PatientName, p.Cost, p.Medicines, p.Quantity);
            }
        }

        // 🔹 ADD
        private void buttonPrescriptionAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new FormAddPrescription(patients, treatments))
            {
                if (addForm.ShowDialog() == DialogResult.OK && addForm.NewPrescription != null)
                {
                    prescriptions.Add(addForm.NewPrescription);
                    SavePrescriptions();
                    RefreshDataGridView();
                    MessageBox.Show("Prescription added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 🔹 EDIT
        private void buttonPrescriptionEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrescription.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prescription to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewPrescription.SelectedRows[0].Index;
            if (index < 0 || index >= prescriptions.Count) return;

            var prescriptionToEdit = prescriptions[index];

            using (var editForm = new FormEditPrescription(patients, treatments, prescriptionToEdit))
            {
                if (editForm.ShowDialog() == DialogResult.OK && editForm.EditedPrescription != null)
                {
                    prescriptions[index] = editForm.EditedPrescription;
                    SavePrescriptions();
                    RefreshDataGridView();
                    MessageBox.Show("Prescription updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 🔹 DELETE
        private void buttonPrescriptionDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrescription.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a prescription to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewPrescription.SelectedRows[0].Index;

            if (index >= 0 && index < prescriptions.Count)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete this prescription?\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.Yes)
                {
                    prescriptions.RemoveAt(index);
                    SavePrescriptions();
                    RefreshDataGridView();
                    MessageBox.Show("Prescription deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    // 🔹 Classes remain same
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
