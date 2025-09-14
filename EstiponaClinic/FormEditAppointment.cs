using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormEditAppointment : Form
    {
        public FormAppointment.Appointment? EditedAppointment { get; private set; }
        private readonly int _appointmentID;
        private List<FormTreatment.Treatment> treatments = new();
        private readonly string treatmentsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "EstiponaClinic",
            "treatments.json"
        );
        public FormEditAppointment(FormAppointment.Appointment appointment)
        {
            InitializeComponent();
            LoadTreatments();

            _appointmentID = appointment.AppointmentID;

            textBoxPatient.Text = appointment.PatientName;
            comboBoxTreatment.SelectedItem = treatments
                .FirstOrDefault(t => t.TreatmentName == appointment.TreatmentName);

            textBoxCost.Text = appointment.TreatmentCost.ToString("F2");
            dateTimePickerDate.Value = appointment.AppointmentDate;
            dateTimePickerTime.Value = appointment.AppointmentTime;
            comboBoxTreatment.SelectedIndexChanged += comboBoxTreatment_SelectedIndexChanged;

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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPatient.Text) ||
                string.IsNullOrWhiteSpace(comboBoxTreatment.Text) ||
                !decimal.TryParse(textBoxCost.Text, out decimal cost))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditedAppointment = new FormAppointment.Appointment
            {
                AppointmentID = _appointmentID,
                PatientName = textBoxPatient.Text.Trim(),
                TreatmentName = ((FormTreatment.Treatment)comboBoxTreatment.SelectedItem).TreatmentName,
                TreatmentCost = decimal.Parse(textBoxCost.Text),
                AppointmentDate = dateTimePickerDate.Value.Date,
                AppointmentTime = dateTimePickerTime.Value
            };


            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBoxTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTreatment.SelectedItem is FormTreatment.Treatment treatment)
            {
                textBoxCost.Text = treatment.TreatmentCost.ToString("F2");
                labelCategory.Text = $"Category: {treatment.Category}";
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
