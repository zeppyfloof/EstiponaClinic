namespace EstiponaClinic
{
    partial class FormCertificate
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitle;
        private Label labelPatientName;
        private Label labelAge;
        private Label labelAddress;
        private Label labelDate;
        private Label labelDiagnosis;
        private Label labelRecommendations;

        private ComboBox comboBoxPatient;
        private TextBox textBoxAge;
        private TextBox textBoxAddress;
        private DateTimePicker dateTimePickerExamDate;
        private TextBox textBoxDiagnosis;
        private TextBox textBoxRecommendations;

        private Button buttonGenerate;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelPatientName = new Label();
            labelAge = new Label();
            labelAddress = new Label();
            labelDate = new Label();
            labelDiagnosis = new Label();
            labelRecommendations = new Label();

            comboBoxPatient = new ComboBox();
            textBoxAge = new TextBox();
            textBoxAddress = new TextBox();
            dateTimePickerExamDate = new DateTimePicker();
            textBoxDiagnosis = new TextBox();
            textBoxRecommendations = new TextBox();

            buttonGenerate = new Button();
            buttonCancel = new Button();

            SuspendLayout();

            // Title
            labelTitle.Text = "Dental Certificate";
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.DarkGreen;
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(20, 20);

            // Patient Name
            labelPatientName.Text = "Patient Name:";
            labelPatientName.Location = new Point(20, 70);
            comboBoxPatient.Location = new Point(150, 70);
            comboBoxPatient.Size = new Size(300, 23);
            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList; // ✅ uneditable

            // Age
            labelAge.Text = "Age:";
            labelAge.Location = new Point(20, 110);
            textBoxAge.Location = new Point(150, 110);
            textBoxAge.Size = new Size(60, 23);
            textBoxAge.ReadOnly = true; // ✅ uneditable

            // Address
            labelAddress.Text = "Address:";
            labelAddress.Location = new Point(20, 150);
            textBoxAddress.Location = new Point(150, 150);
            textBoxAddress.Size = new Size(300, 23);
            textBoxAddress.ReadOnly = true; // ✅ uneditable

            // Date of Exam
            labelDate.Text = "Exam Date:";
            labelDate.Location = new Point(20, 190);
            dateTimePickerExamDate.Location = new Point(150, 190);
            dateTimePickerExamDate.Format = DateTimePickerFormat.Short;

            // Diagnosis
            labelDiagnosis.Text = "Diagnosis:";
            labelDiagnosis.Location = new Point(20, 230);
            textBoxDiagnosis.Location = new Point(150, 230);
            textBoxDiagnosis.Size = new Size(300, 60);
            textBoxDiagnosis.Multiline = true;

            // Recommendations
            labelRecommendations.Text = "Recommendations:";
            labelRecommendations.Location = new Point(20, 310);
            textBoxRecommendations.Location = new Point(150, 310);
            textBoxRecommendations.Size = new Size(300, 80);
            textBoxRecommendations.Multiline = true;

            // Buttons
            buttonGenerate.Text = "Generate Certificate";
            buttonGenerate.BackColor = Color.Green;
            buttonGenerate.ForeColor = Color.White;
            buttonGenerate.Location = new Point(150, 410);
            buttonGenerate.Size = new Size(150, 40);

            buttonCancel.Text = "Cancel";
            buttonCancel.BackColor = Color.DarkRed;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(310, 410);
            buttonCancel.Size = new Size(140, 40);

            // Form
            ClientSize = new Size(500, 480);
            BackColor = Color.WhiteSmoke;
            Controls.Add(labelTitle);
            Controls.Add(labelPatientName);
            Controls.Add(comboBoxPatient);
            Controls.Add(labelAge);
            Controls.Add(textBoxAge);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(labelDate);
            Controls.Add(dateTimePickerExamDate);
            Controls.Add(labelDiagnosis);
            Controls.Add(textBoxDiagnosis);
            Controls.Add(labelRecommendations);
            Controls.Add(textBoxRecommendations);
            Controls.Add(buttonGenerate);
            Controls.Add(buttonCancel);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dental Certificate";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
