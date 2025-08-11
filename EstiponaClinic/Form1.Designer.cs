namespace EstiponaClinic
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonFormAppointment = new Button();
            buttonFormTreatment = new Button();
            buttonFormDashboard = new Button();
            buttonFormPrescription = new Button();
            buttonFormPatients = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(159, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 726);
            panel1.TabIndex = 0;
            // 
            // buttonFormAppointment
            // 
            buttonFormAppointment.BackColor = Color.Green;
            buttonFormAppointment.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormAppointment.ForeColor = SystemColors.ButtonHighlight;
            buttonFormAppointment.Location = new Point(12, 274);
            buttonFormAppointment.Name = "buttonFormAppointment";
            buttonFormAppointment.Size = new Size(129, 53);
            buttonFormAppointment.TabIndex = 1;
            buttonFormAppointment.Text = "Appointment";
            buttonFormAppointment.UseVisualStyleBackColor = false;
            buttonFormAppointment.Click += buttonFormAppointment_Click;
            // 
            // buttonFormTreatment
            // 
            buttonFormTreatment.BackColor = Color.Green;
            buttonFormTreatment.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormTreatment.ForeColor = SystemColors.ButtonHighlight;
            buttonFormTreatment.Location = new Point(12, 392);
            buttonFormTreatment.Name = "buttonFormTreatment";
            buttonFormTreatment.Size = new Size(129, 53);
            buttonFormTreatment.TabIndex = 2;
            buttonFormTreatment.Text = "Treatment";
            buttonFormTreatment.UseVisualStyleBackColor = false;
            buttonFormTreatment.Click += buttonFormTreatment_Click;
            // 
            // buttonFormDashboard
            // 
            buttonFormDashboard.BackColor = Color.Green;
            buttonFormDashboard.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormDashboard.ForeColor = SystemColors.ButtonHighlight;
            buttonFormDashboard.Location = new Point(12, 451);
            buttonFormDashboard.Name = "buttonFormDashboard";
            buttonFormDashboard.Size = new Size(129, 53);
            buttonFormDashboard.TabIndex = 4;
            buttonFormDashboard.Text = "Dashboard";
            buttonFormDashboard.UseVisualStyleBackColor = false;
            buttonFormDashboard.Click += buttonFormDashboard_Click;
            // 
            // buttonFormPrescription
            // 
            buttonFormPrescription.BackColor = Color.Green;
            buttonFormPrescription.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormPrescription.ForeColor = SystemColors.ButtonHighlight;
            buttonFormPrescription.Location = new Point(12, 333);
            buttonFormPrescription.Name = "buttonFormPrescription";
            buttonFormPrescription.Size = new Size(129, 53);
            buttonFormPrescription.TabIndex = 3;
            buttonFormPrescription.Text = "Prescription";
            buttonFormPrescription.UseVisualStyleBackColor = false;
            buttonFormPrescription.Click += buttonFormPrescription_Click;
            // 
            // buttonFormPatients
            // 
            buttonFormPatients.BackColor = Color.Green;
            buttonFormPatients.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormPatients.ForeColor = SystemColors.ButtonHighlight;
            buttonFormPatients.Location = new Point(12, 215);
            buttonFormPatients.Name = "buttonFormPatients";
            buttonFormPatients.Size = new Size(129, 53);
            buttonFormPatients.TabIndex = 5;
            buttonFormPatients.Text = "Patients";
            buttonFormPatients.UseVisualStyleBackColor = false;
            buttonFormPatients.Click += buttonFormPatients_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(993, 761);
            Controls.Add(buttonFormTreatment);
            Controls.Add(buttonFormPatients);
            Controls.Add(buttonFormDashboard);
            Controls.Add(buttonFormPrescription);
            Controls.Add(buttonFormAppointment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estipona Clinic";
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button buttonFormAppointment;
        private Button buttonFormTreatment;
        private Button buttonFormDashboard;
        private Button buttonFormPrescription;
        private Button buttonFormPatients;
    }
}