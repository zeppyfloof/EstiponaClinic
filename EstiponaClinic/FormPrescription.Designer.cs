namespace EstiponaClinic
{
    partial class FormPrescription
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTreatment = new Label();
            labelPatient = new Label();
            labelCost = new Label();
            labelMedicines = new Label();
            labelQuantity = new Label();
            labelSearch = new Label();
            labelTitle = new Label();
            comboBoxPrescriptionTreatment = new ComboBox();
            comboBoxPrescriptionPatient = new ComboBox();
            textBoxPrescriptionCost = new TextBox();
            textBoxPrescriptionMedicines = new TextBox();
            textBoxPrescriptionQuantity = new TextBox();
            textBoxPrescriptionSearch = new TextBox();
            dataGridViewPrescription = new DataGridView();
            buttonPrescriptionSave = new Button();
            buttonPrescriptionEdit = new Button();
            buttonPrescriptionDelete = new Button();
            buttonPrescriptionPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrescription).BeginInit();
            SuspendLayout();
            // 
            // labelTreatment
            // 
            labelTreatment.AutoSize = true;
            labelTreatment.Location = new Point(30, 70);
            labelTreatment.Name = "labelTreatment";
            labelTreatment.Size = new Size(60, 15);
            labelTreatment.TabIndex = 1;
            labelTreatment.Text = "Treatment";
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Location = new Point(30, 110);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(44, 15);
            labelPatient.TabIndex = 3;
            labelPatient.Text = "Patient";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(30, 150);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(31, 15);
            labelCost.TabIndex = 5;
            labelCost.Text = "Cost";
            // 
            // labelMedicines
            // 
            labelMedicines.AutoSize = true;
            labelMedicines.Location = new Point(320, 70);
            labelMedicines.Name = "labelMedicines";
            labelMedicines.Size = new Size(61, 15);
            labelMedicines.TabIndex = 7;
            labelMedicines.Text = "Medicines";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(320, 110);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(53, 15);
            labelQuantity.TabIndex = 9;
            labelQuantity.Text = "Quantity";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(30, 200);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 11;
            labelSearch.Text = "Search";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(173, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Prescription";
            // 
            // comboBoxPrescriptionTreatment
            // 
            comboBoxPrescriptionTreatment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrescriptionTreatment.Location = new Point(100, 67);
            comboBoxPrescriptionTreatment.Name = "comboBoxPrescriptionTreatment";
            comboBoxPrescriptionTreatment.Size = new Size(200, 23);
            comboBoxPrescriptionTreatment.TabIndex = 2;
            // 
            // comboBoxPrescriptionPatient
            // 
            comboBoxPrescriptionPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrescriptionPatient.Location = new Point(100, 107);
            comboBoxPrescriptionPatient.Name = "comboBoxPrescriptionPatient";
            comboBoxPrescriptionPatient.Size = new Size(200, 23);
            comboBoxPrescriptionPatient.TabIndex = 4;
            // 
            // textBoxPrescriptionCost
            // 
            textBoxPrescriptionCost.Location = new Point(100, 147);
            textBoxPrescriptionCost.Name = "textBoxPrescriptionCost";
            textBoxPrescriptionCost.Size = new Size(200, 23);
            textBoxPrescriptionCost.TabIndex = 6;
            // 
            // textBoxPrescriptionMedicines
            // 
            textBoxPrescriptionMedicines.Location = new Point(400, 67);
            textBoxPrescriptionMedicines.Name = "textBoxPrescriptionMedicines";
            textBoxPrescriptionMedicines.Size = new Size(200, 23);
            textBoxPrescriptionMedicines.TabIndex = 8;
            // 
            // textBoxPrescriptionQuantity
            // 
            textBoxPrescriptionQuantity.Location = new Point(400, 107);
            textBoxPrescriptionQuantity.Name = "textBoxPrescriptionQuantity";
            textBoxPrescriptionQuantity.Size = new Size(200, 23);
            textBoxPrescriptionQuantity.TabIndex = 10;
            // 
            // textBoxPrescriptionSearch
            // 
            textBoxPrescriptionSearch.Location = new Point(80, 197);
            textBoxPrescriptionSearch.Name = "textBoxPrescriptionSearch";
            textBoxPrescriptionSearch.Size = new Size(200, 23);
            textBoxPrescriptionSearch.TabIndex = 12;
            // 
            // dataGridViewPrescription
            // 
            dataGridViewPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrescription.Location = new Point(30, 270);
            dataGridViewPrescription.Name = "dataGridViewPrescription";
            dataGridViewPrescription.ReadOnly = true;
            dataGridViewPrescription.Size = new Size(740, 478);
            dataGridViewPrescription.TabIndex = 13;
            // 
            // buttonPrescriptionSave
            // 
            buttonPrescriptionSave.BackColor = Color.Green;
            buttonPrescriptionSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionSave.ForeColor = Color.White;
            buttonPrescriptionSave.Location = new Point(30, 230);
            buttonPrescriptionSave.Name = "buttonPrescriptionSave";
            buttonPrescriptionSave.Size = new Size(80, 35);
            buttonPrescriptionSave.TabIndex = 14;
            buttonPrescriptionSave.Text = "Save";
            buttonPrescriptionSave.UseVisualStyleBackColor = false;
            // 
            // buttonPrescriptionEdit
            // 
            buttonPrescriptionEdit.BackColor = Color.Green;
            buttonPrescriptionEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionEdit.ForeColor = Color.White;
            buttonPrescriptionEdit.Location = new Point(120, 230);
            buttonPrescriptionEdit.Name = "buttonPrescriptionEdit";
            buttonPrescriptionEdit.Size = new Size(80, 35);
            buttonPrescriptionEdit.TabIndex = 15;
            buttonPrescriptionEdit.Text = "Edit";
            buttonPrescriptionEdit.UseVisualStyleBackColor = false;
            // 
            // buttonPrescriptionDelete
            // 
            buttonPrescriptionDelete.BackColor = Color.Green;
            buttonPrescriptionDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionDelete.ForeColor = Color.White;
            buttonPrescriptionDelete.Location = new Point(210, 230);
            buttonPrescriptionDelete.Name = "buttonPrescriptionDelete";
            buttonPrescriptionDelete.Size = new Size(80, 35);
            buttonPrescriptionDelete.TabIndex = 16;
            buttonPrescriptionDelete.Text = "Delete";
            buttonPrescriptionDelete.UseVisualStyleBackColor = false;
            // 
            // buttonPrescriptionPrint
            // 
            buttonPrescriptionPrint.BackColor = Color.Green;
            buttonPrescriptionPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionPrint.ForeColor = Color.White;
            buttonPrescriptionPrint.Location = new Point(300, 230);
            buttonPrescriptionPrint.Name = "buttonPrescriptionPrint";
            buttonPrescriptionPrint.Size = new Size(80, 35);
            buttonPrescriptionPrint.TabIndex = 17;
            buttonPrescriptionPrint.Text = "Print";
            buttonPrescriptionPrint.UseVisualStyleBackColor = false;
            // 
            // FormPrescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 760);
            Controls.Add(labelTitle);
            Controls.Add(labelTreatment);
            Controls.Add(comboBoxPrescriptionTreatment);
            Controls.Add(labelPatient);
            Controls.Add(comboBoxPrescriptionPatient);
            Controls.Add(labelCost);
            Controls.Add(textBoxPrescriptionCost);
            Controls.Add(labelMedicines);
            Controls.Add(textBoxPrescriptionMedicines);
            Controls.Add(labelQuantity);
            Controls.Add(textBoxPrescriptionQuantity);
            Controls.Add(labelSearch);
            Controls.Add(textBoxPrescriptionSearch);
            Controls.Add(dataGridViewPrescription);
            Controls.Add(buttonPrescriptionSave);
            Controls.Add(buttonPrescriptionEdit);
            Controls.Add(buttonPrescriptionDelete);
            Controls.Add(buttonPrescriptionPrint);
            Name = "FormPrescription";
            Text = "Prescription Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrescription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTreatment;
        private Label labelPatient;
        private Label labelCost;
        private Label labelMedicines;
        private Label labelQuantity;
        private Label labelSearch;
        private Label labelTitle;
        private ComboBox comboBoxPrescriptionTreatment;
        private ComboBox comboBoxPrescriptionPatient;
        private TextBox textBoxPrescriptionCost;
        private TextBox textBoxPrescriptionMedicines;
        private TextBox textBoxPrescriptionQuantity;
        private TextBox textBoxPrescriptionSearch;
        private DataGridView dataGridViewPrescription;
        private Button buttonPrescriptionSave;
        private Button buttonPrescriptionEdit;
        private Button buttonPrescriptionDelete;
        private Button buttonPrescriptionPrint;
    }
}
