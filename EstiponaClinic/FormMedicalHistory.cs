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
        private readonly Random rng = new();

        public FormMedicalHistory()
        {
            InitializeComponent();
            LoadHistories();

            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;

            RefreshGrid();
        }

        // ------------------ MODEL ------------------
        public class MedicalHistory
        {
            public int MedicalHistoryID { get; set; }   // int ID
            public int PatientID { get; set; }          // int ID
            public string PatientName { get; set; } = string.Empty; // display only
            public string Condition { get; set; } = string.Empty;
            public DateTime DateRecorded { get; set; } = DateTime.Now;
            public string Allergies { get; set; } = string.Empty;
            public string Abnormalities { get; set; } = string.Empty;
            public string BloodPressure { get; set; } = string.Empty;
            public string DrugsTaken { get; set; } = string.Empty;
        }

        // ------------------ LOAD/SAVE ------------------
        private void LoadHistories()
        {
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    var json = File.ReadAllText(jsonFilePath);
                    var loaded = JsonConvert.DeserializeObject<List<MedicalHistory>>(json);
                    if (loaded != null) histories = loaded;
                }
                catch { histories = new(); }
            }
        }

        private void SaveHistories()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath)!);
            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(histories, Formatting.Indented));
        }

        // ------------------ GRID ------------------
        private void RefreshGrid()
        {
            dataGridViewMedicalHistory.DataSource = null;
            dataGridViewMedicalHistory.DataSource = histories.Select(h => new
            {
                h.MedicalHistoryID,
                h.PatientID,
                h.PatientName,
                h.Condition,
                h.DateRecorded,
                h.Allergies,
                h.Abnormalities,
                h.BloodPressure,
                h.DrugsTaken
            }).ToList();

            if (dataGridViewMedicalHistory.Columns["MedicalHistoryID"] != null)
                dataGridViewMedicalHistory.Columns["MedicalHistoryID"].Visible = false;
            if (dataGridViewMedicalHistory.Columns["PatientID"] != null)
                dataGridViewMedicalHistory.Columns["PatientID"].Visible = false;
        }

        // ------------------ HELPERS ------------------
        private int GenerateUniqueHistoryID()
        {
            int id;
            do { id = rng.Next(100000, 999999); }
            while (histories.Any(h => h.MedicalHistoryID == id));
            return id;
        }

        // ------------------ BUTTONS ------------------
        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var existing = histories.Select(h => h.PatientID).ToList(); // prevent duplicate patient link
            using var form = new FormAddMedicalHistory(existing);
            if (form.ShowDialog() == DialogResult.OK && form.NewHistory != null)
            {
                // assign unique int ID here
                form.NewHistory.MedicalHistoryID = GenerateUniqueHistoryID();
                histories.Add(form.NewHistory);
                SaveHistories();
                RefreshGrid();
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            if (dataGridViewMedicalHistory.CurrentRow == null) return;

            int historyId = Convert.ToInt32(dataGridViewMedicalHistory.CurrentRow
                .Cells["MedicalHistoryID"].Value);
            var history = histories.FirstOrDefault(h => h.MedicalHistoryID == historyId);
            if (history == null) return;

            using var form = new FormEditMedicalHistory(history);
            if (form.ShowDialog() == DialogResult.OK && form.UpdatedHistory != null)
            {
                history.Condition = form.UpdatedHistory.Condition;
                history.DateRecorded = form.UpdatedHistory.DateRecorded;
                history.Allergies = form.UpdatedHistory.Allergies;
                history.Abnormalities = form.UpdatedHistory.Abnormalities;
                history.BloodPressure = form.UpdatedHistory.BloodPressure;
                history.DrugsTaken = form.UpdatedHistory.DrugsTaken;

                SaveHistories();
                RefreshGrid();
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            if (dataGridViewMedicalHistory.SelectedRows.Count == 0) return;

            int selectedID = Convert.ToInt32(
                dataGridViewMedicalHistory.SelectedRows[0].Cells["MedicalHistoryID"].Value);

            var history = histories.FirstOrDefault(h => h.MedicalHistoryID == selectedID);
            if (history == null) return;

            var confirm = MessageBox.Show(
                $"Delete medical history for {history.PatientName}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                histories.Remove(history);
                SaveHistories();
                RefreshGrid();
            }
        }

        // ------------------ SEARCH ------------------
        private void textBoxSearch_TextChanged(object? sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim().ToLower();
            var filtered = histories.Where(h =>
                h.PatientName.ToLower().Contains(search) ||
                h.Condition.ToLower().Contains(search) ||
                h.Allergies.ToLower().Contains(search) ||
                h.Abnormalities.ToLower().Contains(search) ||
                h.BloodPressure.ToLower().Contains(search) ||
                h.DrugsTaken.ToLower().Contains(search)
            ).ToList();

            dataGridViewMedicalHistory.DataSource = null;
            dataGridViewMedicalHistory.DataSource = filtered.Select(h => new
            {
                h.MedicalHistoryID,
                h.PatientID,
                h.PatientName,
                h.Condition,
                h.DateRecorded,
                h.Allergies,
                h.Abnormalities,
                h.BloodPressure,
                h.DrugsTaken
            }).ToList();

            if (dataGridViewMedicalHistory.Columns["MedicalHistoryID"] != null)
                dataGridViewMedicalHistory.Columns["MedicalHistoryID"].Visible = false;
            if (dataGridViewMedicalHistory.Columns["PatientID"] != null)
                dataGridViewMedicalHistory.Columns["PatientID"].Visible = false;
        }
    }
}
