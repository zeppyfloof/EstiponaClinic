using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
//using Spire.Doc;
//using Spire.Doc.Documents;
//using Spire.Doc.Fields;

namespace EstiponaClinic
{
    public partial class FormCertificate : Form
    {
        private FormPatients.Patient? selectedPatientForPrint;
        private string diagnosisText = "";
        private string recommendationsText = "";

        private List<FormPatients.Patient> patients = new();
        private readonly string patientsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "patients.json"
        );

        public FormCertificate()
        {
            InitializeComponent();

            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxAge.ReadOnly = true;
            textBoxAddress.ReadOnly = true;

            textBoxPurpose.Text = "employment purposes, except for medico-legal reasons.";
            textBoxPTR.Text = "3044311s";

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

                // Load vitals if available
                textBoxBP.Text = string.IsNullOrWhiteSpace(patient.BloodPressure) ? "N/A" : patient.BloodPressure;
                textBoxHR.Text = string.IsNullOrWhiteSpace(patient.HeartRate) ? "N/A" : patient.HeartRate;
                textBoxTemp.Text = string.IsNullOrWhiteSpace(patient.Temperature) ? "N/A" : patient.Temperature + " °C";
                textBoxWeight.Text = string.IsNullOrWhiteSpace(patient.Weight) ? "N/A" : patient.Weight + " kg";
                textBoxHeight.Text = string.IsNullOrWhiteSpace(patient.Height) ? "N/A" : patient.Height + " cm";
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
            diagnosisText = (richTextBoxDiagnosis?.Text ?? "").Trim();
            recommendationsText = (richTextBoxRecommendations?.Text ?? "").Trim();

            PrintDocument pd = new PrintDocument();

            // A4 size (certificate style)
            pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // 100ths of an inch (8.27x11.69 in)

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
            Font bodyFont = new Font("Arial", 13);
            Font boldFont = new Font("Arial", 13, FontStyle.Bold);

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
            g.DrawString("DENTAL CERTIFICATE", new Font("Arial", 16, FontStyle.Bold | FontStyle.Underline), Brushes.Black, pageWidth / 2, y, new StringFormat { Alignment = StringAlignment.Center });
            y += 60;

            // Date
            g.DrawString($"Date: {DateTime.Now:MMMM dd, yyyy}", bodyFont, Brushes.Black, pageWidth - 250, y);
            y += 50;

            // Patient details
            int age = int.Parse(textBoxAge.Text);
            string address = selectedPatientForPrint.Address ?? "";

            string bodyText = $"This is to certify that Mr./Ms. {selectedPatientForPrint.Name}, {age} years old, residing at {address}, Davao City, " +
                              $"has been thoroughly examined in this Clinic last {DateTime.Now:MMMM dd, yyyy}.";

            g.DrawString(bodyText, bodyFont, Brushes.Black, new RectangleF(leftMargin, y, pageWidth - 2 * leftMargin, 100));
            y += 110;

            // Vitals Section
            g.DrawString("Vital Signs:", boldFont, Brushes.Black, leftMargin, y);
            y += 25;

            string vitals = $"Blood Pressure: {textBoxBP.Text}, Heart Rate: {textBoxHR.Text}, Temperature: {textBoxTemp.Text}, " +
                            $"Weight: {textBoxWeight.Text}, Height: {textBoxHeight.Text}";

            g.DrawString(vitals, bodyFont, Brushes.Black,
                new RectangleF(leftMargin, y, pageWidth - 2 * leftMargin, 60));
            y += 70;

            // Diagnosis
            g.DrawString("Diagnosis:", boldFont, Brushes.Black, leftMargin, y); y += 20;
            g.DrawString(string.IsNullOrWhiteSpace(diagnosisText) ? "(No diagnosis provided.)" : diagnosisText, bodyFont, Brushes.Black, new RectangleF(leftMargin, y, pageWidth - 2 * leftMargin, 80));
            y += 90;

            // Recommendations
            g.DrawString("Recommendations:", boldFont, Brushes.Black, leftMargin, y); y += 20;
            g.DrawString(string.IsNullOrWhiteSpace(recommendationsText) ? "(No recommendations provided.)" : recommendationsText, bodyFont, Brushes.Black, new RectangleF(leftMargin, y, pageWidth - 2 * leftMargin, 80));
            y += 110;

            //purpose
            string purposeText = string.IsNullOrWhiteSpace(textBoxPurpose.Text)
            ? "employment purposes, except for medico-legal reasons."
            : textBoxPurpose.Text;

            //closing
            string closing = $"This certificate is issued upon the request of the above-named patient for {purposeText}";
            g.DrawString(closing, bodyFont, Brushes.Black, new RectangleF(leftMargin, y, pageWidth - 2 * leftMargin, 80));
            y += 150;

            // Signature & License
            g.DrawString("_____________________________", bodyFont, Brushes.Black, pageWidth - 340, y);
            y += 40;
            g.DrawString("SALVACION E. ESTIPONA", boldFont, Brushes.Black, pageWidth - 340, y); y += 40;
            g.DrawString("Lic# 0036173", bodyFont, Brushes.Black, pageWidth - 340, y); y += 40;

            //PTR dynamic
            string ptrNumber = string.IsNullOrWhiteSpace(textBoxPTR.Text) ? "3044311s" : textBoxPTR.Text.Trim();
            g.DrawString($"PTR #{ptrNumber}", bodyFont, Brushes.Black, pageWidth - 340, y);
        }

    }
}