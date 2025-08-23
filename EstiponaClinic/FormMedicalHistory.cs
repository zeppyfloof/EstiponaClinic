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
        private List<MedicalHistory> histories = new List<MedicalHistory>();
        private readonly string jsonFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "medicalHistory.json");

        public FormMedicalHistory()
        {
            InitializeComponent();
            LoadHistories();
            RefreshDataGridView();
        }

        private void LoadHistories()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    histories = JsonConvert.DeserializeObject<List<MedicalHistory>>(json) ?? new List<MedicalHistory>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading histories: {ex.Message}");
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
                MessageBox.Show($"Error saving histories: {ex.Message}");
            }
        }

        private void RefreshDataGridView()
        {
            dataGridViewMedicalHistory.Rows.Clear();
            foreach (var h in histories)
            {
                dataGridViewMedicalHistory.Rows.Add(h.PatientName, h.Condition, h.DateRecorded.ToString("yyyy-MM-dd"));
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim().ToLower();
            var filtered = histories
                .Where(h => h.PatientName.ToLower().Contains(search))
                .ToList();

            dataGridViewMedicalHistory.Rows.Clear();
            foreach (var h in filtered)
            {
                dataGridViewMedicalHistory.Rows.Add(h.PatientName, h.Condition, h.DateRecorded.ToString("yyyy-MM-dd"));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddMedicalHistory())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    histories.Add(form.NewHistory);
                    SaveHistories();
                    RefreshDataGridView();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicalHistory.CurrentRow == null) return;

            int index = dataGridViewMedicalHistory.CurrentRow.Index;
            var history = histories[index];

            using (var form = new FormAddMedicalHistory(history))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    histories[index] = form.NewHistory;
                    SaveHistories();
                    RefreshDataGridView();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicalHistory.CurrentRow == null) return;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this medical history record? This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                int index = dataGridViewMedicalHistory.CurrentRow.Index;
                histories.RemoveAt(index);
                SaveHistories();
                RefreshDataGridView();
            }
        }
    }

    public class MedicalHistory
    {
        public string PatientName { get; set; } = "";
        public string Condition { get; set; } = "";
        public DateTime DateRecorded { get; set; } = DateTime.Now;
    }
}
