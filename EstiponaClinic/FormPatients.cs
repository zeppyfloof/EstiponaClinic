using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormPatients : Form
    {
        private List<Patient> patients = new();
        private readonly string patientFile;
        private readonly Random rng = new();

        public FormPatients()
        {
            InitializeComponent();

            patientFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "patients.json"
            );
            Directory.CreateDirectory(Path.GetDirectoryName(patientFile)!);

            LoadPatients();
            SetupEventHandlers();
            RefreshGrid();
        }

        // ------------------ MODEL ------------------
        public class Patient
        {
            public int PatientID { get; set; }                     // int ID
            public string Name { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string Address { get; set; } = string.Empty;
            public DateTime BirthDate { get; set; }
            public string Gender { get; set; } = string.Empty;
            public string Notes { get; set; } = string.Empty;      // ✅ changed
        }

        // ------------------ HELPERS ------------------
        private int GenerateUniquePatientID()
        {
            int id;
            do { id = rng.Next(100000, 999999); }
            while (patients.Any(p => p.PatientID == id));
            return id;
        }

        private int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        // ------------------ EVENTS ------------------
        private void SetupEventHandlers()
        {
            buttonPatientsSave.Click += buttonPatientsSave_Click;
            buttonPatientsEdit.Click += buttonPatientsEdit_Click;
            buttonPatientsDelete.Click += buttonPatientsDelete_Click;
            textBoxPatientsSearch.TextChanged += textBoxPatientsSearch_TextChanged;
        }

        // ------------------ FILE I/O ------------------
        private void LoadPatients()
        {
            if (File.Exists(patientFile))
            {
                try
                {
                    var json = File.ReadAllText(patientFile);
                    var loaded = JsonConvert.DeserializeObject<List<Patient>>(json);
                    if (loaded != null) patients = loaded;
                }
                catch
                {
                    patients = new();
                }
            }
        }

        private void SavePatients()
        {
            File.WriteAllText(patientFile, JsonConvert.SerializeObject(patients, Formatting.Indented));
        }

        // ------------------ GRID ------------------
        private void RefreshGrid()
        {
            var view = patients.Select(p => new
            {
                p.PatientID,
                p.Name,
                p.Phone,
                p.Address,
                p.BirthDate,
                Age = CalculateAge(p.BirthDate),
                p.Gender,
                p.Notes               // ✅ changed
            }).ToList();

            dataGridViewPatients.DataSource = null;
            dataGridViewPatients.DataSource = view;

            // Hide PatientID column if present
            if (dataGridViewPatients.Columns["PatientID"] != null)
                dataGridViewPatients.Columns["PatientID"].Visible = false;

            // Format BirthDate
            if (dataGridViewPatients.Columns["BirthDate"] != null)
                dataGridViewPatients.Columns["BirthDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            // Rename headers
            if (dataGridViewPatients.Columns["Name"] != null)
                dataGridViewPatients.Columns["Name"].HeaderText = "Full Name";
            if (dataGridViewPatients.Columns["Phone"] != null)
                dataGridViewPatients.Columns["Phone"].HeaderText = "Contact No.";
            if (dataGridViewPatients.Columns["Address"] != null)
                dataGridViewPatients.Columns["Address"].HeaderText = "Home Address";
            if (dataGridViewPatients.Columns["BirthDate"] != null)
                dataGridViewPatients.Columns["BirthDate"].HeaderText = "Date of Birth";
        }

        // ------------------ BUTTONS ------------------
        private void buttonPatientsSave_Click(object? sender, EventArgs e)
        {
            using var form = new FormAddPatient();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var patient = new Patient
                {
                    PatientID = GenerateUniquePatientID(),
                    Name = form.PatientName,
                    Phone = form.PatientNumber,
                    Address = form.PatientAddress,
                    BirthDate = form.PatientBirthDay,
                    Gender = form.PatientGender,
                    Notes = form.PatientNotes         // ✅ changed
                };
                patients.Add(patient);
                SavePatients();
                RefreshGrid();
            }
        }

        private void buttonPatientsEdit_Click(object? sender, EventArgs e)
        {
            if (dataGridViewPatients.CurrentRow == null) return;

            var patient = patients.FirstOrDefault(p => p.PatientID ==
                (int)dataGridViewPatients.CurrentRow.Cells["PatientID"].Value);
            if (patient == null) return;

            using var form = new FormEditPatient(patient);
            if (form.ShowDialog() == DialogResult.OK)
            {
                SavePatients();
                RefreshGrid();
            }
        }

        private void buttonPatientsDelete_Click(object? sender, EventArgs e)
        {
            if (dataGridViewPatients.CurrentRow == null) return;

            var patient = patients.FirstOrDefault(p => p.PatientID ==
                (int)dataGridViewPatients.CurrentRow.Cells["PatientID"].Value);
            if (patient == null) return;

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete {patient.Name}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                patients.Remove(patient);
                SavePatients();
                RefreshGrid();
            }
        }

        // ------------------ SEARCH ------------------
        private void textBoxPatientsSearch_TextChanged(object? sender, EventArgs e)
        {
            string search = textBoxPatientsSearch.Text.Trim().ToLower();
            var filtered = patients.Where(p =>
                p.Name.ToLower().Contains(search) ||
                p.Phone.ToLower().Contains(search) ||
                p.Address.ToLower().Contains(search) ||
                p.Gender.ToLower().Contains(search)
            ).Select(p => new
            {
                p.PatientID,
                p.Name,
                p.Phone,
                p.Address,
                p.BirthDate,
                Age = CalculateAge(p.BirthDate),
                p.Gender,
                p.Notes                 // ✅ changed
            }).ToList();

            dataGridViewPatients.DataSource = null;
            dataGridViewPatients.DataSource = filtered;

            if (dataGridViewPatients.Columns["PatientID"] != null)
                dataGridViewPatients.Columns["PatientID"].Visible = false;
        }
    }
}
