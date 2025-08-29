namespace EstiponaClinic
{
    partial class FormAddAppointment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelPatient = new Label();
            labelTreatment = new Label();
            labelCost = new Label();
            labelDate = new Label();
            labelTime = new Label();
            comboBoxPatient = new ComboBox();
            comboBoxTreatment = new ComboBox();
            textBoxCost = new TextBox();
            dateTimePickerDate = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Location = new Point(30, 30);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(47, 15);
            labelPatient.TabIndex = 0;
            labelPatient.Text = "Patient:";
            // 
            // labelTreatment
            // 
            labelTreatment.AutoSize = true;
            labelTreatment.Location = new Point(30, 70);
            labelTreatment.Name = "labelTreatment";
            labelTreatment.Size = new Size(63, 15);
            labelTreatment.TabIndex = 1;
            labelTreatment.Text = "Treatment:";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(30, 110);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(34, 15);
            labelCost.TabIndex = 2;
            labelCost.Text = "Cost:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(30, 150);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(34, 15);
            labelDate.TabIndex = 3;
            labelDate.Text = "Date:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(30, 190);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(36, 15);
            labelTime.TabIndex = 4;
            labelTime.Text = "Time:";
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatient.Location = new Point(120, 27);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(180, 23);
            comboBoxPatient.TabIndex = 5;
            // 
            // comboBoxTreatment
            // 
            comboBoxTreatment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTreatment.Location = new Point(120, 67);
            comboBoxTreatment.Name = "comboBoxTreatment";
            comboBoxTreatment.Size = new Size(180, 23);
            comboBoxTreatment.TabIndex = 6;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(120, 107);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.ReadOnly = true;
            textBoxCost.Size = new Size(180, 23);
            textBoxCost.TabIndex = 7;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(120, 147);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(200, 23);
            dateTimePickerDate.TabIndex = 8;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(120, 187);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.Size = new Size(200, 23);
            dateTimePickerTime.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Green;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(120, 230);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(80, 35);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(220, 230);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(80, 35);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormAddAppointment
            // 
            ClientSize = new Size(350, 300);
            Controls.Add(labelPatient);
            Controls.Add(labelTreatment);
            Controls.Add(labelCost);
            Controls.Add(labelDate);
            Controls.Add(labelTime);
            Controls.Add(comboBoxPatient);
            Controls.Add(comboBoxTreatment);
            Controls.Add(textBoxCost);
            Controls.Add(dateTimePickerDate);
            Controls.Add(dateTimePickerTime);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Name = "FormAddAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPatient;
        private Label labelTreatment;
        private Label labelCost;
        private Label labelDate;
        private Label labelTime;

        private ComboBox comboBoxPatient;
        private ComboBox comboBoxTreatment;
        private TextBox textBoxCost;
        private DateTimePicker dateTimePickerDate;
        private DateTimePicker dateTimePickerTime;

        private Button buttonSave;
        private Button buttonCancel;
    }
}
