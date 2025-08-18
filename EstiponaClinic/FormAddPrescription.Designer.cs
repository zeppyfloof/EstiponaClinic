namespace EstiponaClinic
{
    partial class FormAddPrescription
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelPatient = new Label();
            this.labelTreatment = new Label();
            this.labelCost = new Label();
            this.labelMedicines = new Label();
            this.labelQuantity = new Label();

            this.comboBoxPatient = new ComboBox();
            this.comboBoxTreatment = new ComboBox();
            this.textBoxCost = new TextBox();
            this.textBoxMedicines = new TextBox();
            this.textBoxQuantity = new TextBox();

            this.buttonSave = new Button();
            this.buttonCancel = new Button();

            this.SuspendLayout();

            // Label Patient
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new Point(30, 30);
            this.labelPatient.Text = "Patient:";

            // Label Treatment
            this.labelTreatment.AutoSize = true;
            this.labelTreatment.Location = new Point(30, 70);
            this.labelTreatment.Text = "Treatment:";

            // Label Cost
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new Point(30, 110);
            this.labelCost.Text = "Cost:";

            // Label Medicines
            this.labelMedicines.AutoSize = true;
            this.labelMedicines.Location = new Point(30, 150);
            this.labelMedicines.Text = "Medicines:";

            // Label Quantity
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new Point(30, 190);
            this.labelQuantity.Text = "Quantity:";

            // ComboBox Patient
            this.comboBoxPatient.Location = new Point(120, 27);
            this.comboBoxPatient.Size = new Size(200, 23);

            // ComboBox Treatment
            this.comboBoxTreatment.Location = new Point(120, 67);
            this.comboBoxTreatment.Size = new Size(200, 23);

            // TextBox Cost
            this.textBoxCost.Location = new Point(120, 107);
            this.textBoxCost.Size = new Size(200, 23);
            this.textBoxCost.ReadOnly = true;

            // TextBox Medicines
            this.textBoxMedicines.Location = new Point(120, 147);
            this.textBoxMedicines.Size = new Size(200, 23);

            // TextBox Quantity
            this.textBoxQuantity.Location = new Point(120, 187);
            this.textBoxQuantity.Size = new Size(200, 23);

            // Button Save
            this.buttonSave.BackColor = Color.Green;
            this.buttonSave.ForeColor = Color.White;
            this.buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.buttonSave.Location = new Point(120, 230);
            this.buttonSave.Size = new Size(80, 35);
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);

            // Button Cancel
            this.buttonCancel.BackColor = Color.Red;
            this.buttonCancel.ForeColor = Color.White;
            this.buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.buttonCancel.Location = new Point(210, 230);
            this.buttonCancel.Size = new Size(80, 35);
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);

            // FormAddPrescription
            this.ClientSize = new Size(380, 300);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.labelTreatment);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelMedicines);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.comboBoxTreatment);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxMedicines);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormAddPrescription";
            this.Text = "Add Prescription";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelPatient;
        private Label labelTreatment;
        private Label labelCost;
        private Label labelMedicines;
        private Label labelQuantity;

        private ComboBox comboBoxPatient;
        private ComboBox comboBoxTreatment;
        private TextBox textBoxCost;
        private TextBox textBoxMedicines;
        private TextBox textBoxQuantity;

        private Button buttonSave;
        private Button buttonCancel;
    }
}
