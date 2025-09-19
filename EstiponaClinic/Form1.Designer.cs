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
            buttonBilling = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.PowderBlue;
            panel1.Location = new Point(190, 36);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 1003);
            panel1.TabIndex = 0;
            // 
            // buttonFormAppointment
            // 
            buttonFormAppointment.BackColor = Color.Green;
            buttonFormAppointment.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormAppointment.ForeColor = SystemColors.ButtonHighlight;
            buttonFormAppointment.Location = new Point(11, 342);
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
            buttonFormTreatment.Location = new Point(11, 627);
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
            buttonFormDentalRecord.Location = new Point(11, 532);
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
            buttonFormMedicalHistory.Location = new Point(11, 437);
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
            buttonFormPatients.Location = new Point(11, 247);
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
            pictureBox1.Location = new Point(11, 36);
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
            // buttonFormCertificate
            // 
            buttonFormCertificate.BackColor = Color.Green;
            buttonFormCertificate.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFormCertificate.ForeColor = SystemColors.ButtonHighlight;
            buttonFormCertificate.Location = new Point(11, 912);
            buttonFormCertificate.Margin = new Padding(3, 4, 3, 4);
            buttonFormCertificate.Name = "buttonFormCertificate";
            buttonFormCertificate.Size = new Size(170, 71);
            buttonFormCertificate.TabIndex = 7;
            buttonFormCertificate.Text = "Certificate";
            buttonFormCertificate.UseVisualStyleBackColor = false;
            buttonFormCertificate.Click += buttonFormCertificate_Click;
            // 
            // buttonBilling
            // 
            buttonBilling.BackColor = Color.Green;
            buttonBilling.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBilling.ForeColor = SystemColors.ButtonHighlight;
            buttonBilling.Location = new Point(11, 817);
            buttonBilling.Margin = new Padding(3, 4, 3, 4);
            buttonBilling.Name = "buttonBilling";
            buttonBilling.Size = new Size(170, 71);
            buttonBilling.TabIndex = 8;
            buttonBilling.Text = "Billing";
            buttonBilling.UseVisualStyleBackColor = false;
            buttonBilling.Click += buttonBilling_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(11, 721);
            button1.Name = "button1";
            button1.Size = new Size(170, 71);
            button1.TabIndex = 8;
            button1.Text = "Prescription";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1151, 38);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eXITToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(60, 34);
            fileToolStripMenuItem.Text = "File";
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(224, 34);
            eXITToolStripMenuItem.Text = "Exit Form";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1151, 1055);
            Controls.Add(buttonFormCertificate);
            Controls.Add(buttonFormTreatment);
            Controls.Add(button1);
            Controls.Add(buttonBilling);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonFormPatients);
            Controls.Add(buttonFormDentalRecord);
            Controls.Add(buttonFormMedicalHistory);
            Controls.Add(buttonFormAppointment);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1151, 1015);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estipona Clinic";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Button buttonBilling;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
    }
}