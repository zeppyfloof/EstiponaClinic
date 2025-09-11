using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormBilling : Form
    {
        private List<FormPatients.Patient> patients = new();
        private readonly string patientFile;

        public FormBilling()
        {
            InitializeComponent();

            patientFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "patients.json"
            );

            LoadPatients();
            PopulatePatientCombo();
        }

        // ------------------ LOAD PATIENTS ------------------
        private void LoadPatients()
        {
            if (File.Exists(patientFile))
            {
                try
                {
                    string json = File.ReadAllText(patientFile);
                    patients = JsonConvert.DeserializeObject<List<FormPatients.Patient>>(json) ?? new List<FormPatients.Patient>();
                }
                catch
                {
                    patients = new();
                }
            }
        }

        // ------------------ POPULATE COMBOBOX ------------------
        private void PopulatePatientCombo()
        {
            comboBoxPatient.DataSource = null;
            comboBoxPatient.DataSource = patients;
            comboBoxPatient.DisplayMember = "Name";
            comboBoxPatient.ValueMember = "PatientID";

            comboBoxPatient.SelectedIndexChanged += ComboBoxPatient_SelectedIndexChanged;
        }

        // ------------------ ON PATIENT SELECT ------------------
        private void ComboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem is FormPatients.Patient selected)
            {
                // Show patient info
                textBoxAge.Text = CalculateAge(selected.BirthDate).ToString();
                textBoxAddress.Text = selected.Address;

                // Populate treatments grid (for now placeholder until we define real treatments)
                PopulateTreatments(selected);
            }
        }

        // ------------------ POPULATE TREATMENTS ------------------
        private void PopulateTreatments(FormPatients.Patient patient)
        {
            // ❗ For now, mock treatments (you can extend later to load from a JSON like treatments.json)
            var treatments = new List<dynamic>
            {
                new { TreatmentName = "Oral Prophylaxis", Date = DateTime.Today, Cost = 800 },
                new { TreatmentName = "Tooth Extraction", Date = DateTime.Today.AddDays(-3), Cost = 1500 }
            };

            dataGridViewTreatments.DataSource = null;
            dataGridViewTreatments.DataSource = treatments;
        }

        // ------------------ HELPERS ------------------
        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (DateTime.Today < birthDate.AddYears(age)) age--;
            return age;
        }
    }
}
