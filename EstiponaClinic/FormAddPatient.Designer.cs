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
            textBoxPatientsEmail = new TextBox();
            labelEmail = new Label();
            labelBloodPressure = new Label();
            textBoxBloodPressure = new TextBox();
            labelHeartRate = new Label();
            textBoxHeartRate = new TextBox();
            labelTemperature = new Label();
            textBoxTemperature = new TextBox();
            labelRespiratoryRate = new Label();
            textBoxRespiratoryRate = new TextBox();
            labelWeight = new Label();
            textBoxWeight = new TextBox();
            labelHeight = new Label();
            textBoxHeight = new TextBox();
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
            textBoxPatientsPhoneNumber.Location = new Point(34, 159);
            textBoxPatientsPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientsPhoneNumber.Name = "textBoxPatientsPhoneNumber";
            textBoxPatientsPhoneNumber.Size = new Size(401, 39);
            textBoxPatientsPhoneNumber.TabIndex = 1;
            // 
            // textBoxPatientsAddress
            // 
            textBoxPatientsAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsAddress.Location = new Point(34, 341);
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
            comboBoxPatientsGender.Location = new Point(34, 520);
            comboBoxPatientsGender.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatientsGender.Name = "comboBoxPatientsGender";
            comboBoxPatientsGender.Size = new Size(401, 39);
            comboBoxPatientsGender.TabIndex = 3;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBirthDate.Location = new Point(34, 431);
            dateTimePickerBirthDate.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(401, 39);
            dateTimePickerBirthDate.TabIndex = 4;
            // 
            // textBoxPatientsNotes
            // 
            textBoxPatientsNotes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsNotes.Location = new Point(34, 610);
            textBoxPatientsNotes.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientsNotes.Multiline = true;
            textBoxPatientsNotes.Name = "textBoxPatientsNotes";
            textBoxPatientsNotes.Size = new Size(401, 111);
            textBoxPatientsNotes.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Green;
            buttonAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(34, 798);
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
            buttonCancel.Location = new Point(586, 798);
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
            label2.Location = new Point(34, 121);
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
            label3.Location = new Point(34, 305);
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
            label4.Location = new Point(34, 395);
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
            label5.Location = new Point(34, 484);
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
            label6.Location = new Point(34, 573);
            label6.Name = "label6";
            label6.Size = new Size(73, 32);
            label6.TabIndex = 13;
            label6.Text = "HMO";
            // 
            // textBoxPatientsEmail
            // 
            textBoxPatientsEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsEmail.Location = new Point(34, 249);
            textBoxPatientsEmail.Name = "textBoxPatientsEmail";
            textBoxPatientsEmail.Size = new Size(401, 39);
            textBoxPatientsEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.Green;
            labelEmail.Location = new Point(34, 214);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(76, 32);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email";
            // 
            // labelBloodPressure
            // 
            labelBloodPressure.AutoSize = true;
            labelBloodPressure.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelBloodPressure.ForeColor = Color.Green;
            labelBloodPressure.Location = new Point(480, 31);
            labelBloodPressure.Name = "labelBloodPressure";
            labelBloodPressure.Size = new Size(186, 32);
            labelBloodPressure.TabIndex = 15;
            labelBloodPressure.Text = "Blood Pressure";
            // 
            // textBoxBloodPressure
            // 
            textBoxBloodPressure.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBloodPressure.Location = new Point(480, 67);
            textBoxBloodPressure.Name = "textBoxBloodPressure";
            textBoxBloodPressure.Size = new Size(250, 39);
            textBoxBloodPressure.TabIndex = 16;
            // 
            // labelHeartRate
            // 
            labelHeartRate.AutoSize = true;
            labelHeartRate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeartRate.ForeColor = Color.Green;
            labelHeartRate.Location = new Point(480, 121);
            labelHeartRate.Name = "labelHeartRate";
            labelHeartRate.Size = new Size(136, 32);
            labelHeartRate.TabIndex = 17;
            labelHeartRate.Text = "Heart Rate";
            // 
            // textBoxHeartRate
            // 
            textBoxHeartRate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHeartRate.Location = new Point(480, 159);
            textBoxHeartRate.Name = "textBoxHeartRate";
            textBoxHeartRate.Size = new Size(250, 39);
            textBoxHeartRate.TabIndex = 18;
            // 
            // labelTemperature
            // 
            labelTemperature.AutoSize = true;
            labelTemperature.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTemperature.ForeColor = Color.Green;
            labelTemperature.Location = new Point(480, 214);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(159, 32);
            labelTemperature.TabIndex = 19;
            labelTemperature.Text = "Temperature";
            // 
            // textBoxTemperature
            // 
            textBoxTemperature.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTemperature.Location = new Point(480, 249);
            textBoxTemperature.Name = "textBoxTemperature";
            textBoxTemperature.Size = new Size(250, 39);
            textBoxTemperature.TabIndex = 20;
            // 
            // labelRespiratoryRate
            // 
            labelRespiratoryRate.AutoSize = true;
            labelRespiratoryRate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelRespiratoryRate.ForeColor = Color.Green;
            labelRespiratoryRate.Location = new Point(480, 305);
            labelRespiratoryRate.Name = "labelRespiratoryRate";
            labelRespiratoryRate.Size = new Size(204, 32);
            labelRespiratoryRate.TabIndex = 21;
            labelRespiratoryRate.Text = "Respiratory Rate";
            // 
            // textBoxRespiratoryRate
            // 
            textBoxRespiratoryRate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRespiratoryRate.Location = new Point(480, 341);
            textBoxRespiratoryRate.Name = "textBoxRespiratoryRate";
            textBoxRespiratoryRate.Size = new Size(250, 39);
            textBoxRespiratoryRate.TabIndex = 22;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelWeight.ForeColor = Color.Green;
            labelWeight.Location = new Point(480, 395);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(148, 32);
            labelWeight.TabIndex = 23;
            labelWeight.Text = "Weight (kg)";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeight.Location = new Point(480, 431);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(250, 39);
            textBoxWeight.TabIndex = 24;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeight.ForeColor = Color.Green;
            labelHeight.Location = new Point(480, 484);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(149, 32);
            labelHeight.TabIndex = 25;
            labelHeight.Text = "Height (cm)";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHeight.Location = new Point(480, 520);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(250, 39);
            textBoxHeight.TabIndex = 26;
            // 
            // FormAddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(770, 900);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelEmail);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPatientsNotes);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(comboBoxPatientsGender);
            Controls.Add(textBoxPatientsEmail);
            Controls.Add(textBoxPatientsAddress);
            Controls.Add(textBoxPatientsPhoneNumber);
            Controls.Add(textBoxPatientsFullName);
            Controls.Add(labelBloodPressure);
            Controls.Add(textBoxBloodPressure);
            Controls.Add(labelHeartRate);
            Controls.Add(textBoxHeartRate);
            Controls.Add(labelTemperature);
            Controls.Add(textBoxTemperature);
            Controls.Add(labelRespiratoryRate);
            Controls.Add(textBoxRespiratoryRate);
            Controls.Add(labelWeight);
            Controls.Add(textBoxWeight);
            Controls.Add(labelHeight);
            Controls.Add(textBoxHeight);
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
        private TextBox textBoxBloodPressure;
        private TextBox textBoxHeartRate;
        private TextBox textBoxTemperature;
        private TextBox textBoxRespiratoryRate;
        private TextBox textBoxWeight;
        private TextBox textBoxHeight;
        private TextBox textBoxPatientsNotes;
        private Button buttonAdd;
        private Button buttonCancel;
        private TextBox textBoxPatientsEmail;
        private Label labelEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelBloodPressure;
        private Label labelHeartRate;
        private Label labelTemperature;
        private Label labelRespiratoryRate;
        private Label labelWeight;
        private Label labelHeight;
        private Label label6;
    }
}
