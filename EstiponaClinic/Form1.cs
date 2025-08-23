namespace EstiponaClinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFormPatients();
        }

        private void InitializeFormPatients()
        {
            FormPatients formPatients = new FormPatients();
            formPatients.TopLevel = false;
            formPatients.FormBorderStyle = FormBorderStyle.None;
            formPatients.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formPatients);
            formPatients.Show();
        }

        private void buttonFormPatients_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients();
            formPatients.TopLevel = false;
            formPatients.FormBorderStyle = FormBorderStyle.None;
            formPatients.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formPatients);
            formPatients.Show();
        }

        private void buttonFormAppointment_Click(object sender, EventArgs e)
        {
            FormAppointment formAppointment = new FormAppointment();
            formAppointment.TopLevel = false;
            formAppointment.FormBorderStyle = FormBorderStyle.None;
            formAppointment.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formAppointment);
            formAppointment.Show();
        }

        private void buttonFormTreatment_Click(object sender, EventArgs e)
        {
            FormTreatment formTreatment = new FormTreatment();
            formTreatment.TopLevel = false;
            formTreatment.FormBorderStyle = FormBorderStyle.None;
            formTreatment.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formTreatment);
            formTreatment.Show();
        }

        private void buttonFormMedicalHistory_Click(object sender, EventArgs e)
        {
            FormMedicalHistory formMedicalHistory = new FormMedicalHistory();
            formMedicalHistory.TopLevel = false;
            formMedicalHistory.FormBorderStyle = FormBorderStyle.None;
            formMedicalHistory.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formMedicalHistory);
            formMedicalHistory.Show();
        }

        private void buttonFormDentalRecord_Click(object sender, EventArgs e)
        {
            FormDentalRecord formDashboard = new FormDentalRecord();
            formDashboard.TopLevel = false;
            formDashboard.FormBorderStyle = FormBorderStyle.None;
            formDashboard.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formDashboard);
            formDashboard.Show();
        }
    }
}