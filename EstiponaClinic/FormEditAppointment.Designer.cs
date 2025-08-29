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
            // textBoxPatient
            // 
            textBoxPatient.Location = new Point(120, 27);
            textBoxPatient.Name = "textBoxPatient";
            textBoxPatient.Size = new Size(155, 23);
            textBoxPatient.TabIndex = 5;
            // 
            // textBoxTreatment
            // 
            textBoxTreatment.Location = new Point(120, 67);
            textBoxTreatment.Name = "textBoxTreatment";
            textBoxTreatment.Size = new Size(155, 23);
            textBoxTreatment.TabIndex = 6;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(120, 107);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(155, 23);
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
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(120, 230);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Update";
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(200, 230);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormEditAppointment
            // 
            ClientSize = new Size(350, 300);
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
            Name = "FormEditAppointment";
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
