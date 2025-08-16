namespace EstiponaClinic
{
    partial class FormPatientManage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// Clean up resources
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblName = new Label();
            textBoxName = new TextBox();
            lblNumber = new Label();
            textBoxNumber = new TextBox();
            lblAddress = new Label();
            textBoxAddress = new TextBox();
            lblDOB = new Label();
            dateTimePickerDOB = new DateTimePicker();
            lblGender = new Label();
            comboBoxGender = new ComboBox();
            lblAllergies = new Label();
            textBoxAllergies = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Green;
            lblName.Location = new Point(66, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Full Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(241, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(297, 34);
            textBoxName.TabIndex = 1;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber.ForeColor = Color.Green;
            lblNumber.Location = new Point(66, 120);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(157, 32);
            lblNumber.TabIndex = 2;
            lblNumber.Text = "Contact No.:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumber.Location = new Point(241, 120);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(297, 34);
            textBoxNumber.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.Green;
            lblAddress.Location = new Point(66, 175);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(113, 32);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(241, 175);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(297, 34);
            textBoxAddress.TabIndex = 5;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.ForeColor = Color.Green;
            lblDOB.Location = new Point(66, 231);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(168, 32);
            lblDOB.TabIndex = 6;
            lblDOB.Text = "Date of Birth:";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDOB.Location = new Point(241, 231);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(297, 34);
            dateTimePickerDOB.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.Green;
            lblGender.Location = new Point(66, 290);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(105, 32);
            lblGender.TabIndex = 8;
            lblGender.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGender.Location = new Point(241, 290);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(297, 36);
            comboBoxGender.TabIndex = 9;
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAllergies.ForeColor = Color.Green;
            lblAllergies.Location = new Point(66, 347);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(121, 32);
            lblAllergies.TabIndex = 10;
            lblAllergies.Text = "Allergies:";
            // 
            // textBoxAllergies
            // 
            textBoxAllergies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAllergies.Location = new Point(241, 347);
            textBoxAllergies.Name = "textBoxAllergies";
            textBoxAllergies.Size = new Size(297, 34);
            textBoxAllergies.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(391, 427);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 57);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(87, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 57);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormPatientManage
            // 
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(622, 520);
            Controls.Add(lblName);
            Controls.Add(textBoxName);
            Controls.Add(lblNumber);
            Controls.Add(textBoxNumber);
            Controls.Add(lblAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(lblDOB);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(lblGender);
            Controls.Add(comboBoxGender);
            Controls.Add(lblAllergies);
            Controls.Add(textBoxAllergies);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "FormPatientManage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Patient";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
