using System;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public partial class FormEditAppointment : Form
    {
        public FormAppointment.Appointment? EditedAppointment { get; private set; }
        private readonly int _appointmentID;

        public FormEditAppointment(FormAppointment.Appointment appointment)
        {
            InitializeComponent();

            _appointmentID = appointment.AppointmentID;

            textBoxPatient.Text = appointment.PatientName;
            textBoxTreatment.Text = appointment.TreatmentName;
            textBoxCost.Text = appointment.TreatmentCost.ToString("F2");
            dateTimePickerDate.Value = appointment.AppointmentDate;
            dateTimePickerTime.Value = appointment.AppointmentTime;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPatient.Text) ||
                string.IsNullOrWhiteSpace(textBoxTreatment.Text) ||
                !decimal.TryParse(textBoxCost.Text, out decimal cost))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditedAppointment = new FormAppointment.Appointment
            {
                AppointmentID = _appointmentID, // keep the same integer ID
                PatientName = textBoxPatient.Text.Trim(),
                TreatmentName = textBoxTreatment.Text.Trim(),
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
