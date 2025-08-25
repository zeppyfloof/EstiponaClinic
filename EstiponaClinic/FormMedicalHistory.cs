using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormMedicalHistory : Form
    {
        private List<MedicalHistory> histories = new();
        private readonly string jsonFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "medicalhistory.json"
        );

        public FormMedicalHistory()
        {
            InitializeComponent();

            this.Load += FormMedicalHistory_Load;
            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
        }

        private void FormMedicalHistory_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath)!);
            LoadHistories();
        }

        private void LoadHistories()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    histories = JsonConvert.DeserializeObject<List<MedicalHistory>>(json) ?? new();
                }
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medical histories: {ex.Message}");
            }
        }

        private void SaveHistories()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath)!);
                string json = JsonConvert.SerializeObject(histories, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving medical histories: {ex.Message}");
            }
        }

        private void RefreshDataGridView()
        {
            dataGridViewMedicalHistory.Rows.Clear();
            foreach (var h in histories)
            {
                dataGridViewMedicalHistory.Rows.Add(
                    h.PatientName,
                    h.Condition,
                    h.DateRecorded.ToString("yyyy-MM-dd"),
                    h.Allergies,
                    h.Abnormalities,
                    h.BloodPressure,
                    h.DrugsTaken
                );
            }
        }

        private void textBoxSearch_TextChanged(object? sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim().ToLower();
            var filtered = histories
                .Where(h => h.PatientName.ToLower().Contains(search))
                .ToList();

            dataGridViewMedicalHistory.Rows.Clear();
            foreach (var h in filtered)
            {
                dataGridViewMedicalHistory.Rows.Add(
                    h.PatientName,
                    h.Condition,
                    h.DateRecorded.ToString("yyyy-MM-dd"),
                    h.Allergies,
                    h.Abnormalities,
                    h.BloodPressure,
                    h.DrugsTaken
                );
            }
        }

        // ADD
        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            using var addForm = new FormAddMedicalHistory();
            if (addForm.ShowDialog() == DialogResult.OK && addForm.NewHistory != null)
            {
                histories.Add(addForm.NewHistory);
                SaveHistories();
                RefreshDataGridView();
            }
        }

        // EDIT
        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            if (dataGridViewMedicalHistory.SelectedRows.Count == 0) return;

            int index = dataGridViewMedicalHistory.SelectedRows[0].Index;
            if (index < 0 || index >= histories.Count) return;

            var toEdit = histories[index];
            using var editForm = new FormAddMedicalHistory(toEdit);
            if (editForm.ShowDialog() == DialogResult.OK && editForm.NewHistory != null)
            {
                histories[index] = editForm.NewHistory;
                SaveHistories();
                RefreshDataGridView();
            }
        }

        // DELETE
        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            if (dataGridViewMedicalHistory.SelectedRows.Count == 0) return;

            int index = dataGridViewMedicalHistory.SelectedRows[0].Index;
            if (index >= 0 && index < histories.Count)
            {
                var result = MessageBox.Show("Are you sure you want to delete this record?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    histories.RemoveAt(index);
                    SaveHistories();
                    RefreshDataGridView();
                }
            }
        }

        // Model
        public class MedicalHistory
        {
            public string PatientName { get; set; } = "";
            public string Condition { get; set; } = "";
            public DateTime DateRecorded { get; set; } = DateTime.Now;
            public string Allergies { get; set; } = "";
            public string Abnormalities { get; set; } = "";
            public string BloodPressure { get; set; } = "";
            public string DrugsTaken { get; set; } = "";
        }
    }
}
