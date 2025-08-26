using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json; // Make sure you installed Newtonsoft.Json via NuGet
using static EstiponaClinic.FormPatients;

namespace EstiponaClinic
{
    public partial class FormDentalRecord : Form
    {
        private enum ToothStatus { Healthy, Extracted, Filling, Crown }
        private Button[] toothButtons;

        private List<Patient> patients = new();

        public FormDentalRecord()
        {
            InitializeComponent();
            CreateTeethChartButtons();
            panelTeethChart.Resize += PanelTeethChart_Resize;

            LoadPatients(); // 👈 Load on start
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

                    // Bind to DataGridView
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

        private void PanelTeethChart_Resize(object? sender, EventArgs e)
        {
            LayoutTeethButtons();
        }

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
                    BackColor = Color.LightGreen,
                    Tag = ToothStatus.Healthy,
                    FlatStyle = FlatStyle.Standard
                };
                b.Click += Tooth_Click;

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
            {
                toothButtons[i].Location = new Point(startX + i * (buttonSize + spacing), upperY);
            }

            for (int i = 0; i < 16; i++)
            {
                toothButtons[i + 16].Location = new Point(startX + i * (buttonSize + spacing), lowerY);
            }
        }

        private void Tooth_Click(object? sender, EventArgs e)
        {
            if (sender is not Button b) return;

            var status = (ToothStatus)b.Tag;

            status = status switch
            {
                ToothStatus.Healthy => ToothStatus.Extracted,
                ToothStatus.Extracted => ToothStatus.Filling,
                ToothStatus.Filling => ToothStatus.Crown,
                _ => ToothStatus.Healthy
            };

            ApplyStatus(b, status);
        }

        private void ApplyStatus(Button b, ToothStatus status)
        {
            b.Tag = status;
            b.BackColor = status switch
            {
                ToothStatus.Healthy => Color.LightGreen,
                ToothStatus.Extracted => Color.Red,
                ToothStatus.Filling => Color.Yellow,
                ToothStatus.Crown => Color.SkyBlue,
                _ => Color.LightGreen
            };
        }
    }
}
