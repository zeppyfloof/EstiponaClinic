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
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelTreatment = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();

            this.textBoxPatient = new System.Windows.Forms.TextBox();
            this.textBoxTreatment = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();

            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // Labels
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new System.Drawing.Point(30, 30);
            this.labelPatient.Text = "Patient:";
            this.labelTreatment.AutoSize = true;
            this.labelTreatment.Location = new System.Drawing.Point(30, 70);
            this.labelTreatment.Text = "Treatment:";
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(30, 110);
            this.labelCost.Text = "Cost:";
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(30, 150);
            this.labelDate.Text = "Date:";
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(30, 190);
            this.labelTime.Text = "Time:";
            // 
            // Textboxes
            // 
            this.textBoxPatient.Location = new System.Drawing.Point(120, 27);
            this.textBoxTreatment.Location = new System.Drawing.Point(120, 67);
            this.textBoxCost.Location = new System.Drawing.Point(120, 107);
            this.dateTimePickerDate.Location = new System.Drawing.Point(120, 147);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Location = new System.Drawing.Point(120, 187);
            // 
            // Buttons
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(120, 230);
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);

            this.buttonCancel.Location = new System.Drawing.Point(200, 230);
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEditAppointment
            // 
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.labelTreatment);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);

            this.Controls.Add(this.textBoxPatient);
            this.Controls.Add(this.textBoxTreatment);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.dateTimePickerTime);

            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCancel);

            this.Name = "FormEditAppointment";
            this.Text = "Edit Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelTreatment;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;

        private System.Windows.Forms.TextBox textBoxPatient;
        private System.Windows.Forms.TextBox textBoxTreatment;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
    }
}
