namespace EstiponaClinic
{
    partial class FormTreatment
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
            dataGridViewTreatment = new DataGridView();
            buttonTreatmentAdd = new Button();
            buttonTreatmentEdit = new Button();
            buttonTreatmentDelete = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTreatment
            // 
            dataGridViewTreatment.AllowUserToAddRows = false;
            dataGridViewTreatment.AllowUserToDeleteRows = false;
            dataGridViewTreatment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTreatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTreatment.Location = new Point(30, 142);
            dataGridViewTreatment.Name = "dataGridViewTreatment";
            dataGridViewTreatment.ReadOnly = true;
            dataGridViewTreatment.Size = new Size(740, 598);
            dataGridViewTreatment.TabIndex = 0;
            // 
            // buttonTreatmentAdd
            // 
            buttonTreatmentAdd.BackColor = Color.Green;
            buttonTreatmentAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentAdd.ForeColor = Color.White;
            buttonTreatmentAdd.Location = new Point(29, 81);
            buttonTreatmentAdd.Name = "buttonTreatmentAdd";
            buttonTreatmentAdd.Size = new Size(80, 35);
            buttonTreatmentAdd.TabIndex = 1;
            buttonTreatmentAdd.Text = "Add";
            buttonTreatmentAdd.UseVisualStyleBackColor = false;
            // 
            // buttonTreatmentEdit
            // 
            buttonTreatmentEdit.BackColor = Color.Green;
            buttonTreatmentEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentEdit.ForeColor = Color.White;
            buttonTreatmentEdit.Location = new Point(115, 81);
            buttonTreatmentEdit.Name = "buttonTreatmentEdit";
            buttonTreatmentEdit.Size = new Size(80, 35);
            buttonTreatmentEdit.TabIndex = 2;
            buttonTreatmentEdit.Text = "Edit";
            buttonTreatmentEdit.UseVisualStyleBackColor = false;
            // 
            // buttonTreatmentDelete
            // 
            buttonTreatmentDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonTreatmentDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentDelete.ForeColor = Color.White;
            buttonTreatmentDelete.Location = new Point(201, 81);
            buttonTreatmentDelete.Name = "buttonTreatmentDelete";
            buttonTreatmentDelete.Size = new Size(80, 35);
            buttonTreatmentDelete.TabIndex = 3;
            buttonTreatmentDelete.Text = "Delete";
            buttonTreatmentDelete.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 20);
            label8.Name = "label8";
            label8.Size = new Size(150, 37);
            label8.TabIndex = 20;
            label8.Text = "Treatment";
            // 
            // FormTreatment
            // 
            ClientSize = new Size(800, 760);
            Controls.Add(label8);
            Controls.Add(dataGridViewTreatment);
            Controls.Add(buttonTreatmentAdd);
            Controls.Add(buttonTreatmentEdit);
            Controls.Add(buttonTreatmentDelete);
            Name = "FormTreatment";
            Text = "Treatment";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTreatment;
        private Button buttonTreatmentAdd;
        private Button buttonTreatmentEdit;
        private Button buttonTreatmentDelete;
        private Label label8;
    }
}
