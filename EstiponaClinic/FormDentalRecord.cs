using System;
using System.Drawing;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormDentalRecord : Form
    {
        // Tooth states
        private enum ToothStatus { Healthy, Extracted, Filling, Crown }

        // Declare buttons array here so it's available in all methods
        private Button[] toothButtons;

        public FormDentalRecord()
        {
            InitializeComponent();
            CreateTeethChartButtons();   // runtime creation -> designer stays happy
        }

        private void CreateTeethChartButtons()
        {
            // Prepare array
            toothButtons = new Button[32];

            // Layout
            int buttonSize = 40;
            int spacing = 5;
            int countPerRow = 16;

            // Center the row inside the panel
            int rowWidth = countPerRow * buttonSize + (countPerRow - 1) * spacing;
            int startX = Math.Max(12, (panelTeethChart.Width - rowWidth) / 2);
            int upperY = 45;   // below "Upper Teeth" label
            int lowerY = 120;  // adjusted so it fits in taller panel

            // Create upper teeth (1–16)
            for (int i = 0; i < 16; i++)
            {
                var b = MakeToothButton(i + 1, startX + i * (buttonSize + spacing), upperY, buttonSize);
                toothButtons[i] = b;
                panelTeethChart.Controls.Add(b);
            }

            // Create lower teeth (17–32)
            for (int i = 0; i < 16; i++)
            {
                var b = MakeToothButton(i + 17, startX + i * (buttonSize + spacing), lowerY, buttonSize);
                toothButtons[i + 16] = b;
                panelTeethChart.Controls.Add(b);
            }
        }

        private Button MakeToothButton(int toothNumber, int x, int y, int size)
        {
            var b = new Button();
            b.Text = toothNumber.ToString();
            b.Name = $"tooth{toothNumber}";
            b.Size = new Size(size, size);
            b.Location = new Point(x, y);
            b.BackColor = Color.LightGreen; // Healthy default
            b.Tag = ToothStatus.Healthy;
            b.Click += Tooth_Click;
            b.FlatStyle = FlatStyle.Standard;
            return b;
        }

        private void Tooth_Click(object? sender, EventArgs e)
        {
            if (sender is not Button b) return;

            var status = (ToothStatus)b.Tag;

            // Cycle statuses
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
