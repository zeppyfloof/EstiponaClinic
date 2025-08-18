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
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelTreatment = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();

            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.comboBoxTreatment = new System.Windows.Forms.ComboBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();

            this.buttonSave = new System.Windows.Forms.Button();
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
            // ComboBoxes + TextBox
            // 
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.Location = new System.Drawing.Point(120, 27);
            this.comboBoxPatient.Width = 180;

            this.comboBoxTreatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTreatment.Location = new System.Drawing.Point(120, 67);
            this.comboBoxTreatment.Width = 180;

            this.textBoxCost.Location = new System.Drawing.Point(120, 107);
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Width = 180;

            this.dateTimePickerDate.Location = new System.Drawing.Point(120, 147);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Location = new System.Drawing.Point(120, 187);
            // 
            // Buttons
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Green;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(120, 230);
            this.buttonSave.Size = new System.Drawing.Size(80, 35);
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.Location = new System.Drawing.Point(220, 230);
            this.buttonCancel.Size = new System.Drawing.Size(80, 35);
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddAppointment
            // 
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.labelTreatment);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);

            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.comboBoxTreatment);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.dateTimePickerTime);

            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);

            this.Name = "FormAddAppointment";
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelTreatment;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;

        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.ComboBox comboBoxTreatment;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
