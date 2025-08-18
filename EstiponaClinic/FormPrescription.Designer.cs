namespace EstiponaClinic
{
    partial class FormPrescription
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
            dataGridViewPrescription = new DataGridView();
            buttonPrescriptionAdd = new Button();
            buttonPrescriptionEdit = new Button();
            buttonPrescriptionDelete = new Button();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrescription).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPrescription
            // 
            dataGridViewPrescription.AllowUserToAddRows = false;
            dataGridViewPrescription.AllowUserToDeleteRows = false;
            dataGridViewPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrescription.Location = new Point(30, 142);
            dataGridViewPrescription.Name = "dataGridViewPrescription";
            dataGridViewPrescription.ReadOnly = true;
            dataGridViewPrescription.Size = new Size(740, 598);
            dataGridViewPrescription.TabIndex = 0;
            // 
            // buttonPrescriptionAdd
            // 
            buttonPrescriptionAdd.BackColor = Color.Green;
            buttonPrescriptionAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionAdd.ForeColor = Color.White;
            buttonPrescriptionAdd.Location = new Point(29, 81);
            buttonPrescriptionAdd.Name = "buttonPrescriptionAdd";
            buttonPrescriptionAdd.Size = new Size(80, 35);
            buttonPrescriptionAdd.TabIndex = 1;
            buttonPrescriptionAdd.Text = "Add";
            buttonPrescriptionAdd.UseVisualStyleBackColor = false;
            // 
            // buttonPrescriptionEdit
            // 
            buttonPrescriptionEdit.BackColor = Color.Green;
            buttonPrescriptionEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionEdit.ForeColor = Color.White;
            buttonPrescriptionEdit.Location = new Point(115, 81);
            buttonPrescriptionEdit.Name = "buttonPrescriptionEdit";
            buttonPrescriptionEdit.Size = new Size(80, 35);
            buttonPrescriptionEdit.TabIndex = 2;
            buttonPrescriptionEdit.Text = "Edit";
            buttonPrescriptionEdit.UseVisualStyleBackColor = false;
            // 
            // buttonPrescriptionDelete
            // 
            buttonPrescriptionDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonPrescriptionDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrescriptionDelete.ForeColor = Color.White;
            buttonPrescriptionDelete.Location = new Point(201, 81);
            buttonPrescriptionDelete.Name = "buttonPrescriptionDelete";
            buttonPrescriptionDelete.Size = new Size(80, 35);
            buttonPrescriptionDelete.TabIndex = 3;
            buttonPrescriptionDelete.Text = "Delete";
            buttonPrescriptionDelete.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(172, 37);
            labelTitle.TabIndex = 20;
            labelTitle.Text = "Prescription";
            // 
            // FormPrescription
            // 
            ClientSize = new Size(800, 760);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewPrescription);
            Controls.Add(buttonPrescriptionAdd);
            Controls.Add(buttonPrescriptionEdit);
            Controls.Add(buttonPrescriptionDelete);
            Name = "FormPrescription";
            Text = "Prescription";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrescription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPrescription;
        private Button buttonPrescriptionAdd;
        private Button buttonPrescriptionEdit;
        private Button buttonPrescriptionDelete;
        private Label labelTitle;
    }
}
