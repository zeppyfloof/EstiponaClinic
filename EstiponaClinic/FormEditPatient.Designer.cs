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
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // textBoxPatientsFullName
            // 
            textBoxPatientsFullName.Location = new Point(150, 20);
            textBoxPatientsFullName.Name = "textBoxPatientsFullName";
            textBoxPatientsFullName.Size = new Size(200, 23);
            textBoxPatientsFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Phone Number:";
            // 
            // textBoxPatientsPhoneNumber
            // 
            textBoxPatientsPhoneNumber.Location = new Point(150, 60);
            textBoxPatientsPhoneNumber.Name = "textBoxPatientsPhoneNumber";
            textBoxPatientsPhoneNumber.Size = new Size(200, 23);
            textBoxPatientsPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // textBoxPatientsAddress
            // 
            textBoxPatientsAddress.Location = new Point(150, 100);
            textBoxPatientsAddress.Name = "textBoxPatientsAddress";
            textBoxPatientsAddress.Size = new Size(200, 23);
            textBoxPatientsAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 6;
            label4.Text = "Date of Birth:";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(150, 140);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(200, 23);
            dateTimePickerBirthDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(20, 180);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 8;
            label5.Text = "Gender:";
            // 
            // comboBoxPatientsGender
            // 
            comboBoxPatientsGender.Location = new Point(150, 180);
            comboBoxPatientsGender.Name = "comboBoxPatientsGender";
            comboBoxPatientsGender.Size = new Size(200, 23);
            comboBoxPatientsGender.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(20, 220);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 10;
            label6.Text = "Notes:";
            // 
            // textBoxPatientsNotes
            // 
            textBoxPatientsNotes.Location = new Point(150, 220);
            textBoxPatientsNotes.Name = "textBoxPatientsNotes";
            textBoxPatientsNotes.Size = new Size(200, 23);
            textBoxPatientsNotes.TabIndex = 11;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(50, 270);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(200, 270);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormEditPatient
            // 
            ClientSize = new Size(400, 330);
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
