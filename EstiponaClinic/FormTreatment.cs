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

            this.Load += FormTreatment_Load;
            buttonTreatmentAdd.Click += buttonTreatmentAdd_Click;
            buttonTreatmentEdit.Click += buttonTreatmentEdit_Click;
            buttonTreatmentDelete.Click += buttonTreatmentDelete_Click;
            textBoxTreatmentSearch.TextChanged += textBoxTreatmentSearch_TextChanged; // ✅ Hook up search

            ConfigureDataGridView();
        }

        private void FormTreatment_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath) ?? "");
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
                    treatments = JsonConvert.DeserializeObject<List<Treatment>>(json) ?? new();
                }
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading treatments: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Error saving treatments: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    treatment.TreatmentCost.ToString("F2")
                );
            }
        }

        // 🔎 Search filter (only TreatmentName)
        private void textBoxTreatmentSearch_TextChanged(object sender, EventArgs e)
        {
            string query = textBoxTreatmentSearch.Text.Trim().ToLower();

            dataGridViewTreatment.Rows.Clear();

            var filteredTreatments = string.IsNullOrEmpty(query)
                ? treatments
                : treatments.FindAll(t => t.TreatmentName.ToLower().Contains(query));

            foreach (var treatment in filteredTreatments)
            {
                dataGridViewTreatment.Rows.Add(
                    treatment.TreatmentName,
                    treatment.TreatmentDescription,
                    treatment.TreatmentCost.ToString("F2")
                );
            }
        }

        // ADD
        private void buttonTreatmentAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new FormAddTreatment())
            {
                if (addForm.ShowDialog() == DialogResult.OK && addForm.NewTreatment != null)
                {
                    treatments.Add(addForm.NewTreatment);
                    SaveTreatments();
                    RefreshDataGridView();
                    MessageBox.Show("Treatment added successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // EDIT
        private void buttonTreatmentEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a treatment to edit.", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewTreatment.SelectedRows[0].Index;
            if (index < 0 || index >= treatments.Count) return;

            var treatmentToEdit = treatments[index];

            using (var editForm = new FormEditTreatment(treatmentToEdit))
            {
                if (editForm.ShowDialog() == DialogResult.OK && editForm.EditedTreatment != null)
                {
                    treatments[index] = editForm.EditedTreatment;
                    SaveTreatments();
                    RefreshDataGridView();
                    MessageBox.Show("Treatment updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // DELETE
        private void buttonTreatmentDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a treatment to delete.", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridViewTreatment.SelectedRows[0].Index;

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
                    MessageBox.Show("Treatment deleted successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
