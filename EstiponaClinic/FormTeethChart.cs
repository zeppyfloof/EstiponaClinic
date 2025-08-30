using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormTeethChart : Form
    {
        private int PatientID;
        private string PatientName;
        private Image toothImage;

        private Dictionary<int, string> teethStates = new();
        private readonly string jsonPath = Path.Combine(Application.StartupPath, "dentalrecord.json");

        // Define available states in order
        private readonly List<(string State, Color Color, Color ForeColor)> stateCycle = new()
        {
            ("Healthy",   Color.LightGreen, Color.Black),
            ("Decayed",   Color.Red,        Color.Black),
            ("Completed", Color.Blue,       Color.White),
            ("Missing",   Color.Black,      Color.White)
        };

        public FormTeethChart(int patientId, string patientName)
        {
            InitializeComponent();
            this.PatientID = patientId;
            this.PatientName = patientName;
        }

        private void FormTeethChart_Load(object sender, EventArgs e)
        {
            textBoxPatientNameTeethChart.Text = PatientName;

            // ✅ Load tooth image once
            string imgPath = @"D:\dentalrecord4\EstiponaClinic\images\tooth.png";
            if (File.Exists(imgPath))
                toothImage = Image.FromFile(imgPath);

            GenerateTeethButtons();

            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                var records = JsonConvert.DeserializeObject<Dictionary<int, Dictionary<int, string>>>(json)
                              ?? new Dictionary<int, Dictionary<int, string>>();

                if (records.ContainsKey(PatientID))
                {
                    teethStates = records[PatientID];
                    ApplyTeethStates();
                }
            }
        }

        private void GenerateTeethButtons()
        {
            panelTeethChartEdit.Controls.Clear();

            int toothSize = 40;  // round button size
            int spacing = 10;    // space between teeth
            int startY = 20;     // vertical offset

            string[] upperRight = { "18", "17", "16", "15", "14", "13", "12", "11" };
            string[] upperLeft = { "21", "22", "23", "24", "25", "26", "27", "28" };
            string[] lowerLeft = { "48", "47", "46", "45", "44", "43", "42", "41" };
            string[] lowerRight = { "31", "32", "33", "34", "35", "36", "37", "38" };

            // Total number of buttons per row = 16
            int totalButtons = upperRight.Length + upperLeft.Length;
            int rowWidth = totalButtons * toothSize + (totalButtons - 1) * spacing;

            // Center horizontally inside panel
            int startX = (panelTeethChartEdit.Width - rowWidth) / 2;

            // --- TOP ROW ---
            for (int i = 0; i < upperRight.Length; i++)
            {
                var btn = CreateToothButton(upperRight[i]);
                btn.Location = new Point(startX + i * (toothSize + spacing), startY);
                panelTeethChartEdit.Controls.Add(btn);
            }
            for (int i = 0; i < upperLeft.Length; i++)
            {
                var btn = CreateToothButton(upperLeft[i]);
                btn.Location = new Point(startX + (upperRight.Length + i) * (toothSize + spacing), startY);
                panelTeethChartEdit.Controls.Add(btn);
            }

            // --- BOTTOM ROW ---
            for (int i = 0; i < lowerLeft.Length; i++)
            {
                var btn = CreateToothButton(lowerLeft[i]);
                btn.Location = new Point(startX + i * (toothSize + spacing), startY + toothSize + 2 * spacing);
                panelTeethChartEdit.Controls.Add(btn);
            }
            for (int i = 0; i < lowerRight.Length; i++)
            {
                var btn = CreateToothButton(lowerRight[i]);
                btn.Location = new Point(startX + (lowerLeft.Length + i) * (toothSize + spacing), startY + toothSize + 2 * spacing);
                panelTeethChartEdit.Controls.Add(btn);
            }
        }


        private RoundButton CreateToothButton(string toothNumber)
        {
            var btn = new RoundButton
            {
                Width = 40,
                Height = 40,
                Text = toothNumber,
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                Tag = toothNumber
            };
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.FlatAppearance.BorderSize = 1;
            btn.Click += ToothButton_Click;
            return btn;
        }



        private void ToothButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                int toothNumber = Convert.ToInt32(btn.Tag);

                string currentState = teethStates.ContainsKey(toothNumber) ? teethStates[toothNumber] : "Healthy";

                int idx = stateCycle.FindIndex(s => s.State == currentState);
                idx = (idx + 1) % stateCycle.Count;

                teethStates[toothNumber] = stateCycle[idx].State;
                btn.BackColor = stateCycle[idx].Color;
                btn.ForeColor = stateCycle[idx].ForeColor; // ✅ set font color
            }
        }

        private void ApplyTeethStates()
        {
            foreach (Control ctrl in panelTeethChartEdit.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null)
                {
                    int toothNum = Convert.ToInt32(btn.Tag);
                    if (teethStates.ContainsKey(toothNum))
                    {
                        var state = stateCycle.Find(s => s.State == teethStates[toothNum]);
                        if (state != default)
                        {
                            btn.BackColor = state.Color;
                            btn.ForeColor = state.ForeColor; // ✅ set font color
                        }
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Dictionary<int, Dictionary<int, string>> records;

            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                records = JsonConvert.DeserializeObject<Dictionary<int, Dictionary<int, string>>>(json)
                          ?? new Dictionary<int, Dictionary<int, string>>();
            }
            else
            {
                records = new Dictionary<int, Dictionary<int, string>>();
            }

            records[PatientID] = teethStates;

            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(records, Formatting.Indented));

            MessageBox.Show($"Dental chart saved for {PatientName} (ID: {PatientID})",
                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
