namespace EstiponaClinic
{
    partial class FormEditMedicalHistory
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelPatient = new System.Windows.Forms.Label();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelAllergies = new System.Windows.Forms.Label();
            this.textBoxAllergies = new System.Windows.Forms.TextBox();
            this.labelAbnormalities = new System.Windows.Forms.Label();
            this.textBoxAbnormalities = new System.Windows.Forms.TextBox();
            this.labelBloodPressure = new System.Windows.Forms.Label();
            this.textBoxBloodPressure = new System.Windows.Forms.TextBox();
            this.labelDrugs = new System.Windows.Forms.Label();
            this.textBoxDrugsTaken = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPatient
            // 
            this.labelPatient.Text = "Patient Name";
            this.labelPatient.Location = new System.Drawing.Point(20, 20);
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(120, 20);
            this.textBoxPatientName.Size = new System.Drawing.Size(200, 23);
            this.textBoxPatientName.ReadOnly = true;
            // 
            // labelCondition
            // 
            this.labelCondition.Text = "Condition";
            this.labelCondition.Location = new System.Drawing.Point(20, 60);
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(120, 60);
            this.textBoxCondition.Size = new System.Drawing.Size(200, 23);
            // 
            // labelDate
            // 
            this.labelDate.Text = "Date";
            this.labelDate.Location = new System.Drawing.Point(20, 100);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(120, 100);
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 23);
            // 
            // labelAllergies
            // 
            this.labelAllergies.Text = "Allergies";
            this.labelAllergies.Location = new System.Drawing.Point(20, 140);
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.Location = new System.Drawing.Point(120, 140);
            this.textBoxAllergies.Size = new System.Drawing.Size(200, 23);
            // 
            // labelAbnormalities
            // 
            this.labelAbnormalities.Text = "Abnormalities";
            this.labelAbnormalities.Location = new System.Drawing.Point(20, 180);
            // 
            // textBoxAbnormalities
            // 
            this.textBoxAbnormalities.Location = new System.Drawing.Point(120, 180);
            this.textBoxAbnormalities.Size = new System.Drawing.Size(200, 23);
            // 
            // labelBloodPressure
            // 
            this.labelBloodPressure.Text = "Blood Pressure";
            this.labelBloodPressure.Location = new System.Drawing.Point(20, 220);
            // 
            // textBoxBloodPressure
            // 
            this.textBoxBloodPressure.Location = new System.Drawing.Point(120, 220);
            this.textBoxBloodPressure.Size = new System.Drawing.Size(200, 23);
            // 
            // labelDrugs
            // 
            this.labelDrugs.Text = "Drugs Taken";
            this.labelDrugs.Location = new System.Drawing.Point(20, 260);
            // 
            // textBoxDrugsTaken
            // 
            this.textBoxDrugsTaken.Location = new System.Drawing.Point(120, 260);
            this.textBoxDrugsTaken.Size = new System.Drawing.Size(200, 23);
            // 
            // buttonSave
            // 
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.Location = new System.Drawing.Point(120, 310);
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormEditMedicalHistory
            // 
            this.ClientSize = new System.Drawing.Size(360, 370);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.labelPatient, this.textBoxPatientName,
                this.labelCondition, this.textBoxCondition,
                this.labelDate, this.dateTimePickerDate,
                this.labelAllergies, this.textBoxAllergies,
                this.labelAbnormalities, this.textBoxAbnormalities,
                this.labelBloodPressure, this.textBoxBloodPressure,
                this.labelDrugs, this.textBoxDrugsTaken,
                this.buttonSave
            });
            this.Text = "Edit Medical History";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelAllergies;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.Label labelAbnormalities;
        private System.Windows.Forms.TextBox textBoxAbnormalities;
        private System.Windows.Forms.Label labelBloodPressure;
        private System.Windows.Forms.TextBox textBoxBloodPressure;
        private System.Windows.Forms.Label labelDrugs;
        private System.Windows.Forms.TextBox textBoxDrugsTaken;
        private System.Windows.Forms.Button buttonSave;
    }
}
