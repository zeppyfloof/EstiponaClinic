using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace EstiponaClinic
{
    public partial class FormCertificate : Form
    {
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

            LoadPatients();

            comboBoxPatient.SelectedIndexChanged += ComboBoxPatient_SelectedIndexChanged;
            buttonGenerate.Click += ButtonGenerate_Click;
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

            string diagnosis = (richTextBoxDiagnosis?.Text ?? "").Trim();
            string recommendations = (richTextBoxRecommendations?.Text ?? "").Trim();

            Document doc = new Document();
            Section section = doc.AddSection();

            // Helper function: consistent Arial style
            void ApplyArial(Paragraph para, float size = 12f, bool bold = false, bool italic = false)
            {
                foreach (DocumentObject obj in para.ChildObjects)
                {
                    if (obj is TextRange txt)
                    {
                        txt.CharacterFormat.FontName = "Arial";
                        txt.CharacterFormat.FontSize = size;
                        txt.CharacterFormat.Bold = bold;
                        txt.CharacterFormat.Italic = italic;
                    }
                }
            }

            // Header
            Paragraph header = section.AddParagraph();
            header.AppendText("ESTIPONA DENTAL CLINIC\n");
            header.AppendText("GENERAL DENTISTRY AND ORTHODONTICS and ORAL SURGERY\n");
            header.AppendText("Door #4 & 5 DELGAR Bldg, J.P. Laurel Avenue Bajada, Davao City\n");
            header.AppendText("Contact # 09456498475\n");
            header.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            ApplyArial(header, 12f, false);

            section.AddParagraph();

            // Title
            Paragraph title = section.AddParagraph();
            title.AppendText("DENTAL CERTIFICATE");
            title.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            ApplyArial(title, 16f, true);

            section.AddParagraph();

            // Date
            Paragraph datePara = section.AddParagraph();
            datePara.AppendText($"Date: {DateTime.Now:MMMM dd, yyyy}");
            datePara.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
            ApplyArial(datePara, 12f);

            section.AddParagraph();
            section.AddParagraph();

            // Body
            int age = int.Parse(textBoxAge.Text);
            string address = patient.Address ?? "";

            Paragraph body = section.AddParagraph();
            body.AppendText($"        This is to certify that Mr./Ms. {patient.Name}, {age} years old, residing at {address}, Davao City has been thoroughly examined in this Clinic last {DateTime.Now:MMMM dd, yyyy}.");
            body.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
            ApplyArial(body, 12f);

            section.AddParagraph();

            // Diagnosis heading
            Paragraph diagHeading = section.AddParagraph();
            diagHeading.AppendText("Diagnosis:");
            ApplyArial(diagHeading, 12f, bold: true, italic: false);

            Paragraph diagPara = section.AddParagraph();
            diagPara.AppendText(string.IsNullOrWhiteSpace(diagnosis) ? "(No diagnosis provided.)" : diagnosis);
            ApplyArial(diagPara, 12f);

            section.AddParagraph();

            // Recommendations heading
            Paragraph recHeading = section.AddParagraph();
            recHeading.AppendText("Recommendations:");
            ApplyArial(recHeading, 12f, bold: true, italic: false);

            Paragraph recPara = section.AddParagraph();
            recPara.AppendText(string.IsNullOrWhiteSpace(recommendations) ? "(No recommendations provided.)" : recommendations);
            ApplyArial(recPara, 12f);

            section.AddParagraph();

            // Closing
            Paragraph closing = section.AddParagraph();
            closing.AppendText("This certificate is issued upon the request of above patient for employment purposes, except for medico-legal reasons.");
            closing.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
            ApplyArial(closing, 12f);

            section.AddParagraph();
            section.AddParagraph();
            section.AddParagraph();

            // Footer
            Paragraph footer = section.AddParagraph();
            footer.AppendText("SALVACION E. ESTIPONA\nLic# 0036173\nPTR #3044311s");
            footer.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
            ApplyArial(footer, 12f, bold: true);

            // Save dialog
            string safeName = string.Concat(patient.Name.Where(ch => !Path.GetInvalidFileNameChars().Contains(ch)));
            if (string.IsNullOrWhiteSpace(safeName)) safeName = "Patient";

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Word Document (*.docx)|*.docx",
                FileName = $"DentalCertificate_{safeName}_{DateTime.Now:yyyyMMdd}.docx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    doc.SaveToFile(sfd.FileName, FileFormat.Docx);
                    MessageBox.Show("Certificate generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
