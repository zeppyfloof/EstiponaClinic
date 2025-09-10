namespace EstiponaClinic
{
    partial class FormAddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            textBoxPatientsFullName = new TextBox();
            textBoxPatientsPhoneNumber = new TextBox();
            textBoxPatientsAddress = new TextBox();
            comboBoxPatientsGender = new ComboBox();
            dateTimePickerBirthDate = new DateTimePicker();
            textBoxPatientsNotes = new TextBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxPatientsFullName
            // 
            textBoxPatientsFullName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsFullName.Location = new Point(30, 50);
            textBoxPatientsFullName.Name = "textBoxPatientsFullName";
            textBoxPatientsFullName.Size = new Size(351, 32);
            textBoxPatientsFullName.TabIndex = 0;
            // 
            // textBoxPatientsPhoneNumber
            // 
            textBoxPatientsPhoneNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsPhoneNumber.Location = new Point(30, 116);
            textBoxPatientsPhoneNumber.Name = "textBoxPatientsPhoneNumber";
            textBoxPatientsPhoneNumber.Size = new Size(351, 32);
            textBoxPatientsPhoneNumber.TabIndex = 1;
            // 
            // textBoxPatientsAddress
            // 
            textBoxPatientsAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsAddress.Location = new Point(30, 182);
            textBoxPatientsAddress.Name = "textBoxPatientsAddress";
            textBoxPatientsAddress.Size = new Size(351, 32);
            textBoxPatientsAddress.TabIndex = 2;
            // 
            // comboBoxPatientsGender
            // 
            comboBoxPatientsGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatientsGender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatientsGender.FormattingEnabled = true;
            comboBoxPatientsGender.Location = new Point(30, 315);
            comboBoxPatientsGender.Name = "comboBoxPatientsGender";
            comboBoxPatientsGender.Size = new Size(351, 33);
            comboBoxPatientsGender.TabIndex = 3;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBirthDate.Location = new Point(30, 248);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(351, 32);
            dateTimePickerBirthDate.TabIndex = 4;
            // 
            // textBoxPatientsNotes
            // 
            textBoxPatientsNotes.Location = new Point(30, 382);
            textBoxPatientsNotes.Multiline = true;
            textBoxPatientsNotes.Name = "textBoxPatientsNotes";
            textBoxPatientsNotes.Size = new Size(351, 84);
            textBoxPatientsNotes.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Green;
            buttonAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(30, 487);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 44);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkRed;
            buttonCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(255, 487);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(126, 44);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 8;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(30, 88);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 9;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(30, 155);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 10;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(30, 221);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 11;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(30, 288);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 12;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(30, 354);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 13;
            label6.Text = "HMO";
            // 
            // FormAddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(411, 549);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPatientsNotes);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(comboBoxPatientsGender);
            Controls.Add(textBoxPatientsAddress);
            Controls.Add(textBoxPatientsPhoneNumber);
            Controls.Add(textBoxPatientsFullName);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddPatient";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPatientsFullName;
        private TextBox textBoxPatientsPhoneNumber;
        private TextBox textBoxPatientsAddress;
        private ComboBox comboBoxPatientsGender;
        private DateTimePicker dateTimePickerBirthDate;
        private TextBox textBoxPatientsNotes;
        private Button buttonAdd;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
