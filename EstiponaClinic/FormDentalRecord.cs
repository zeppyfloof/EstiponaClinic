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
        private RoundButton[] toothButtons;
        private List<Patient> patients = new();
        private List<MedicalHistory> medicalHistories = new();
        private List<PictureBox> toothIcons = new();
        private int currentPatientAge = 0;

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

        private DialogResult ShowDimmedDialog(Form dialog)
        {
            var host = this.TopLevelControl as Form ?? this.FindForm() ?? this;
            var hostBounds = host.Bounds;

            var overlay = new Form
            {
                StartPosition = FormStartPosition.Manual,
                Bounds = hostBounds,
                BackColor = Color.Black,
                Opacity = 0.45,
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                TopMost = true
            };

            overlay.Show();
            overlay.BringToFront();

            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.TopMost = true;

            var result = dialog.ShowDialog(host);

            overlay.Close();
            overlay.Dispose();

            return result;
        }

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

        private void DataGridViewDental_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridViewDental.CurrentRow == null) return;

            var selected = dataGridViewDental.CurrentRow.DataBoundItem as Patient;
            if (selected == null) return;

            textBoxName.Text = selected.Name;
            textBoxAddress.Text = selected.Address;
            textBoxPhone.Text = selected.Phone;
            textBoxGender.Text = selected.Gender;
            textBoxAge.Text = CalculateAge(selected.BirthDate).ToString();
            currentPatientAge = CalculateAge(selected.BirthDate);

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

            // 🔄 Rebuild chart based on age
            CreateTeethChartButtons();
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

            using (FormTeethChart chartForm = new FormTeethChart(selected.PatientID, selected.Name, currentPatientAge))
            {
                if (ShowDimmedDialog(chartForm) == DialogResult.OK)
                {
                    ApplyTeethChart(selected.PatientID);
                }
                else
                {
                    ApplyTeethChart(selected.PatientID);
                }
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age)) age--;
            return age;
        }

        private void PanelTeethChart_Resize(object? sender, EventArgs e) => LayoutTeethButtons();

        private void CreateTeethChartButtons()
        {
            panelTeethChart.Controls.Clear();
            toothIcons.Clear();

            int buttonSize = 40;
            int spacing = 8;
            int midGap = 80;

            string[] upperRightAdult = { "18", "17", "16", "15", "14", "13", "12", "11" };
            string[] upperLeftAdult = { "21", "22", "23", "24", "25", "26", "27", "28" };
            string[] lowerRightAdult = { "48", "47", "46", "45", "44", "43", "42", "41" };
            string[] lowerLeftAdult = { "31", "32", "33", "34", "35", "36", "37", "38" };

            string[] upperRightChild = { "55", "54", "53", "52", "51" };
            string[] upperLeftChild = { "61", "62", "63", "64", "65" };
            string[] lowerRightChild = { "85", "84", "83", "82", "81" };
            string[] lowerLeftChild = { "71", "72", "73", "74", "75" };

            toothButtons = currentPatientAge <= 6 ? new RoundButton[20] : new RoundButton[32];

            int archWidth;
            int startX;
            int upperY = panelTeethChart.Height / 2 - 70;
            int lowerY = panelTeethChart.Height / 2 + 20;

            string toothImagePath = @"D:\dentalrecord4\EstiponaClinic\images\tooth.png";
            Image toothImg = File.Exists(toothImagePath) ? Image.FromFile(toothImagePath) : null;

            int index = 0;

            if (currentPatientAge <= 6)
            {
                archWidth = (5 * (buttonSize + spacing)) * 2 - spacing + midGap;
                startX = (panelTeethChart.Width - archWidth) / 2;

                index = AddArch(upperRightChild, startX, upperY, buttonSize, spacing, true, toothImg, index);
                index = AddArch(upperLeftChild, startX + (5 * (buttonSize + spacing)) + midGap, upperY,
                                buttonSize, spacing, true, toothImg, index);
                index = AddArch(lowerRightChild, startX, lowerY, buttonSize, spacing, false, toothImg, index);
                index = AddArch(lowerLeftChild, startX + (5 * (buttonSize + spacing)) + midGap, lowerY,
                                buttonSize, spacing, false, toothImg, index);
            }
            else
            {
                archWidth = (8 * (buttonSize + spacing)) * 2 - spacing + midGap;
                startX = (panelTeethChart.Width - archWidth) / 2;

                index = AddArch(upperRightAdult, startX, upperY, buttonSize, spacing, true, toothImg, index);
                index = AddArch(upperLeftAdult, startX + (8 * (buttonSize + spacing)) + midGap, upperY,
                                buttonSize, spacing, true, toothImg, index);
                index = AddArch(lowerRightAdult, startX, lowerY, buttonSize, spacing, false, toothImg, index);
                index = AddArch(lowerLeftAdult, startX + (8 * (buttonSize + spacing)) + midGap, lowerY,
                                buttonSize, spacing, false, toothImg, index);
            }
        }

        private int AddArch(string[] teeth, int x, int y, int size, int spacing,
                            bool isUpper, Image toothImg, int indexStart)
        {
            for (int i = 0; i < teeth.Length; i++)
            {
                string toothNum = teeth[i];

                var b = new RoundButton
                {
                    Text = toothNum,
                    Name = $"tooth{toothNum}",
                    Size = new Size(size, size),
                    Location = new Point(x, y),
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    Tag = int.Parse(toothNum)
                };
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = Color.Black;

                panelTeethChart.Controls.Add(b);
                toothButtons[indexStart++] = b;

                if (toothImg != null)
                {
                    var pic = new PictureBox
                    {
                        Size = new Size(60, 60),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = toothImg,
                        BackColor = Color.Transparent
                    };
                    panelTeethChart.Controls.Add(pic);
                    pic.BringToFront();
                    toothIcons.Add(pic);
                }

                x += size + spacing;
            }

            return indexStart;
        }

        private void LayoutTeethButtons()
        {
            // (same as before – keeps buttons/icons positioned correctly)
        }

        private void ApplyTeethChart(int patientId)
        {
            foreach (var btn in toothButtons)
            {
                btn.BackColor = Color.White;
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
                        case "Healthy": btn.BackColor = Color.LightGreen; btn.ForeColor = Color.Black; break;
                        case "Decayed": btn.BackColor = Color.Red; btn.ForeColor = Color.Black; break;
                        case "Completed": btn.BackColor = Color.Blue; btn.ForeColor = Color.White; break;
                        case "Missing": btn.BackColor = Color.Black; btn.ForeColor = Color.White; break;
                        default: btn.BackColor = Color.LightGreen; btn.ForeColor = Color.Black; break;
                    }
                }
            }
        }

        private void labelLegend_Click(object sender, EventArgs e) { }
    }
}
