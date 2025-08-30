namespace EstiponaClinic
{
    partial class FormEditPatient
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxPatientsFullName = new TextBox();
            label2 = new Label();
            textBoxPatientsPhoneNumber = new TextBox();
            label3 = new Label();
            textBoxPatientsAddress = new TextBox();
            label4 = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            label5 = new Label();
            comboBoxPatientsGender = new ComboBox();
            label6 = new Label();
            textBoxPatientsNotes = new TextBox();
            buttonUpdate = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(34, 31);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // textBoxPatientsFullName
            // 
            textBoxPatientsFullName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsFullName.Location = new Point(34, 67);
            textBoxPatientsFullName.Name = "textBoxPatientsFullName";
            textBoxPatientsFullName.Size = new Size(401, 39);
            textBoxPatientsFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(34, 118);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 2;
            label2.Text = "Phone Number:";
            // 
            // textBoxPatientsPhoneNumber
            // 
            textBoxPatientsPhoneNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsPhoneNumber.Location = new Point(34, 154);
            textBoxPatientsPhoneNumber.Name = "textBoxPatientsPhoneNumber";
            textBoxPatientsPhoneNumber.Size = new Size(401, 39);
            textBoxPatientsPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(34, 207);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // textBoxPatientsAddress
            // 
            textBoxPatientsAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsAddress.Location = new Point(34, 243);
            textBoxPatientsAddress.Name = "textBoxPatientsAddress";
            textBoxPatientsAddress.Size = new Size(401, 39);
            textBoxPatientsAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(34, 295);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 6;
            label4.Text = "Date of Birth:";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBirthDate.Location = new Point(34, 331);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(401, 39);
            dateTimePickerBirthDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(34, 384);
            label5.Name = "label5";
            label5.Size = new Size(97, 32);
            label5.TabIndex = 8;
            label5.Text = "Gender:";
            // 
            // comboBoxPatientsGender
            // 
            comboBoxPatientsGender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatientsGender.Location = new Point(34, 420);
            comboBoxPatientsGender.Name = "comboBoxPatientsGender";
            comboBoxPatientsGender.Size = new Size(401, 39);
            comboBoxPatientsGender.TabIndex = 9;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(34, 472);
            label6.Name = "label6";
            label6.Size = new Size(81, 32);
            label6.TabIndex = 10;
            label6.Text = "Notes:";
            // 
            // textBoxPatientsNotes
            // 
            textBoxPatientsNotes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsNotes.Location = new Point(34, 509);
            textBoxPatientsNotes.Multiline = true;
            textBoxPatientsNotes.Name = "textBoxPatientsNotes";
            textBoxPatientsNotes.Size = new Size(401, 110);
            textBoxPatientsNotes.TabIndex = 5;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Green;
            buttonUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.Control;
            buttonUpdate.Location = new Point(34, 649);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(144, 59);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkRed;
            buttonCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(291, 649);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(144, 59);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormEditPatient
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(470, 732);
            Controls.Add(label1);
            Controls.Add(textBoxPatientsFullName);
            Controls.Add(label2);
            Controls.Add(textBoxPatientsPhoneNumber);
            Controls.Add(label3);
            Controls.Add(textBoxPatientsAddress);
            Controls.Add(label4);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(label5);
            Controls.Add(comboBoxPatientsGender);
            Controls.Add(label6);
            Controls.Add(textBoxPatientsNotes);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPatientsFullName;
        private Label label2;
        private TextBox textBoxPatientsPhoneNumber;
        private Label label3;
        private TextBox textBoxPatientsAddress;
        private Label label4;
        private DateTimePicker dateTimePickerBirthDate;
        private Label label5;
        private ComboBox comboBoxPatientsGender;
        private Label label6;
        private TextBox textBoxPatientsNotes;
        private Button buttonUpdate;
        private Button buttonCancel;
    }
}
