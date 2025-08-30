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
            textBoxTreatment = new TextBox();
            textBoxCost = new TextBox();
            dateTimePickerDate = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            buttonUpdate = new Button();
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
            // textBoxPatient
            // 
            textBoxPatient.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatient.Location = new Point(173, 37);
            textBoxPatient.Name = "textBoxPatient";
            textBoxPatient.Size = new Size(311, 39);
            textBoxPatient.TabIndex = 5;
            // 
            // textBoxTreatment
            // 
            textBoxTreatment.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTreatment.Location = new Point(173, 108);
            textBoxTreatment.Name = "textBoxTreatment";
            textBoxTreatment.Size = new Size(311, 39);
            textBoxTreatment.TabIndex = 6;
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = SystemColors.ControlLight;
            textBoxCost.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCost.Location = new Point(173, 181);
            textBoxCost.Name = "textBoxCost";
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
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Green;
            buttonUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.Control;
            buttonUpdate.Location = new Point(70, 384);
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
            buttonCancel.Location = new Point(332, 384);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(129, 56);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormEditAppointment
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(521, 482);
            Controls.Add(labelPatient);
            Controls.Add(labelTreatment);
            Controls.Add(labelCost);
            Controls.Add(labelDate);
            Controls.Add(labelTime);
            Controls.Add(textBoxPatient);
            Controls.Add(textBoxTreatment);
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

        private TextBox textBoxPatient;
        private TextBox textBoxTreatment;
        private TextBox textBoxCost;
        private DateTimePicker dateTimePickerDate;
        private DateTimePicker dateTimePickerTime;

        private Button buttonUpdate;
        private Button buttonCancel;
    }
}
