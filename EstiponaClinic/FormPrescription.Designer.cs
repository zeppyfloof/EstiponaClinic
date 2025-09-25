namespace EstiponaClinic
{
    partial class FormPrescription
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboBoxPatient;
        private TextBox textBoxAge;
        private TextBox textBoxAddress;
        private DataGridView dgvPrescriptions;
        private RichTextBox richTextBoxInstructions;
        private Button buttonGenerate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            comboBoxPatient = new ComboBox();
            textBoxAge = new TextBox();
            textBoxAddress = new TextBox();
            dgvPrescriptions = new DataGridView();
            Medicine = new DataGridViewTextBoxColumn();
            Dosage = new DataGridViewTextBoxColumn();
            richTextBoxInstructions = new RichTextBox();
            buttonGenerate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            label4 = new Label();
            textBoxPTR = new TextBox();
            labelPTR = new Label();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            textBoxGender = new TextBox();
            labelGender = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatient.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatient.Location = new Point(165, 146);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(603, 39);
            comboBoxPatient.TabIndex = 0;
            // 
            // textBoxAge
            // 
            textBoxAge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.Location = new Point(846, 146);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.ReadOnly = true;
            textBoxAge.Size = new Size(234, 39);
            textBoxAge.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(165, 219);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(917, 60);
            textBoxAddress.TabIndex = 2;
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.BackgroundColor = Color.Azure;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrescriptions.ColumnHeadersHeight = 48;
            dgvPrescriptions.Columns.AddRange(new DataGridViewColumn[] { Medicine, Dosage });
            dgvPrescriptions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvPrescriptions.Location = new Point(42, 435);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPrescriptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPrescriptions.RowHeadersVisible = false;
            dgvPrescriptions.RowHeadersWidth = 51;
            dgvPrescriptions.Size = new Size(1038, 175);
            dgvPrescriptions.TabIndex = 3;
            // 
            // Medicine
            // 
            Medicine.HeaderText = "Medicine";
            Medicine.MinimumWidth = 6;
            Medicine.Name = "Medicine";
            // 
            // Dosage
            // 
            Dosage.HeaderText = "Dosage";
            Dosage.MinimumWidth = 6;
            Dosage.Name = "Dosage";
            // 
            // richTextBoxInstructions
            // 
            richTextBoxInstructions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxInstructions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInstructions.Location = new Point(40, 730);
            richTextBoxInstructions.Name = "richTextBoxInstructions";
            richTextBoxInstructions.Size = new Size(1040, 193);
            richTextBoxInstructions.TabIndex = 4;
            richTextBoxInstructions.Text = "";
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonGenerate.BackColor = Color.Green;
            buttonGenerate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGenerate.ForeColor = Color.White;
            buttonGenerate.Location = new Point(931, 987);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(149, 56);
            buttonGenerate.TabIndex = 6;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += ButtonGenerate_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(58, 146);
            label1.Name = "label1";
            label1.Size = new Size(105, 39);
            label1.TabIndex = 7;
            label1.Text = "Patient:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(774, 146);
            label2.Name = "label2";
            label2.Size = new Size(66, 39);
            label2.TabIndex = 8;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(44, 219);
            label3.Name = "label3";
            label3.Size = new Size(119, 36);
            label3.TabIndex = 9;
            label3.Text = "Address:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(40, 690);
            label6.Name = "label6";
            label6.Size = new Size(164, 37);
            label6.TabIndex = 10;
            label6.Text = "Instructions:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(23, 29);
            label8.Name = "label8";
            label8.Size = new Size(267, 59);
            label8.TabIndex = 12;
            label8.Text = "Prescription";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(42, 400);
            label4.Name = "label4";
            label4.Size = new Size(330, 32);
            label4.TabIndex = 13;
            label4.Text = "Input Medicine and Dosage";
            // 
            // textBoxPTR
            // 
            textBoxPTR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPTR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPTR.Location = new Point(747, 664);
            textBoxPTR.Name = "textBoxPTR";
            textBoxPTR.Size = new Size(333, 39);
            textBoxPTR.TabIndex = 14;
            textBoxPTR.Text = "3044311s";
            // 
            // labelPTR
            // 
            labelPTR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPTR.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPTR.ForeColor = Color.Green;
            labelPTR.Location = new Point(659, 667);
            labelPTR.Name = "labelPTR";
            labelPTR.Size = new Size(91, 34);
            labelPTR.TabIndex = 15;
            labelPTR.Text = "PTR #:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(165, 314);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(350, 39);
            textBoxPhone.TabIndex = 16;
            // 
            // labelPhone
            // 
            labelPhone.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.ForeColor = Color.Green;
            labelPhone.Location = new Point(62, 314);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(101, 39);
            labelPhone.TabIndex = 18;
            labelPhone.Text = "Phone:";
            // 
            // textBoxGender
            // 
            textBoxGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxGender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGender.Location = new Point(846, 314);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.ReadOnly = true;
            textBoxGender.Size = new Size(236, 39);
            textBoxGender.TabIndex = 17;
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelGender.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.ForeColor = Color.Green;
            labelGender.Location = new Point(729, 314);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(111, 39);
            labelGender.TabIndex = 19;
            labelGender.Text = "Gender:";
            // 
            // FormPrescription
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1127, 1055);
            Controls.Add(label4);
            Controls.Add(comboBoxPatient);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxAddress);
            Controls.Add(dgvPrescriptions);
            Controls.Add(richTextBoxInstructions);
            Controls.Add(buttonGenerate);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(textBoxPTR);
            Controls.Add(labelPTR);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxGender);
            Controls.Add(labelPhone);
            Controls.Add(labelGender);
            Name = "FormPrescription";
            Text = "Generate Prescription";
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn Medicine;
        private DataGridViewTextBoxColumn Dosage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label8;
        private Label label4;
        private TextBox textBoxPTR;
        private Label labelPTR;
        private TextBox textBoxPhone;
        private TextBox textBoxGender;
        private Label labelPhone;
        private Label labelGender;


    }
}
