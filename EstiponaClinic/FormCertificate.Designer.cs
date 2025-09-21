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
            label6 = new Label();
            textBoxPurpose = new TextBox();
            textBoxPTR = new TextBox();
            label7 = new Label();
            label8 = new Label();
            labelBP = new Label();
            textBoxBP = new TextBox();
            labelHR = new Label();
            textBoxHR = new TextBox();
            labelTemp = new Label();
            textBoxTemp = new TextBox();
            labelWeight = new Label();
            textBoxWeight = new TextBox();
            labelHeight = new Label();
            textBoxHeight = new TextBox();
            SuspendLayout();
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatient.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatient.Location = new Point(165, 122);
            comboBoxPatient.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(366, 39);
            comboBoxPatient.TabIndex = 0;
            // 
            // textBoxAge
            // 
            textBoxAge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.Location = new Point(780, 122);
            textBoxAge.Margin = new Padding(3, 4, 3, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.ReadOnly = true;
            textBoxAge.Size = new Size(158, 39);
            textBoxAge.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(165, 178);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(775, 60);
            textBoxAddress.TabIndex = 2;
            // 
            // richTextBoxDiagnosis
            // 
            richTextBoxDiagnosis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxDiagnosis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDiagnosis.Location = new Point(42, 499);
            richTextBoxDiagnosis.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDiagnosis.Name = "richTextBoxDiagnosis";
            richTextBoxDiagnosis.Size = new Size(896, 132);
            richTextBoxDiagnosis.TabIndex = 3;
            richTextBoxDiagnosis.Text = "";
            // 
            // richTextBoxRecommendations
            // 
            richTextBoxRecommendations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxRecommendations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxRecommendations.Location = new Point(44, 671);
            richTextBoxRecommendations.Margin = new Padding(3, 4, 3, 4);
            richTextBoxRecommendations.Name = "richTextBoxRecommendations";
            richTextBoxRecommendations.Size = new Size(896, 307);
            richTextBoxRecommendations.TabIndex = 4;
            richTextBoxRecommendations.Text = "";
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonGenerate.BackColor = Color.Green;
            buttonGenerate.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGenerate.ForeColor = Color.White;
            buttonGenerate.Location = new Point(791, 996);
            buttonGenerate.Margin = new Padding(3, 4, 3, 4);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(149, 56);
            buttonGenerate.TabIndex = 5;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += ButtonGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(58, 122);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 6;
            label1.Text = "Patient:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(708, 122);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 7;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(46, 181);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 8;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(42, 463);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 9;
            label4.Text = "Diagnosis:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(44, 635);
            label5.Name = "label5";
            label5.Size = new Size(233, 32);
            label5.TabIndex = 10;
            label5.Text = "Recommendations:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(23, 29);
            label6.Name = "label6";
            label6.Size = new Size(219, 54);
            label6.TabIndex = 11;
            label6.Text = "Certificate";
            // 
            // textBoxPurpose
            // 
            textBoxPurpose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPurpose.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPurpose.Location = new Point(167, 272);
            textBoxPurpose.Multiline = true;
            textBoxPurpose.Name = "textBoxPurpose";
            textBoxPurpose.Size = new Size(442, 67);
            textBoxPurpose.TabIndex = 12;
            // 
            // textBoxPTR
            // 
            textBoxPTR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPTR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPTR.Location = new Point(708, 272);
            textBoxPTR.Name = "textBoxPTR";
            textBoxPTR.Size = new Size(230, 39);
            textBoxPTR.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(46, 272);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 14;
            label7.Text = "Purpose:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(615, 272);
            label8.Name = "label8";
            label8.Size = new Size(87, 32);
            label8.TabIndex = 15;
            label8.Text = "PTR #:";
            // 
            // labelBP
            // 
            labelBP.AutoSize = true;
            labelBP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBP.ForeColor = Color.Green;
            labelBP.Location = new Point(49, 366);
            labelBP.Name = "labelBP";
            labelBP.Size = new Size(158, 28);
            labelBP.TabIndex = 16;
            labelBP.Text = "Blood Pressure:";
            // 
            // textBoxBP
            // 
            textBoxBP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBP.Location = new Point(237, 363);
            textBoxBP.Name = "textBoxBP";
            textBoxBP.ReadOnly = true;
            textBoxBP.Size = new Size(150, 34);
            textBoxBP.TabIndex = 17;
            // 
            // labelHR
            // 
            labelHR.AutoSize = true;
            labelHR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHR.ForeColor = Color.Green;
            labelHR.Location = new Point(448, 366);
            labelHR.Name = "labelHR";
            labelHR.Size = new Size(120, 28);
            labelHR.TabIndex = 18;
            labelHR.Text = "Heart Rate:";
            // 
            // textBoxHR
            // 
            textBoxHR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHR.Location = new Point(574, 363);
            textBoxHR.Name = "textBoxHR";
            textBoxHR.ReadOnly = true;
            textBoxHR.Size = new Size(141, 34);
            textBoxHR.TabIndex = 19;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTemp.ForeColor = Color.Green;
            labelTemp.Location = new Point(764, 366);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(68, 28);
            labelTemp.TabIndex = 20;
            labelTemp.Text = "Temp:";
            // 
            // textBoxTemp
            // 
            textBoxTemp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTemp.Location = new Point(838, 363);
            textBoxTemp.Name = "textBoxTemp";
            textBoxTemp.ReadOnly = true;
            textBoxTemp.Size = new Size(100, 34);
            textBoxTemp.TabIndex = 21;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWeight.ForeColor = Color.Green;
            labelWeight.Location = new Point(122, 408);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(85, 28);
            labelWeight.TabIndex = 22;
            labelWeight.Text = "Weight:";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeight.Location = new Point(237, 408);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.ReadOnly = true;
            textBoxWeight.Size = new Size(150, 34);
            textBoxWeight.TabIndex = 23;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeight.ForeColor = Color.Green;
            labelHeight.Location = new Point(751, 408);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(81, 28);
            labelHeight.TabIndex = 24;
            labelHeight.Text = "Height:";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHeight.Location = new Point(838, 408);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.ReadOnly = true;
            textBoxHeight.Size = new Size(100, 34);
            textBoxHeight.TabIndex = 25;
            // 
            // FormCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(985, 1055);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxPTR);
            Controls.Add(textBoxPurpose);
            Controls.Add(label6);
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
            Controls.Add(labelBP);
            Controls.Add(textBoxBP);
            Controls.Add(labelHR);
            Controls.Add(textBoxHR);
            Controls.Add(labelTemp);
            Controls.Add(textBoxTemp);
            Controls.Add(labelWeight);
            Controls.Add(textBoxWeight);
            Controls.Add(labelHeight);
            Controls.Add(textBoxHeight);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCertificate";
            Text = "Generate Dental Certificate";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label6;
        private TextBox textBoxPurpose;
        private TextBox textBoxPTR;
        private Label label7;
        private Label label8;
        private TextBox textBoxBP;
        private TextBox textBoxHR;
        private TextBox textBoxTemp;
        private TextBox textBoxWeight;
        private TextBox textBoxHeight;
        private Label labelBP;
        private Label labelHR;
        private Label labelTemp;
        private Label labelWeight;
        private Label labelHeight;

    }
}
