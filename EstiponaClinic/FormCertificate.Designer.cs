namespace EstiponaClinic
{
    partial class FormCertificate
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboBoxPatient;
        private TextBox textBoxAge;
        private TextBox textBoxAddress;
        private RichTextBox richTextBoxDiagnosis;
        private RichTextBox richTextBoxRecommendations;
        private Button buttonGenerate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxPatient = new ComboBox();
            textBoxAge = new TextBox();
            textBoxAddress = new TextBox();
            richTextBoxDiagnosis = new RichTextBox();
            richTextBoxRecommendations = new RichTextBox();
            buttonGenerate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatient.Location = new Point(150, 20);
            comboBoxPatient.Size = new Size(300, 29);
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.Location = new Point(150, 60);
            textBoxAge.Size = new Size(100, 29);
            textBoxAge.ReadOnly = true;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(150, 100);
            textBoxAddress.Size = new Size(400, 29);
            textBoxAddress.ReadOnly = true;
            // 
            // richTextBoxDiagnosis
            // 
            richTextBoxDiagnosis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDiagnosis.Location = new Point(150, 150);
            richTextBoxDiagnosis.Size = new Size(500, 100);
            // 
            // richTextBoxRecommendations
            // 
            richTextBoxRecommendations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxRecommendations.Location = new Point(150, 270);
            richTextBoxRecommendations.Size = new Size(500, 100);
            // 
            // buttonGenerate
            // 
            buttonGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGenerate.Location = new Point(540, 390);
            buttonGenerate.Size = new Size(110, 40);
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // Labels
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 25);
            label1.Text = "Patient:";

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 65);
            label2.Text = "Age:";

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 105);
            label3.Text = "Address:";

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 150);
            label4.Text = "Diagnosis:";

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 270);
            label5.Text = "Recommendations:";
            // 
            // FormCertificate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 450);
            Controls.Add(comboBoxPatient);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxAddress);
            Controls.Add(richTextBoxDiagnosis);
            Controls.Add(richTextBoxRecommendations);
            Controls.Add(buttonGenerate);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "FormCertificate";
            Text = "Generate Dental Certificate";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
