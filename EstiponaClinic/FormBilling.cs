using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormBilling : Form
    {
        private List<FormPatients.Patient> patients = new();
        private List<Billing> billings = new();
        private readonly string patientFile;
        private readonly string billingFile;

        public FormBilling()
        {
            InitializeComponent();

            patientFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "patients.json"
            );

            billingFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "billings.json"
            );

            Directory.CreateDirectory(Path.GetDirectoryName(patientFile)!);

            LoadPatients();
            LoadBillings();
            PopulatePatientCombo();
        }

        // ------------------ MODELS ------------------
        public class Treatment
        {
            public string TreatmentName { get; set; } = string.Empty;
            public decimal Cost { get; set; }
        }

        public class Billing
        {
            public int BillingID { get; set; }
            public int PatientID { get; set; }
            public string PatientName { get; set; } = string.Empty;
            public DateTime Date { get; set; }
            public List<Treatment> Treatments { get; set; } = new();
            public decimal Total { get; set; }
        }

        // ------------------ LOAD/SAVE ------------------
        private void LoadPatients()
        {
            if (File.Exists(patientFile))
            {
                string json = File.ReadAllText(patientFile);
                patients = JsonConvert.DeserializeObject<List<FormPatients.Patient>>(json) ?? new();
            }
        }

        private void LoadBillings()
        {
            if (File.Exists(billingFile))
            {
                string json = File.ReadAllText(billingFile);
                billings = JsonConvert.DeserializeObject<List<Billing>>(json) ?? new();
            }
        }

        private void SaveBillings()
        {
            File.WriteAllText(billingFile, JsonConvert.SerializeObject(billings, Formatting.Indented));
        }

        // ------------------ POPULATE PATIENTS ------------------
        private void PopulatePatientCombo()
        {
            comboBoxPatient.DataSource = null;
            comboBoxPatient.DataSource = patients;
            comboBoxPatient.DisplayMember = "Name";
            comboBoxPatient.ValueMember = "PatientID";

            comboBoxPatient.SelectedIndexChanged += ComboBoxPatient_SelectedIndexChanged;
        }

        private void ComboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem is FormPatients.Patient selected)
            {
                textBoxAge.Text = CalculateAge(selected.BirthDate).ToString();
                textBoxAddress.Text = selected.Address;

                // Show all billings for this patient
                var patientBills = billings.Where(b => b.PatientID == selected.PatientID).ToList();

                dataGridViewTreatments.DataSource = null;
                dataGridViewTreatments.DataSource = patientBills
                    .SelectMany(b => b.Treatments.Select(t => new
                    {
                        b.BillingID,
                        b.Date,
                        t.TreatmentName,
                        t.Cost,
                        b.Total
                    }))
                    .ToList();
            }
        }

        // ------------------ HELPERS ------------------
        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (DateTime.Today < birthDate.AddYears(age)) age--;
            return age;
        }

        private int GenerateBillingID()
        {
            return billings.Any() ? billings.Max(b => b.BillingID) + 1 : 1;
        }
    }
}
