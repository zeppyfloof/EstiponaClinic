using System;
using System.Drawing;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormDentalRecord : Form
    {
        // Tooth states
        private enum ToothStatus { Healthy, Extracted, Filling, Crown }
        private Button[] toothButtons;

        public FormDentalRecord()
        {
            InitializeComponent();
            CreateTeethChartButtons();
            panelTeethChart.Resize += PanelTeethChart_Resize; // auto-adjust on resize
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
                var b = new Button();
                b.Text = (i + 1).ToString();
                b.Name = $"tooth{i + 1}";
                b.Size = new Size(35, 35); // slightly smaller to fit
                b.BackColor = Color.LightGreen; // Healthy default
                b.Tag = ToothStatus.Healthy;
                b.Click += Tooth_Click;
                b.FlatStyle = FlatStyle.Standard;

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

            // Since height is 130, keep rows compact
            int upperY = 25;
            int lowerY = 70;

            // Upper teeth
            for (int i = 0; i < 16; i++)
            {
                var b = toothButtons[i];
                b.Size = new Size(buttonSize, buttonSize);
                b.Location = new Point(startX + i * (buttonSize + spacing), upperY);
            }

            // Lower teeth
            for (int i = 0; i < 16; i++)
            {
                var b = toothButtons[i + 16];
                b.Size = new Size(buttonSize, buttonSize);
                b.Location = new Point(startX + i * (buttonSize + spacing), lowerY);
            }
        }

        private void Tooth_Click(object? sender, EventArgs e)
        {
            if (sender is not Button b) return;

            var status = (ToothStatus)b.Tag;

            // Cycle through statuses
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
