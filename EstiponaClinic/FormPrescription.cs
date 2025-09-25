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
        private string ptrNumber = "3044311s";
        private int printPrescriptionIndex = 0;


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
            comboBoxPatient.DisplayMember = "Name"; // ✅ show names
            comboBoxPatient.ValueMember = "PatientID";     // keep ID hidden internally
        }

        private void ComboBoxPatient_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem is FormPatients.Patient patient)
            {
                int age = DateTime.Now.Year - patient.BirthDate.Year;
                if (DateTime.Now.Date < patient.BirthDate.AddYears(age)) age--;

                textBoxAge.Text = age.ToString();
                textBoxAddress.Text = patient.Address ?? string.Empty;
                textBoxPhone.Text = patient.Phone ?? string.Empty;
                textBoxGender.Text = patient.Gender ?? string.Empty;
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
            //doctorNotesText = (richTextBoxNotes?.Text ?? "").Trim();
            ptrNumber = textBoxPTR.Text.Trim();

            // reset printing state before starting print
            printPrescriptionIndex = 0;

            PrintDocument pd = new PrintDocument();
            // ✅ Quarter A4 size (approx 105mm x 148mm = 413x584 in hundredths of an inch)
            pd.DefaultPageSettings.PaperSize = new PaperSize("QuarterA4", 413, 584);
            pd.DefaultPageSettings.Margins = new Margins(20, 20, 20, 20);
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
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 9);
            Font boldFont = new Font("Arial", 9, FontStyle.Bold);

            // margins / positions
            Rectangle margin = e.MarginBounds;
            float left = margin.Left;
            float right = margin.Right;
            float printableWidth = margin.Width;
            float y = margin.Top + 8f;

            var centerFmt = new StringFormat { Alignment = StringAlignment.Center };

            // Header (centered inside margins)
            float centerX = left + printableWidth / 2f;
            g.DrawString("ESTIPONA DENTAL CLINIC", headerFont, Brushes.Black, new PointF(centerX, y), centerFmt);
            y += 18f;
            g.DrawString("General Dentistry, Orthodontics, and Oral Surgery", bodyFont, Brushes.Black, new PointF(centerX, y), centerFmt);
            y += 15f;
            g.DrawString("Door #4 & 5 DELGAR Bldg, J.P. Laurel Avenue Bajada, Davao City", bodyFont, Brushes.Black, new PointF(centerX, y), centerFmt);
            y += 15f;
            g.DrawString("Contact: 09456498475", bodyFont, Brushes.Black, new PointF(centerX, y), centerFmt);
            y += 22f;

            // Date (right)
            g.DrawString($"Date: {DateTime.Now:MMMM dd, yyyy}", bodyFont, Brushes.Black, right - 140f, y);
            y += 24f;

            // --- Patient Info ---
            int age = DateTime.Now.Year - selectedPatientForPrint.BirthDate.Year;
            if (DateTime.Now.Date < selectedPatientForPrint.BirthDate.AddYears(age)) age--;

            string patientLabel = "Patient: ";
            string ageLabel = "Age: ";
            string sexLabel = "Sex: ";
            string phoneLabel = "Phone: ";
            string addrLabel = "Address: ";

            // Draw Patient Name
            float patientLabelWidth = g.MeasureString(patientLabel, boldFont).Width;
            g.DrawString(patientLabel, boldFont, Brushes.Black, left, y);

            string nameText = selectedPatientForPrint.Name ?? "";
            RectangleF nameRect = new RectangleF(left + patientLabelWidth, y, right - (left + patientLabelWidth), 1000f);
            StringFormat wrapFormat = new StringFormat(StringFormat.GenericDefault)
            {
                Trimming = StringTrimming.Word,
                FormatFlags = StringFormatFlags.LineLimit
            };
            g.DrawString(nameText, bodyFont, Brushes.Black, nameRect, wrapFormat);

            // measure & underline
            int nameMeasureWidth = Math.Max(1, (int)Math.Floor(nameRect.Width));
            SizeF nameSize = g.MeasureString(nameText, bodyFont, nameMeasureWidth, StringFormat.GenericTypographic);
            float nameUnderlineY = y + nameSize.Height;
            g.DrawLine(Pens.Black, left + patientLabelWidth, nameUnderlineY, left + patientLabelWidth + nameSize.Width, nameUnderlineY);

            y = nameUnderlineY + 6f;

            // Draw Address
            g.DrawString(addrLabel, boldFont, Brushes.Black, left, y);
            float addrFieldX = left + g.MeasureString(addrLabel, boldFont).Width;
            float addrFieldWidth = right - addrFieldX;
            RectangleF addrRect = new RectangleF(addrFieldX, y, addrFieldWidth, 1000f);
            string addressText = selectedPatientForPrint.Address ?? "";
            g.DrawString(addressText, bodyFont, Brushes.Black, addrRect, wrapFormat);

            // measure & underline
            int addrMeasureWidth = Math.Max(1, (int)Math.Floor(addrFieldWidth));
            SizeF addrSize = g.MeasureString(addressText, bodyFont, addrMeasureWidth, StringFormat.GenericTypographic);
            float addrUnderlineY = y + addrSize.Height;
            g.DrawLine(Pens.Black, addrFieldX, addrUnderlineY, addrFieldX + addrSize.Width, addrUnderlineY);

            y = addrUnderlineY + 8f;

            // --- Age (small), Phone (wider), Sex (wider) ---
            float metaY = y;

            // Allocate widths: Age = 20%, Phone = 40%, Sex = 40%
            float ageWidth = (right - left) * 0.2f;
            float phoneWidth = (right - left) * 0.4f;
            float sexWidth = (right - left) * 0.4f;

            // Age Column
            float colX = left;
            g.DrawString(ageLabel, boldFont, Brushes.Black, colX, metaY);
            float ageLabelWidth = g.MeasureString(ageLabel, boldFont).Width;
            string ageText = age.ToString();
            g.DrawString(ageText, bodyFont, Brushes.Black, colX + ageLabelWidth, metaY);

            // underline Age value
            float ageTextWidth = g.MeasureString(ageText, bodyFont).Width;
            float underlineY = metaY + bodyFont.GetHeight(g);
            g.DrawLine(Pens.Black,
                colX + ageLabelWidth, underlineY,
                colX + ageLabelWidth + ageTextWidth, underlineY);

            // Phone Column
            colX = left + ageWidth; // start right after Age
            g.DrawString(phoneLabel, boldFont, Brushes.Black, colX, metaY);
            float phoneLabelWidth = g.MeasureString(phoneLabel, boldFont).Width;
            string phoneText = selectedPatientForPrint.Phone ?? "";
            g.DrawString(phoneText, bodyFont, Brushes.Black, colX + phoneLabelWidth, metaY);

            // underline Phone value
            float phoneTextWidth = g.MeasureString(phoneText, bodyFont).Width;
            g.DrawLine(Pens.Black,
                colX + phoneLabelWidth, underlineY,
                colX + phoneLabelWidth + phoneTextWidth, underlineY);

            // Sex Column
            colX = left + ageWidth + phoneWidth; // start right after Phone
            g.DrawString(sexLabel, boldFont, Brushes.Black, colX, metaY);
            float sexLabelWidth = g.MeasureString(sexLabel, boldFont).Width;
            string sexText = selectedPatientForPrint.Gender ?? "";
            g.DrawString(sexText, bodyFont, Brushes.Black, colX + sexLabelWidth, metaY);

            // underline Sex value
            float sexTextWidth = g.MeasureString(sexText, bodyFont).Width;
            g.DrawLine(Pens.Black,
                colX + sexLabelWidth, underlineY,
                colX + sexLabelWidth + sexTextWidth, underlineY);

            y += bodyFont.GetHeight(g) + 12f;


            // Reserve footer area for the signature block (so signature stays visible)
            float signatureBlockHeight = 80f; // enough to hold line + 3 text lines
            float footerTop = margin.Bottom - signatureBlockHeight - 10f;

            // Prescription details with Rx (paginated)
            g.DrawString("℞", new Font("Arial", 28, FontStyle.Bold), Brushes.Black, left, y - 8f);
            y += 36f;

            int index = printPrescriptionIndex;
            float medLeft = left + 30f;
            float medWidth = right - medLeft;
            int medMeasureWidth = Math.Max(1, (int)Math.Floor(medWidth));

            if (prescriptions.Count == 0)
            {
                // Fit this text into the area above footer
                if (y + 20f <= footerTop)
                {
                    g.DrawString("(No medicines provided.)", bodyFont, Brushes.Black, medLeft, y);
                    y += 20f;
                }
                // else nothing (no space), signature will still be printed
            }
            else
            {
                while (index < prescriptions.Count)
                {
                    string medLine = $"{index + 1}. {prescriptions[index].Medicine} - {prescriptions[index].Dosage}";
                    RectangleF medRect = new RectangleF(medLeft, y, medWidth, 1000f);
                    SizeF medSize = g.MeasureString(medLine, bodyFont, medMeasureWidth, StringFormat.GenericTypographic);

                    // If next medicine won't fit before footer, break to new page
                    if (y + medSize.Height > footerTop)
                    {
                        break;
                    }

                    g.DrawString(medLine, bodyFont, Brushes.Black, medRect, wrapFormat);
                    y += medSize.Height;
                    index++;
                }
            }

            // save progress
            printPrescriptionIndex = index;

            y += 20f;

            // If not finished printing prescriptions, request another page (signature will only be printed on the final page)
            if (printPrescriptionIndex < prescriptions.Count)
            {
                e.HasMorePages = true;
                return;
            }

            // --- Instructions (printed in remaining area above footer; truncated if exceeds area) ---
            string instr = string.IsNullOrWhiteSpace(instructionsText) ? "(No instructions provided.)" : instructionsText;
            float availableForInstructions = Math.Max(0f, footerTop - y - 6f);
            if (availableForInstructions > 6f)
            {
                RectangleF instrRect = new RectangleF(left + 15f, y, printableWidth - 30f, availableForInstructions);
                g.DrawString(instr, bodyFont, Brushes.Black, instrRect, wrapFormat);
                // not tracking multi-page instructions; truncated if too long (keeps signature visible)
            }
            // else: not enough space for instructions, we skip them to keep signature visible

            // --- Signature block (anchored bottom-right; always visible) ---
            float sigX = right - 220f; // adjust block width as needed
            float sigY = margin.Bottom - 80f; // baseline for the signature line (above the page bottom margin)

            g.DrawString("____________________________", bodyFont, Brushes.Black, sigX, sigY);
            sigY += 20f;
            g.DrawString("SALVACION E. ESTIPONA, D.M.D", boldFont, Brushes.Black, sigX, sigY);
            sigY += 18f;
            g.DrawString("Lic# 0036173", bodyFont, Brushes.Black, sigX, sigY);
            sigY += 18f;
            g.DrawString($"PTR #{ptrNumber}", bodyFont, Brushes.Black, sigX, sigY);

            // finished
            e.HasMorePages = false;
        }

    }
}
