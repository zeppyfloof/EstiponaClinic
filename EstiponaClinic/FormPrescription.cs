using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormPrescription : Form
    {
        private FormPatients.Patient? selectedPatientForPrint;
        private string instructionsText = "";
        private string doctorNotesText = "";
        private List<PrescriptionItem> prescriptions = new();

        private List<FormPatients.Patient> patients = new();
        private readonly string patientsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "patients.json"
        );

        public class PrescriptionItem
        {
            public string Medicine { get; set; } = "";
            public string Dosage { get; set; } = "";
        }

        public FormPrescription()
        {
            InitializeComponent();

            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxAge.ReadOnly = true;
            textBoxAddress.ReadOnly = true;

            LoadPatients();

            comboBoxPatient.SelectedIndexChanged += ComboBoxPatient_SelectedIndexChanged;
        }

        private void LoadPatients()
        {
            if (!File.Exists(patientsFile)) return;

            string json = File.ReadAllText(patientsFile);
            patients = (JsonConvert.DeserializeObject<List<FormPatients.Patient>>(json) ?? new())
                .Where(p => p != null)
                .ToList();

            comboBoxPatient.DataSource = patients;
            comboBoxPatient.DisplayMember = "Name";
            comboBoxPatient.ValueMember = "PatientID";
        }

        private void ComboBoxPatient_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem is FormPatients.Patient patient)
            {
                int age = DateTime.Now.Year - patient.BirthDate.Year;
                if (DateTime.Now.Date < patient.BirthDate.AddYears(age)) age--;

                textBoxAge.Text = age.ToString();
                textBoxAddress.Text = patient.Address ?? string.Empty;
            }
        }

        private void ButtonGenerate_Click(object? sender, EventArgs e)
        {
            if (!(comboBoxPatient.SelectedItem is FormPatients.Patient patient))
            {
                MessageBox.Show("Please select a patient.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedPatientForPrint = patient;

            // Collect all prescriptions from DataGridView
            prescriptions.Clear();
            foreach (DataGridViewRow row in dgvPrescriptions.Rows)
            {
                if (row.IsNewRow) continue;

                string med = row.Cells["Medicine"].Value?.ToString()?.Trim() ?? "";
                string dose = row.Cells["Dosage"].Value?.ToString()?.Trim() ?? "";

                if (!string.IsNullOrWhiteSpace(med))
                {
                    prescriptions.Add(new PrescriptionItem { Medicine = med, Dosage = dose });
                }
            }

            instructionsText = (richTextBoxInstructions?.Text ?? "").Trim();
            doctorNotesText = (richTextBoxNotes?.Text ?? "").Trim();

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            pd.PrintPage += Pd_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 600,
                StartPosition = FormStartPosition.CenterScreen
            };

            preview.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (selectedPatientForPrint == null) return;

            Graphics g = e.Graphics;
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 16);
            Font boldFont = new Font("Arial", 16, FontStyle.Bold);

            float y = 50;
            float leftMargin = 60;
            float pageWidth = e.PageBounds.Width;

            // Header
            g.DrawString("ESTIPONA DENTAL CLINIC", headerFont, Brushes.Black, pageWidth / 2, y, new StringFormat { Alignment = StringAlignment.Center });
            y += 35;
            g.DrawString("General Dentistry, Orthodontics, and Oral Surgery", bodyFont, Brushes.Black, pageWidth / 2, y, new StringFormat { Alignment = StringAlignment.Center });
            y += 30;
            g.DrawString("Door #4 & 5 DELGAR Bldg, J.P. Laurel Avenue Bajada, Davao City", bodyFont, Brushes.Black, pageWidth / 2, y, new StringFormat { Alignment = StringAlignment.Center });
            y += 30;
            g.DrawString("Contact: 09456498475", bodyFont, Brushes.Black, pageWidth / 2, y, new StringFormat { Alignment = StringAlignment.Center });
            y += 50;

            // Title
            g.DrawString("PRESCRIPTION", new Font("Arial", 20, FontStyle.Bold | FontStyle.Underline), Brushes.Black, pageWidth / 2, y, new StringFormat { Alignment = StringAlignment.Center });
            y += 60;

            // Date
            g.DrawString($"Date: {DateTime.Now:MMMM dd, yyyy}", bodyFont, Brushes.Black, pageWidth - 320, y);
            y += 60;

            // Prescription details with Rx
            g.DrawString("℞", new Font("Arial", 56, FontStyle.Bold), Brushes.Black, leftMargin, y - 10);
            y += 120;

            if (prescriptions.Count == 0)
            {
                g.DrawString("(No medicines provided.)", bodyFont, Brushes.Black, leftMargin + 40, y);
                y += 30;
            }
            else
            {
                int index = 1;
                foreach (var item in prescriptions)
                {
                    g.DrawString($"{index}. {item.Medicine} - {item.Dosage}", bodyFont, Brushes.Black, leftMargin + 40, y);
                    y += 25;
                    index++;
                }
            }
            y += 20;

            // --- Instructions ---
            g.DrawString("Instructions:", boldFont, Brushes.Black, leftMargin, y);
            y += 25;

            string instr = string.IsNullOrWhiteSpace(instructionsText) ? "(No instructions provided.)" : instructionsText;
            RectangleF instrRect = new RectangleF(leftMargin + 20, y, pageWidth - 2 * leftMargin, e.MarginBounds.Height);
            g.DrawString(instr, bodyFont, Brushes.Black, instrRect);

            // Measure height actually used
            SizeF instrSize = g.MeasureString(instr, bodyFont, (int)(pageWidth - 2 * leftMargin));
            y += instrSize.Height + 30;

            // --- Doctor's Notes ---
            g.DrawString("Doctor's Notes:", boldFont, Brushes.Black, leftMargin, y);
            y += 25;

            string notes = string.IsNullOrWhiteSpace(doctorNotesText) ? "(No notes provided.)" : doctorNotesText;
            RectangleF notesRect = new RectangleF(leftMargin + 20, y, pageWidth - 2 * leftMargin, e.MarginBounds.Height);
            g.DrawString(notes, bodyFont, Brushes.Black, notesRect);

            SizeF notesSize = g.MeasureString(notes, bodyFont, (int)(pageWidth - 2 * leftMargin));
            y += notesSize.Height + 40;

            // Signature
            g.DrawString("_____________________________", bodyFont, Brushes.Black, pageWidth - 420, y);
            y += 40;
            g.DrawString("SALVACION E. ESTIPONA", boldFont, Brushes.Black, pageWidth - 380, y); y += 40;
            g.DrawString("Lic# 0036173", bodyFont, Brushes.Black, pageWidth - 380, y); y += 40;
            g.DrawString("PTR #3044311s", bodyFont, Brushes.Black, pageWidth - 380, y);
        }
    }
}
