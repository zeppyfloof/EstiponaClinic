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
            buttonFormDashboard = new Button();
            buttonFormPrescription = new Button();
            buttonFormPatients = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(195, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 986);
            panel1.TabIndex = 0;
            // 
            // buttonFormAppointment
            // 
            buttonFormAppointment.BackColor = Color.Green;
            buttonFormAppointment.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormAppointment.ForeColor = SystemColors.ButtonHighlight;
            buttonFormAppointment.Location = new Point(12, 423);
            buttonFormAppointment.Margin = new Padding(3, 4, 3, 4);
            buttonFormAppointment.Name = "buttonFormAppointment";
            buttonFormAppointment.Size = new Size(162, 71);
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
            buttonFormTreatment.Location = new Point(12, 623);
            buttonFormTreatment.Margin = new Padding(3, 4, 3, 4);
            buttonFormTreatment.Name = "buttonFormTreatment";
            buttonFormTreatment.Size = new Size(162, 71);
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
            buttonFormDashboard.Location = new Point(12, 727);
            buttonFormDashboard.Margin = new Padding(3, 4, 3, 4);
            buttonFormDashboard.Name = "buttonFormDashboard";
            buttonFormDashboard.Size = new Size(162, 71);
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
            buttonFormPrescription.Location = new Point(12, 521);
            buttonFormPrescription.Margin = new Padding(3, 4, 3, 4);
            buttonFormPrescription.Name = "buttonFormPrescription";
            buttonFormPrescription.Size = new Size(162, 71);
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
            buttonFormPatients.Location = new Point(12, 323);
            buttonFormPatients.Margin = new Padding(3, 4, 3, 4);
            buttonFormPatients.Name = "buttonFormPatients";
            buttonFormPatients.Size = new Size(162, 71);
            buttonFormPatients.TabIndex = 5;
            buttonFormPatients.Text = "Patients";
            buttonFormPatients.UseVisualStyleBackColor = false;
            buttonFormPatients.Click += buttonFormPatients_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightCyan;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 232);
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
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1135, 1015);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonFormTreatment);
            Controls.Add(buttonFormPatients);
            Controls.Add(buttonFormDashboard);
            Controls.Add(buttonFormPrescription);
            Controls.Add(buttonFormAppointment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Button buttonFormDashboard;
        private Button buttonFormPrescription;
        private Button buttonFormPatients;
        private PictureBox pictureBox1;
        private Label label1;
    }
}