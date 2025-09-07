using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EstiponaClinic
{
    public partial class FormTeethChart : Form
    {
        private int PatientID;
        private string PatientName;
        private Image toothImage;
        private int PatientAge;


        // ✅ use string keys for tooth numbers
        private Dictionary<string, string> teethStates = new();
        private readonly string jsonPath = Path.Combine(Application.StartupPath, "dentalrecord.json");

        // Define available states in order
        private readonly List<(string State, Color Color, Color ForeColor)> stateCycle = new()
        {
            ("Healthy",   Color.LightGreen, Color.Black),
            ("Decayed",   Color.Red,        Color.Black),
            ("Completed", Color.Blue,       Color.White),
            ("Missing",   Color.Black,      Color.White)
        };

        public FormTeethChart(int patientId, string patientName, int patientAge)
        {
            InitializeComponent();
            this.PatientID = patientId;
            this.PatientName = patientName;
            this.PatientAge = patientAge; // ✅ new field
        }

        private void FormTeethChart_Load(object sender, EventArgs e)
        {
            textBoxPatientNameTeethChart.Text = PatientName;

            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                var records = JsonConvert.DeserializeObject<Dictionary<int, Dictionary<string, string>>>(json)
                              ?? new Dictionary<int, Dictionary<string, string>>();

                if (records.ContainsKey(PatientID))
                {
                    teethStates = records[PatientID];
                }
            }

            // ✅ use actual age
            GenerateTeethButtons(PatientAge);

            ApplyTeethStates();
        }


        private void GenerateTeethButtons(int age = 18)
        {
            panelTeethChartEdit.Controls.Clear();

            int toothSize = 40;  // button size
            int spacing = 10;    // spacing between teeth
            int startY = 20;     // vertical offset

            string[] upperRight, upperLeft, lowerLeft, lowerRight;

            if (age <= 6)
            {
                // 🦷 Primary teeth (20 total)
                upperRight = new[] { "55", "54", "53", "52", "51" };
                upperLeft = new[] { "61", "62", "63", "64", "65" };
                lowerLeft = new[] { "85", "84", "83", "82", "81" };
                lowerRight = new[] { "71", "72", "73", "74", "75" };
            }
            else
            {
                // 🦷 Permanent teeth (32 total)
                upperRight = new[] { "18", "17", "16", "15", "14", "13", "12", "11" };
                upperLeft = new[] { "21", "22", "23", "24", "25", "26", "27", "28" };
                lowerLeft = new[] { "48", "47", "46", "45", "44", "43", "42", "41" };
                lowerRight = new[] { "31", "32", "33", "34", "35", "36", "37", "38" };
            }

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
                Tag = toothNumber // ✅ keep as string
            };
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.FlatAppearance.BorderSize = 1;
            btn.Click += ToothButton_Click;
            return btn;
        }

        private void ToothButton_Click(object sender, EventArgs e)
        {
            if (sender is RoundButton btn && btn.Tag != null) // ✅ use RoundButton
            {
                string toothNumber = btn.Tag.ToString(); // safe conversion

                string currentState = teethStates.ContainsKey(toothNumber)
                    ? teethStates[toothNumber]
                    : "Healthy";

                int idx = stateCycle.FindIndex(s => s.State == currentState);
                idx = (idx + 1) % stateCycle.Count;

                teethStates[toothNumber] = stateCycle[idx].State;
                btn.BackColor = stateCycle[idx].Color;
                btn.ForeColor = stateCycle[idx].ForeColor;
            }
        }



        private void ApplyTeethStates()
        {
            foreach (Control ctrl in panelTeethChartEdit.Controls)
            {
                if (ctrl is RoundButton btn && btn.Tag != null) // ✅ RoundButton
                {
                    string toothNum = btn.Tag.ToString();

                    if (teethStates.ContainsKey(toothNum))
                    {
                        var state = stateCycle.Find(s => s.State == teethStates[toothNum]);
                        if (state != default)
                        {
                            btn.BackColor = state.Color;
                            btn.ForeColor = state.ForeColor;
                        }
                    }
                }
            }
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Load existing data
            Dictionary<int, Dictionary<string, string>> records;
            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                records = JsonConvert.DeserializeObject<Dictionary<int, Dictionary<string, string>>>(json)
                          ?? new Dictionary<int, Dictionary<string, string>>();
            }
            else
            {
                records = new Dictionary<int, Dictionary<string, string>>();
            }

            // Save current teeth states only
            records[PatientID] = new Dictionary<string, string>(teethStates);

            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(records, Formatting.Indented));

            MessageBox.Show($"Dental chart saved for {PatientName} (ID: {PatientID})",
                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK; // ✅ So DentalRecord knows to refresh
            this.Close();
        }
    }
}
