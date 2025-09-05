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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonFormAppointment = new Button();
            buttonFormTreatment = new Button();
            buttonFormDentalRecord = new Button();
            buttonFormMedicalHistory = new Button();
            buttonFormPatients = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonFormCertificate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.PowderBlue;
            panel1.Location = new Point(166, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 737);
            panel1.TabIndex = 0;
            // 
            // buttonFormAppointment
            // 
            buttonFormAppointment.BackColor = Color.Green;
            buttonFormAppointment.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormAppointment.ForeColor = SystemColors.ButtonHighlight;
            buttonFormAppointment.Location = new Point(12, 298);
            buttonFormAppointment.Name = "buttonFormAppointment";
            buttonFormAppointment.Size = new Size(149, 53);
            buttonFormAppointment.TabIndex = 2;
            buttonFormAppointment.Text = "Appointment";
            buttonFormAppointment.UseVisualStyleBackColor = false;
            buttonFormAppointment.Click += buttonFormAppointment_Click;
            // 
            // buttonFormTreatment
            // 
            buttonFormTreatment.BackColor = Color.Green;
            buttonFormTreatment.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormTreatment.ForeColor = SystemColors.ButtonHighlight;
            buttonFormTreatment.Location = new Point(12, 467);
            buttonFormTreatment.Name = "buttonFormTreatment";
            buttonFormTreatment.Size = new Size(149, 53);
            buttonFormTreatment.TabIndex = 4;
            buttonFormTreatment.Text = "Treatment";
            buttonFormTreatment.UseVisualStyleBackColor = false;
            buttonFormTreatment.Click += buttonFormTreatment_Click;
            // 
            // buttonFormDentalRecord
            // 
            buttonFormDentalRecord.BackColor = Color.Green;
            buttonFormDentalRecord.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormDentalRecord.ForeColor = SystemColors.ButtonHighlight;
            buttonFormDentalRecord.Location = new Point(12, 549);
            buttonFormDentalRecord.Name = "buttonFormDentalRecord";
            buttonFormDentalRecord.Size = new Size(149, 53);
            buttonFormDentalRecord.TabIndex = 5;
            buttonFormDentalRecord.Text = "Dental Records";
            buttonFormDentalRecord.UseVisualStyleBackColor = false;
            buttonFormDentalRecord.Click += buttonFormDentalRecord_Click;
            // 
            // buttonFormMedicalHistory
            // 
            buttonFormMedicalHistory.BackColor = Color.Green;
            buttonFormMedicalHistory.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormMedicalHistory.ForeColor = SystemColors.ButtonHighlight;
            buttonFormMedicalHistory.Location = new Point(12, 385);
            buttonFormMedicalHistory.Name = "buttonFormMedicalHistory";
            buttonFormMedicalHistory.Size = new Size(149, 53);
            buttonFormMedicalHistory.TabIndex = 3;
            buttonFormMedicalHistory.Text = "Medical History";
            buttonFormMedicalHistory.UseVisualStyleBackColor = false;
            buttonFormMedicalHistory.Click += buttonFormMedicalHistory_Click;
            // 
            // buttonFormPatients
            // 
            buttonFormPatients.BackColor = Color.Green;
            buttonFormPatients.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormPatients.ForeColor = SystemColors.ButtonHighlight;
            buttonFormPatients.Location = new Point(12, 215);
            buttonFormPatients.Name = "buttonFormPatients";
            buttonFormPatients.Size = new Size(149, 53);
            buttonFormPatients.TabIndex = 1;
            buttonFormPatients.Text = "Patients";
            buttonFormPatients.UseVisualStyleBackColor = false;
            buttonFormPatients.Click += buttonFormPatients_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "ESTIPONA CLINIC";
            // 
            // buttonFormCertificate
            // 
            buttonFormCertificate.BackColor = Color.Green;
            buttonFormCertificate.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormCertificate.ForeColor = SystemColors.ButtonHighlight;
            buttonFormCertificate.Location = new Point(12, 636);
            buttonFormCertificate.Name = "buttonFormCertificate";
            buttonFormCertificate.Size = new Size(149, 53);
            buttonFormCertificate.TabIndex = 7;
            buttonFormCertificate.Text = "Certificate";
            buttonFormCertificate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(993, 761);
            Controls.Add(buttonFormCertificate);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonFormTreatment);
            Controls.Add(buttonFormPatients);
            Controls.Add(buttonFormDentalRecord);
            Controls.Add(buttonFormMedicalHistory);
            Controls.Add(buttonFormAppointment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1009, 773);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estipona Clinic";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Button buttonFormAppointment;
        private Button buttonFormTreatment;
        private Button buttonFormDentalRecord;
        private Button buttonFormMedicalHistory;
        private Button buttonFormPatients;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonFormCertificate;
    }
}