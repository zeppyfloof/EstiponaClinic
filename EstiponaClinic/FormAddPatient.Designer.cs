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
            textBoxPatientsFullName.Location = new Point(34, 67);
            textBoxPatientsFullName.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientsFullName.Name = "textBoxPatientsFullName";
            textBoxPatientsFullName.Size = new Size(401, 39);
            textBoxPatientsFullName.TabIndex = 0;
            // 
            // textBoxPatientsPhoneNumber
            // 
            textBoxPatientsPhoneNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsPhoneNumber.Location = new Point(34, 154);
            textBoxPatientsPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientsPhoneNumber.Name = "textBoxPatientsPhoneNumber";
            textBoxPatientsPhoneNumber.Size = new Size(401, 39);
            textBoxPatientsPhoneNumber.TabIndex = 1;
            // 
            // textBoxPatientsAddress
            // 
            textBoxPatientsAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsAddress.Location = new Point(34, 243);
            textBoxPatientsAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientsAddress.Name = "textBoxPatientsAddress";
            textBoxPatientsAddress.Size = new Size(401, 39);
            textBoxPatientsAddress.TabIndex = 2;
            // 
            // comboBoxPatientsGender
            // 
            comboBoxPatientsGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatientsGender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatientsGender.FormattingEnabled = true;
            comboBoxPatientsGender.Location = new Point(34, 420);
            comboBoxPatientsGender.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatientsGender.Name = "comboBoxPatientsGender";
            comboBoxPatientsGender.Size = new Size(401, 39);
            comboBoxPatientsGender.TabIndex = 3;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBirthDate.Location = new Point(34, 331);
            dateTimePickerBirthDate.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(401, 39);
            dateTimePickerBirthDate.TabIndex = 4;
            // 
            // textBoxPatientsNotes
            // 
            textBoxPatientsNotes.Location = new Point(34, 509);
            textBoxPatientsNotes.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientsNotes.Multiline = true;
            textBoxPatientsNotes.Name = "textBoxPatientsNotes";
            textBoxPatientsNotes.Size = new Size(401, 110);
            textBoxPatientsNotes.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Green;
            buttonAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(34, 649);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(144, 59);
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
            buttonCancel.Location = new Point(291, 649);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(144, 59);
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
            label1.Location = new Point(34, 31);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 8;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(34, 118);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 9;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(34, 207);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 10;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(34, 295);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 11;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(34, 384);
            label5.Name = "label5";
            label5.Size = new Size(97, 32);
            label5.TabIndex = 12;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(34, 472);
            label6.Name = "label6";
            label6.Size = new Size(81, 32);
            label6.TabIndex = 13;
            label6.Text = "Notes";
            // 
            // FormAddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(470, 732);
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
            Margin = new Padding(3, 4, 3, 4);
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
