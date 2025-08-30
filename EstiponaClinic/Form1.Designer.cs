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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.PowderBlue;
            panel1.Location = new Point(190, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 983);
            panel1.TabIndex = 0;
            // 
            // buttonFormAppointment
            // 
            buttonFormAppointment.BackColor = Color.Green;
            buttonFormAppointment.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormAppointment.ForeColor = SystemColors.ButtonHighlight;
            buttonFormAppointment.Location = new Point(14, 398);
            buttonFormAppointment.Margin = new Padding(3, 4, 3, 4);
            buttonFormAppointment.Name = "buttonFormAppointment";
            buttonFormAppointment.Size = new Size(170, 71);
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
            buttonFormTreatment.Location = new Point(14, 623);
            buttonFormTreatment.Margin = new Padding(3, 4, 3, 4);
            buttonFormTreatment.Name = "buttonFormTreatment";
            buttonFormTreatment.Size = new Size(170, 71);
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
            buttonFormDentalRecord.Location = new Point(12, 732);
            buttonFormDentalRecord.Margin = new Padding(3, 4, 3, 4);
            buttonFormDentalRecord.Name = "buttonFormDentalRecord";
            buttonFormDentalRecord.Size = new Size(170, 71);
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
            buttonFormMedicalHistory.Location = new Point(14, 513);
            buttonFormMedicalHistory.Margin = new Padding(3, 4, 3, 4);
            buttonFormMedicalHistory.Name = "buttonFormMedicalHistory";
            buttonFormMedicalHistory.Size = new Size(170, 71);
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
            buttonFormPatients.Location = new Point(14, 287);
            buttonFormPatients.Margin = new Padding(3, 4, 3, 4);
            buttonFormPatients.Name = "buttonFormPatients";
            buttonFormPatients.Size = new Size(170, 71);
            buttonFormPatients.TabIndex = 1;
            buttonFormPatients.Text = "Patients";
            buttonFormPatients.UseVisualStyleBackColor = false;
            buttonFormPatients.Click += buttonFormPatients_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(14, 200);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 0;
            label1.Text = "ESTIPONA CLINIC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1135, 1015);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonFormTreatment);
            Controls.Add(buttonFormPatients);
            Controls.Add(buttonFormDentalRecord);
            Controls.Add(buttonFormMedicalHistory);
            Controls.Add(buttonFormAppointment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1151, 1018);
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
    }
}