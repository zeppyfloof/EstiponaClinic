using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json; // Install Newtonsoft.Json via NuGet
using static EstiponaClinic.FormPatients;

namespace EstiponaClinic
{
    public partial class FormDentalRecord : Form
    {
        private Button[] toothButtons;

        private List<Patient> patients = new();
        private List<MedicalHistory> medicalHistories = new();

        // same JSON path used in FormTeethChart
        private readonly string jsonPath = Path.Combine(Application.StartupPath, "dentalrecord.json");

        public FormDentalRecord()
        {
            InitializeComponent();
            CreateTeethChartButtons();
            panelTeethChart.Resize += PanelTeethChart_Resize;

            LoadPatients();
            LoadMedicalHistories();

            dataGridViewDental.SelectionChanged += DataGridViewDental_SelectionChanged;
        }

        // ------------------ MODELS ------------------
        public class MedicalHistory
        {
            public int PatientID { get; set; }
            public string Condition { get; set; } = string.Empty;
            public DateTime DateRecorded { get; set; }
            public string Allergies { get; set; } = string.Empty;
            public string Abnormalities { get; set; } = string.Empty;
            public string BloodPressure { get; set; } = string.Empty;
            public string DrugsTaken { get; set; } = string.Empty;
        }

        // ------------------ LOAD PATIENTS ------------------
        private void LoadPatients()
        {
            try
            {
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "EstiponaClinic",
                    "patients.json"
                );

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    patients = JsonConvert.DeserializeObject<List<Patient>>(json) ?? new List<Patient>();

                    dataGridViewDental.DataSource = null;
                    dataGridViewDental.DataSource = patients;
                }
                else
                {
                    MessageBox.Show("patients.json not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------ LOAD MEDICAL HISTORY ------------------
        private void LoadMedicalHistories()
        {
            try
            {
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "EstiponaClinic",
                    "medicalhistory.json"
                );

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    medicalHistories = JsonConvert.DeserializeObject<List<MedicalHistory>>(json) ?? new List<MedicalHistory>();
                }
                else
                {
                    medicalHistories = new List<MedicalHistory>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medical histories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                medicalHistories = new List<MedicalHistory>();
            }
        }

        // ------------------ GRID SELECTION ------------------
        private void DataGridViewDental_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridViewDental.CurrentRow == null) return;

            var selected = dataGridViewDental.CurrentRow.DataBoundItem as Patient;
            if (selected == null) return;

            // Fill patient info panel
            textBoxName.Text = selected.Name;
            textBoxAddress.Text = selected.Address;
            textBoxPhone.Text = selected.Phone;
            textBoxGender.Text = selected.Gender;
            textBoxAge.Text = CalculateAge(selected.BirthDate).ToString();

            // Fill medical history if available
            var history = medicalHistories.FirstOrDefault(h => h.PatientID == selected.PatientID);
            if (history != null)
            {
                textBoxCondition.Text = history.Condition;
                dateTimePickerDateRecorded.Value = history.DateRecorded == default ? DateTime.Now : history.DateRecorded;
                textBoxAllergies.Text = history.Allergies;
                textBoxAbnormalities.Text = history.Abnormalities;
                textBoxBloodPressure.Text = history.BloodPressure;
                textBoxDrugsTaken.Text = history.DrugsTaken;
            }
            else
            {
                textBoxCondition.Text = string.Empty;
                dateTimePickerDateRecorded.Value = DateTime.Now;
                textBoxAllergies.Text = string.Empty;
                textBoxAbnormalities.Text = string.Empty;
                textBoxBloodPressure.Text = string.Empty;
                textBoxDrugsTaken.Text = string.Empty;
            }

            // Apply saved teeth chart colors (or default Healthy if none)
            ApplyTeethChart(selected.PatientID);
        }

        private void buttonTeethChartEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDental.CurrentRow == null)
            {
                MessageBox.Show("Please select a patient first.", "No Patient Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = dataGridViewDental.CurrentRow.DataBoundItem as Patient;
            if (selected == null)
            {
                MessageBox.Show("Please select a valid patient.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (FormTeethChart chartForm = new FormTeethChart(selected.PatientID, selected.Name))
            {
                chartForm.ShowDialog();
            }

            // refresh teeth chart after closing editor
            ApplyTeethChart(selected.PatientID);
        }

        // ------------------ HELPERS ------------------
        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age)) age--;
            return age;
        }

        private void PanelTeethChart_Resize(object? sender, EventArgs e) => LayoutTeethButtons();

        private void CreateTeethChartButtons()
        {
            toothButtons = new Button[32];

            for (int i = 0; i < 32; i++)
            {
                var b = new Button
                {
                    Text = (i + 1).ToString(),
                    Name = $"tooth{i + 1}",
                    Size = new Size(35, 35),
                    BackColor = Color.LightGreen, // default Healthy
                    FlatStyle = FlatStyle.Standard,
                    Tag = i + 1
                };

                // Keep buttons enabled so ForeColor works
                b.Enabled = true;

                // Optional: ignore clicks on main form
                b.Click += (s, e) => { /* do nothing */ };

                toothButtons[i] = b;
                panelTeethChart.Controls.Add(b);
            }

            LayoutTeethButtons();
        }

        private void LayoutTeethButtons()
        {
            if (toothButtons == null || toothButtons.Length == 0) return;

            int buttonSize = 35;
            int spacing = 5;
            int countPerRow = 16;

            int rowWidth = countPerRow * buttonSize + (countPerRow - 1) * spacing;
            int startX = Math.Max(12, (panelTeethChart.Width - rowWidth) / 2);

            int upperY = 25;
            int lowerY = 70;

            for (int i = 0; i < 16; i++)
                toothButtons[i].Location = new Point(startX + i * (buttonSize + spacing), upperY);

            for (int i = 0; i < 16; i++)
                toothButtons[i + 16].Location = new Point(startX + i * (buttonSize + spacing), lowerY);
        }

        // Apply saved states OR default Healthy if no data exists
        private void ApplyTeethChart(int patientId)
        {
            // Default: all Healthy
            foreach (var btn in toothButtons)
            {
                btn.BackColor = Color.LightGreen;
                btn.ForeColor = Color.Black;
            }

            if (!File.Exists(jsonPath)) return;

            string json = File.ReadAllText(jsonPath);
            var records = JsonConvert.DeserializeObject<Dictionary<int, Dictionary<int, string>>>(json)
                          ?? new Dictionary<int, Dictionary<int, string>>();

            if (!records.ContainsKey(patientId)) return;

            var teethStates = records[patientId];

            foreach (var btn in toothButtons)
            {
                int toothNum = (int)btn.Tag;
                if (teethStates.ContainsKey(toothNum))
                {
                    string status = teethStates[toothNum];
                    switch (status)
                    {
                        case "Healthy":
                            btn.BackColor = Color.LightGreen;
                            btn.ForeColor = Color.Black;
                            break;
                        case "Decayed":
                            btn.BackColor = Color.Red;
                            btn.ForeColor = Color.Black;
                            break;
                        case "Completed":
                            btn.BackColor = Color.Blue;
                            btn.ForeColor = Color.White;
                            break;
                        case "Missing":
                            btn.BackColor = Color.Black;
                            btn.ForeColor = Color.White; // text white for black
                            break;
                        default:
                            btn.BackColor = Color.LightGreen;
                            btn.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }
    }
}
