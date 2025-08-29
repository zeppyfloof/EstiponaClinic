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
            int x = 5, y = 5;

            for (int i = 1; i <= 32; i++)
            {
                Button toothBtn = new()
                {
                    Text = i.ToString(),
                    Tag = i,
                    Width = 40,
                    Height = 40,
                    Left = x,
                    Top = y,
                    BackColor = Color.LightGreen,
                    ForeColor = Color.Black // default
                };
                toothBtn.Click += ToothButton_Click;

                panelTeethChartEdit.Controls.Add(toothBtn);

                x += 45;
                if (i % 16 == 0) { y += 50; x = 5; }
            }
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
