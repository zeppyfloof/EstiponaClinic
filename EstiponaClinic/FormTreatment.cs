using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormTreatment : Form
    {
        private List<Treatment> treatments = new List<Treatment>();
        private readonly string jsonFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "treatments.json"
        );

        public FormTreatment()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadTreatments();
        }

        private void ConfigureDataGridView()
        {
            dataGridViewTreatment.Columns.Clear();
            dataGridViewTreatment.Columns.Add("TreatmentName", "Treatment Name");
            dataGridViewTreatment.Columns.Add("TreatmentDescription", "Description");
            dataGridViewTreatment.Columns.Add("TreatmentCost", "Cost");
            dataGridViewTreatment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTreatment.MultiSelect = false;
        }

        private void LoadTreatments()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    treatments = JsonConvert.DeserializeObject<List<Treatment>>(json) ?? new List<Treatment>();
                }
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading treatments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveTreatments()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath) ?? "");
                string json = JsonConvert.SerializeObject(treatments, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving treatments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            dataGridViewTreatment.Rows.Clear();
            foreach (var treatment in treatments)
            {
                dataGridViewTreatment.Rows.Add(
                    treatment.TreatmentName,
                    treatment.TreatmentDescription,
                    treatment.TreatmentCost
                );
            }
        }

        private void buttonTreatmentSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTreatmentName.Text) ||
                string.IsNullOrWhiteSpace(textBoxTreatmentDescription.Text) ||
                string.IsNullOrWhiteSpace(textBoxTreatmentCost.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxTreatmentCost.Text, out decimal cost))
            {
                MessageBox.Show("Cost must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var treatment = new Treatment
            {
                TreatmentName = textBoxTreatmentName.Text.Trim(),
                TreatmentDescription = textBoxTreatmentDescription.Text.Trim(),
                TreatmentCost = cost
            };

            treatments.Add(treatment);
            SaveTreatments();
            RefreshDataGridView();

            textBoxTreatmentName.Clear();
            textBoxTreatmentDescription.Clear();
            textBoxTreatmentCost.Clear();

            MessageBox.Show("Treatment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonTreatmentDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a treatment to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewTreatment.SelectedRows[0];
            int index = selectedRow.Index;

            if (index >= 0 && index < treatments.Count)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete treatment \"{treatments[index].TreatmentName}\"?\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.Yes)
                {
                    treatments.RemoveAt(index);
                    SaveTreatments();
                    RefreshDataGridView();
                    MessageBox.Show("Treatment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public class Treatment
        {
            public string TreatmentName { get; set; } = string.Empty;
            public string TreatmentDescription { get; set; } = string.Empty;
            public decimal TreatmentCost { get; set; }
        }
    }
}
