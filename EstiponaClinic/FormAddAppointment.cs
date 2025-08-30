using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormAddAppointment : Form
    {
        public FormAppointment.Appointment? NewAppointment { get; private set; }

        private List<FormPatients.Patient> patients = new();
        private List<FormTreatment.Treatment> treatments = new();
        private readonly string patientsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "patients.json"
        );
        private readonly string treatmentsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "treatments.json"
        );
        private readonly string appointmentsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "appointments.json"
        );

        private List<FormAppointment.Appointment> existingAppointments = new();

        public FormAddAppointment()
        {
            InitializeComponent();
            LoadPatients();
            LoadTreatments();
            LoadExistingAppointments();

            comboBoxTreatment.SelectedIndexChanged += ComboBoxTreatment_SelectedIndexChanged;
        }

        private void LoadPatients()
        {
            if (File.Exists(patientsFile))
            {
                string json = File.ReadAllText(patientsFile);
                patients = (JsonConvert.DeserializeObject<List<FormPatients.Patient>>(json) ?? new())
                 .Where(p => p != null)
                 .ToList();

                comboBoxPatient.DataSource = null;
                comboBoxPatient.DataSource = patients;
                comboBoxPatient.DisplayMember = "Name";
                comboBoxPatient.ValueMember = "PatientID";
            }
        }

        private void LoadTreatments()
        {
            if (File.Exists(treatmentsFile))
            {
                string json = File.ReadAllText(treatmentsFile);
                treatments = JsonConvert.DeserializeObject<List<FormTreatment.Treatment>>(json) ?? new();

                comboBoxTreatment.DataSource = null;
                comboBoxTreatment.DataSource = treatments;
                comboBoxTreatment.DisplayMember = "TreatmentName";
            }
        }

        private void LoadExistingAppointments()
        {
            if (File.Exists(appointmentsFile))
            {
                string json = File.ReadAllText(appointmentsFile);
                existingAppointments = JsonConvert.DeserializeObject<List<FormAppointment.Appointment>>(json) ?? new();
            }
        }

        private void ComboBoxTreatment_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxTreatment.SelectedItem is FormTreatment.Treatment treatment)
            {
                textBoxCost.Text = treatment.TreatmentCost.ToString("F2");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem == null ||
                comboBoxTreatment.SelectedItem == null ||
                !decimal.TryParse(textBoxCost.Text, out decimal cost))
            {
                MessageBox.Show("Please select patient, treatment, and ensure cost is valid.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPatient = (FormPatients.Patient)comboBoxPatient.SelectedItem;
            var selectedTreatment = (FormTreatment.Treatment)comboBoxTreatment.SelectedItem;

            int nextID = existingAppointments.Count > 0
                ? existingAppointments.Max(a => a.AppointmentID) + 1
                : 1;

            NewAppointment = new FormAppointment.Appointment
            {
                AppointmentID = nextID,
                PatientName = selectedPatient.Name,
                TreatmentName = selectedTreatment.TreatmentName,
                TreatmentCost = cost,
                AppointmentDate = dateTimePickerDate.Value.Date,
                AppointmentTime = dateTimePickerTime.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
