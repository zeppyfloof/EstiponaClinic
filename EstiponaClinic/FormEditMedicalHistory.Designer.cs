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
            labelPatient = new Label();
            textBoxPatientName = new TextBox();
            labelCondition = new Label();
            textBoxCondition = new TextBox();
            labelDate = new Label();
            dateTimePickerDate = new DateTimePicker();
            labelAllergies = new Label();
            textBoxAllergies = new TextBox();
            labelAbnormalities = new Label();
            textBoxAbnormalities = new TextBox();
            labelBloodPressure = new Label();
            textBoxBloodPressure = new TextBox();
            labelDrugs = new Label();
            textBoxDrugsTaken = new TextBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // labelPatient
            // 
            labelPatient.Location = new Point(20, 20);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(100, 23);
            labelPatient.TabIndex = 0;
            labelPatient.Text = "Patient Name";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Location = new Point(120, 20);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.ReadOnly = true;
            textBoxPatientName.Size = new Size(200, 23);
            textBoxPatientName.TabIndex = 1;
            // 
            // labelCondition
            // 
            labelCondition.Location = new Point(20, 60);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(100, 23);
            labelCondition.TabIndex = 2;
            labelCondition.Text = "Condition";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(120, 60);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(200, 23);
            textBoxCondition.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.Location = new Point(20, 100);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(100, 23);
            labelDate.TabIndex = 4;
            labelDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(120, 100);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(200, 23);
            dateTimePickerDate.TabIndex = 5;
            // 
            // labelAllergies
            // 
            labelAllergies.Location = new Point(20, 140);
            labelAllergies.Name = "labelAllergies";
            labelAllergies.Size = new Size(100, 23);
            labelAllergies.TabIndex = 6;
            labelAllergies.Text = "Allergies";
            // 
            // textBoxAllergies
            // 
            textBoxAllergies.Location = new Point(120, 140);
            textBoxAllergies.Name = "textBoxAllergies";
            textBoxAllergies.Size = new Size(200, 23);
            textBoxAllergies.TabIndex = 7;
            // 
            // labelAbnormalities
            // 
            labelAbnormalities.Location = new Point(20, 180);
            labelAbnormalities.Name = "labelAbnormalities";
            labelAbnormalities.Size = new Size(100, 23);
            labelAbnormalities.TabIndex = 8;
            labelAbnormalities.Text = "Abnormalities";
            // 
            // textBoxAbnormalities
            // 
            textBoxAbnormalities.Location = new Point(120, 180);
            textBoxAbnormalities.Name = "textBoxAbnormalities";
            textBoxAbnormalities.Size = new Size(200, 23);
            textBoxAbnormalities.TabIndex = 9;
            // 
            // labelBloodPressure
            // 
            labelBloodPressure.Location = new Point(20, 220);
            labelBloodPressure.Name = "labelBloodPressure";
            labelBloodPressure.Size = new Size(100, 23);
            labelBloodPressure.TabIndex = 10;
            labelBloodPressure.Text = "Blood Pressure";
            // 
            // textBoxBloodPressure
            // 
            textBoxBloodPressure.Location = new Point(120, 220);
            textBoxBloodPressure.Name = "textBoxBloodPressure";
            textBoxBloodPressure.Size = new Size(200, 23);
            textBoxBloodPressure.TabIndex = 11;
            // 
            // labelDrugs
            // 
            labelDrugs.Location = new Point(20, 260);
            labelDrugs.Name = "labelDrugs";
            labelDrugs.Size = new Size(100, 23);
            labelDrugs.TabIndex = 12;
            labelDrugs.Text = "Drugs Taken";
            // 
            // textBoxDrugsTaken
            // 
            textBoxDrugsTaken.Location = new Point(120, 260);
            textBoxDrugsTaken.Name = "textBoxDrugsTaken";
            textBoxDrugsTaken.Size = new Size(200, 23);
            textBoxDrugsTaken.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(120, 310);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 30);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save Changes";
            buttonSave.Click += buttonSave_Click;
            // 
            // FormEditMedicalHistory
            // 
            ClientSize = new Size(360, 370);
            Controls.Add(labelPatient);
            Controls.Add(textBoxPatientName);
            Controls.Add(labelCondition);
            Controls.Add(textBoxCondition);
            Controls.Add(labelDate);
            Controls.Add(dateTimePickerDate);
            Controls.Add(labelAllergies);
            Controls.Add(textBoxAllergies);
            Controls.Add(labelAbnormalities);
            Controls.Add(textBoxAbnormalities);
            Controls.Add(labelBloodPressure);
            Controls.Add(textBoxBloodPressure);
            Controls.Add(labelDrugs);
            Controls.Add(textBoxDrugsTaken);
            Controls.Add(buttonSave);
            Name = "FormEditMedicalHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Medical History";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelPatient;
        private TextBox textBoxPatientName;
        private Label labelCondition;
        private TextBox textBoxCondition;
        private Label labelDate;
        private DateTimePicker dateTimePickerDate;
        private Label labelAllergies;
        private TextBox textBoxAllergies;
        private Label labelAbnormalities;
        private TextBox textBoxAbnormalities;
        private Label labelBloodPressure;
        private TextBox textBoxBloodPressure;
        private Label labelDrugs;
        private TextBox textBoxDrugsTaken;
        private Button buttonSave;
    }
}
