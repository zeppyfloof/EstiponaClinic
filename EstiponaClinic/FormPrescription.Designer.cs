namespace EstiponaClinic
{
    partial class FormPrescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            textBoxPrescriptionSearch = new TextBox();
            dataGridViewPprescription = new DataGridView();
            buttonPrescriptionDelete = new Button();
            buttonPrescriptionPrint = new Button();
            buttonPrescriptionsSave = new Button();
            textBoxPrescriptionQuantity = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxPrescriptionTreatment = new ComboBox();
            textBoxPatientsAddress = new TextBox();
            comboBoxPrescriptionPatient = new ComboBox();
            textBoxPrescriptionMedicines = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPprescription).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 212);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 36;
            label7.Text = "Search";
            // 
            // textBoxPrescriptionSearch
            // 
            textBoxPrescriptionSearch.Location = new Point(59, 209);
            textBoxPrescriptionSearch.Name = "textBoxPrescriptionSearch";
            textBoxPrescriptionSearch.Size = new Size(200, 23);
            textBoxPrescriptionSearch.TabIndex = 35;
            // 
            // dataGridViewPprescription
            // 
            dataGridViewPprescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPprescription.Location = new Point(12, 515);
            dataGridViewPprescription.Name = "dataGridViewPprescription";
            dataGridViewPprescription.RowTemplate.Height = 25;
            dataGridViewPprescription.Size = new Size(776, 233);
            dataGridViewPprescription.TabIndex = 34;
            // 
            // buttonPrescriptionDelete
            // 
            buttonPrescriptionDelete.BackColor = Color.Green;
            buttonPrescriptionDelete.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonPrescriptionDelete.Location = new Point(431, 166);
            buttonPrescriptionDelete.Name = "buttonPrescriptionDelete";
            buttonPrescriptionDelete.Size = new Size(97, 33);
            buttonPrescriptionDelete.TabIndex = 33;
            buttonPrescriptionDelete.Text = "Delete";
            buttonPrescriptionDelete.UseVisualStyleBackColor = false;
            // 
            // buttonPrescriptionPrint
            // 
            buttonPrescriptionPrint.BackColor = Color.Green;
            buttonPrescriptionPrint.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionPrint.ForeColor = SystemColors.ButtonHighlight;
            buttonPrescriptionPrint.Location = new Point(328, 166);
            buttonPrescriptionPrint.Name = "buttonPrescriptionPrint";
            buttonPrescriptionPrint.Size = new Size(97, 33);
            buttonPrescriptionPrint.TabIndex = 32;
            buttonPrescriptionPrint.Text = "Print";
            buttonPrescriptionPrint.UseVisualStyleBackColor = false;
            // 
            // buttonPrescriptionsSave
            // 
            buttonPrescriptionsSave.BackColor = Color.Green;
            buttonPrescriptionsSave.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionsSave.ForeColor = SystemColors.ButtonHighlight;
            buttonPrescriptionsSave.Location = new Point(225, 166);
            buttonPrescriptionsSave.Name = "buttonPrescriptionsSave";
            buttonPrescriptionsSave.Size = new Size(97, 33);
            buttonPrescriptionsSave.TabIndex = 31;
            buttonPrescriptionsSave.Text = "Save";
            buttonPrescriptionsSave.UseVisualStyleBackColor = false;
            // 
            // textBoxPrescriptionQuantity
            // 
            textBoxPrescriptionQuantity.Location = new Point(462, 97);
            textBoxPrescriptionQuantity.Name = "textBoxPrescriptionQuantity";
            textBoxPrescriptionQuantity.Size = new Size(200, 23);
            textBoxPrescriptionQuantity.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(404, 100);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 29;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 71);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 28;
            label5.Text = "Medicines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 129);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 26;
            label3.Text = "Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 100);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 25;
            label2.Text = "Patient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 71);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 24;
            label1.Text = "Treatment";
            // 
            // comboBoxPrescriptionTreatment
            // 
            comboBoxPrescriptionTreatment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrescriptionTreatment.FormattingEnabled = true;
            comboBoxPrescriptionTreatment.Location = new Point(122, 68);
            comboBoxPrescriptionTreatment.Name = "comboBoxPrescriptionTreatment";
            comboBoxPrescriptionTreatment.Size = new Size(200, 23);
            comboBoxPrescriptionTreatment.TabIndex = 22;
            // 
            // textBoxPatientsAddress
            // 
            textBoxPatientsAddress.Location = new Point(122, 126);
            textBoxPatientsAddress.Name = "textBoxPatientsAddress";
            textBoxPatientsAddress.Size = new Size(200, 23);
            textBoxPatientsAddress.TabIndex = 21;
            // 
            // comboBoxPrescriptionPatient
            // 
            comboBoxPrescriptionPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrescriptionPatient.FormattingEnabled = true;
            comboBoxPrescriptionPatient.Location = new Point(122, 97);
            comboBoxPrescriptionPatient.Name = "comboBoxPrescriptionPatient";
            comboBoxPrescriptionPatient.Size = new Size(200, 23);
            comboBoxPrescriptionPatient.TabIndex = 37;
            // 
            // textBoxPrescriptionMedicines
            // 
            textBoxPrescriptionMedicines.Location = new Point(463, 68);
            textBoxPrescriptionMedicines.Name = "textBoxPrescriptionMedicines";
            textBoxPrescriptionMedicines.Size = new Size(200, 23);
            textBoxPrescriptionMedicines.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(293, 18);
            label8.Name = "label8";
            label8.Size = new Size(173, 37);
            label8.TabIndex = 39;
            label8.Text = "Prescription";
            // 
            // FormPrescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 760);
            Controls.Add(label8);
            Controls.Add(textBoxPrescriptionMedicines);
            Controls.Add(comboBoxPrescriptionPatient);
            Controls.Add(label7);
            Controls.Add(textBoxPrescriptionSearch);
            Controls.Add(dataGridViewPprescription);
            Controls.Add(buttonPrescriptionDelete);
            Controls.Add(buttonPrescriptionPrint);
            Controls.Add(buttonPrescriptionsSave);
            Controls.Add(textBoxPrescriptionQuantity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxPrescriptionTreatment);
            Controls.Add(textBoxPatientsAddress);
            Name = "FormPrescription";
            Text = "FormPrescription";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPprescription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBoxPrescriptionSearch;
        private DataGridView dataGridViewPprescription;
        private Button buttonPrescriptionDelete;
        private Button buttonPrescriptionPrint;
        private Button buttonPrescriptionsSave;
        private TextBox textBoxPrescriptionQuantity;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxPrescriptionTreatment;
        private TextBox textBoxPatientsAddress;
        private ComboBox comboBoxPrescriptionPatient;
        private TextBox textBoxPrescriptionMedicines;
        private Label label8;
    }
}