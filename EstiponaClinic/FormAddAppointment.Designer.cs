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
            labelPatient.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPatient.ForeColor = Color.Green;
            labelPatient.Location = new Point(60, 37);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(101, 32);
            labelPatient.TabIndex = 0;
            labelPatient.Text = "Patient:";
            // 
            // labelTreatment
            // 
            labelTreatment.AutoSize = true;
            labelTreatment.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTreatment.ForeColor = Color.Green;
            labelTreatment.Location = new Point(30, 108);
            labelTreatment.Name = "labelTreatment";
            labelTreatment.Size = new Size(137, 32);
            labelTreatment.TabIndex = 1;
            labelTreatment.Text = "Treatment:";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelCost.ForeColor = Color.Green;
            labelCost.Location = new Point(90, 181);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(71, 32);
            labelCost.TabIndex = 2;
            labelCost.Text = "Cost:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = Color.Green;
            labelDate.Location = new Point(90, 250);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(74, 32);
            labelDate.TabIndex = 3;
            labelDate.Text = "Date:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.ForeColor = Color.Green;
            labelTime.Location = new Point(87, 320);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(77, 32);
            labelTime.TabIndex = 4;
            labelTime.Text = "Time:";
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatient.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatient.Location = new Point(173, 37);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(311, 39);
            comboBoxPatient.TabIndex = 5;
            // 
            // comboBoxTreatment
            // 
            comboBoxTreatment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTreatment.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTreatment.Location = new Point(173, 108);
            comboBoxTreatment.Name = "comboBoxTreatment";
            comboBoxTreatment.Size = new Size(311, 39);
            comboBoxTreatment.TabIndex = 6;
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = SystemColors.ControlLight;
            textBoxCost.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCost.Location = new Point(173, 181);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.ReadOnly = true;
            textBoxCost.Size = new Size(311, 39);
            textBoxCost.TabIndex = 7;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDate.Location = new Point(170, 250);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(314, 39);
            dateTimePickerDate.TabIndex = 8;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(170, 320);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.Size = new Size(314, 39);
            dateTimePickerTime.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Green;
            buttonSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(70, 384);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(129, 56);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkRed;
            buttonCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(332, 384);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(129, 56);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormAddAppointment
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(521, 482);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddAppointment";
            ShowIcon = false;
            ShowInTaskbar = false;
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
