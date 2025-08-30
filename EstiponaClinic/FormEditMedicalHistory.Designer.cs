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
            btnCancel = new Button();
            SuspendLayout();
            // 
            // labelPatient
            // 
            labelPatient.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPatient.ForeColor = Color.Green;
            labelPatient.Location = new Point(42, 20);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(179, 39);
            labelPatient.TabIndex = 0;
            labelPatient.Text = "Patient Name:";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientName.Location = new Point(254, 20);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.ReadOnly = true;
            textBoxPatientName.Size = new Size(300, 39);
            textBoxPatientName.TabIndex = 1;
            // 
            // labelCondition
            // 
            labelCondition.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelCondition.ForeColor = Color.Green;
            labelCondition.Location = new Point(83, 88);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(158, 39);
            labelCondition.TabIndex = 2;
            labelCondition.Text = "Condition:";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCondition.Location = new Point(254, 88);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(300, 39);
            textBoxCondition.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = Color.Green;
            labelDate.Location = new Point(145, 161);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(86, 39);
            labelDate.TabIndex = 4;
            labelDate.Text = "Date:";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDate.Location = new Point(254, 161);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(300, 39);
            dateTimePickerDate.TabIndex = 5;
            // 
            // labelAllergies
            // 
            labelAllergies.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllergies.ForeColor = Color.Green;
            labelAllergies.Location = new Point(100, 232);
            labelAllergies.Name = "labelAllergies";
            labelAllergies.Size = new Size(131, 39);
            labelAllergies.TabIndex = 6;
            labelAllergies.Text = "Allergies:";
            // 
            // textBoxAllergies
            // 
            textBoxAllergies.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAllergies.Location = new Point(254, 232);
            textBoxAllergies.Name = "textBoxAllergies";
            textBoxAllergies.Size = new Size(300, 39);
            textBoxAllergies.TabIndex = 7;
            // 
            // labelAbnormalities
            // 
            labelAbnormalities.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbnormalities.ForeColor = Color.Green;
            labelAbnormalities.Location = new Point(42, 302);
            labelAbnormalities.Name = "labelAbnormalities";
            labelAbnormalities.Size = new Size(189, 39);
            labelAbnormalities.TabIndex = 8;
            labelAbnormalities.Text = "Abnormalities:";
            // 
            // textBoxAbnormalities
            // 
            textBoxAbnormalities.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAbnormalities.Location = new Point(254, 302);
            textBoxAbnormalities.Name = "textBoxAbnormalities";
            textBoxAbnormalities.Size = new Size(300, 39);
            textBoxAbnormalities.TabIndex = 9;
            // 
            // labelBloodPressure
            // 
            labelBloodPressure.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelBloodPressure.ForeColor = Color.Green;
            labelBloodPressure.Location = new Point(32, 372);
            labelBloodPressure.Name = "labelBloodPressure";
            labelBloodPressure.Size = new Size(199, 39);
            labelBloodPressure.TabIndex = 10;
            labelBloodPressure.Text = "Blood Pressure:";
            // 
            // textBoxBloodPressure
            // 
            textBoxBloodPressure.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBloodPressure.Location = new Point(254, 372);
            textBoxBloodPressure.Name = "textBoxBloodPressure";
            textBoxBloodPressure.Size = new Size(300, 39);
            textBoxBloodPressure.TabIndex = 11;
            // 
            // labelDrugs
            // 
            labelDrugs.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelDrugs.ForeColor = Color.Green;
            labelDrugs.Location = new Point(64, 441);
            labelDrugs.Name = "labelDrugs";
            labelDrugs.Size = new Size(177, 39);
            labelDrugs.TabIndex = 12;
            labelDrugs.Text = "Drugs Taken:";
            // 
            // textBoxDrugsTaken
            // 
            textBoxDrugsTaken.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDrugsTaken.Location = new Point(254, 441);
            textBoxDrugsTaken.Multiline = true;
            textBoxDrugsTaken.Name = "textBoxDrugsTaken";
            textBoxDrugsTaken.Size = new Size(300, 96);
            textBoxDrugsTaken.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Green;
            buttonSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = SystemColors.Control;
            buttonSave.Location = new Point(83, 583);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(144, 58);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkRed;
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(377, 583);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 58);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormEditMedicalHistory
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(583, 668);
            Controls.Add(btnCancel);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditMedicalHistory";
            ShowIcon = false;
            ShowInTaskbar = false;
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
        private Button btnCancel;
    }
}
