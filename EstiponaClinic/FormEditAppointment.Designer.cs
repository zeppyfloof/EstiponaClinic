namespace EstiponaClinic
{
    partial class FormEditAppointment
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
            textBoxPatient = new TextBox();
            comboBoxTreatment = new ComboBox();
            textBoxCost = new TextBox();
            dateTimePickerDate = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            buttonUpdate = new Button();
            buttonCancel = new Button();
            labelCategory = new Label();
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
            labelTreatment.Location = new Point(24, 121);
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
            labelCost.Location = new Point(90, 235);
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
            labelDate.Location = new Point(87, 313);
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
            labelTime.Location = new Point(84, 390);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(77, 32);
            labelTime.TabIndex = 4;
            labelTime.Text = "Time:";
            // 
            // textBoxPatient
            // 
            textBoxPatient.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatient.Location = new Point(173, 37);
            textBoxPatient.Name = "textBoxPatient";
            textBoxPatient.Size = new Size(311, 39);
            textBoxPatient.TabIndex = 5;
            // 
            // comboBoxTreatment
            // 
            comboBoxTreatment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTreatment.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTreatment.Location = new Point(173, 121);
            comboBoxTreatment.Name = "comboBoxTreatment";
            comboBoxTreatment.Size = new Size(311, 39);
            comboBoxTreatment.TabIndex = 6;
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = SystemColors.ControlLight;
            textBoxCost.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCost.Location = new Point(173, 235);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(311, 39);
            textBoxCost.TabIndex = 7;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDate.Location = new Point(167, 313);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(314, 39);
            dateTimePickerDate.TabIndex = 8;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(167, 390);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.Size = new Size(314, 39);
            dateTimePickerTime.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Green;
            buttonUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.Control;
            buttonUpdate.Location = new Point(70, 474);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(129, 56);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkRed;
            buttonCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(332, 474);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(129, 56);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.ForeColor = Color.Green;
            labelCategory.Location = new Point(173, 176);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(117, 28);
            labelCategory.TabIndex = 12;
            labelCategory.Text = "Category: -";
            // 
            // FormEditAppointment
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(521, 568);
            Controls.Add(labelPatient);
            Controls.Add(labelTreatment);
            Controls.Add(labelCost);
            Controls.Add(labelDate);
            Controls.Add(labelTime);
            Controls.Add(textBoxPatient);
            Controls.Add(comboBoxTreatment);
            Controls.Add(labelCategory);
            Controls.Add(textBoxCost);
            Controls.Add(dateTimePickerDate);
            Controls.Add(dateTimePickerTime);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditAppointment";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPatient;
        private Label labelTreatment;
        private Label labelCost;
        private Label labelDate;
        private Label labelTime;
        private Label labelCategory;

        private TextBox textBoxPatient;
        private ComboBox comboBoxTreatment;
        private TextBox textBoxCost;
        private DateTimePicker dateTimePickerDate;
        private DateTimePicker dateTimePickerTime;

        private Button buttonUpdate;
        private Button buttonCancel;
    }
}
