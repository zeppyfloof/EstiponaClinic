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
            label7 = new Label();
            textBoxTreatmentSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTreatment
            // 
            dataGridViewTreatment.AllowUserToAddRows = false;
            dataGridViewTreatment.AllowUserToDeleteRows = false;
            dataGridViewTreatment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTreatment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTreatment.BackgroundColor = Color.Azure;
            dataGridViewTreatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTreatment.Location = new Point(34, 189);
            dataGridViewTreatment.Name = "dataGridViewTreatment";
            dataGridViewTreatment.ReadOnly = true;
            dataGridViewTreatment.RowHeadersWidth = 51;
            dataGridViewTreatment.Size = new Size(846, 797);
            dataGridViewTreatment.TabIndex = 0;
            // 
            // buttonTreatmentAdd
            // 
            buttonTreatmentAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTreatmentAdd.BackColor = Color.Green;
            buttonTreatmentAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentAdd.ForeColor = Color.White;
            buttonTreatmentAdd.Location = new Point(520, 116);
            buttonTreatmentAdd.Name = "buttonTreatmentAdd";
            buttonTreatmentAdd.Size = new Size(116, 54);
            buttonTreatmentAdd.TabIndex = 1;
            buttonTreatmentAdd.Text = "Add";
            buttonTreatmentAdd.UseVisualStyleBackColor = false;
            // 
            // buttonTreatmentEdit
            // 
            buttonTreatmentEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTreatmentEdit.BackColor = Color.Green;
            buttonTreatmentEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentEdit.ForeColor = Color.White;
            buttonTreatmentEdit.Location = new Point(642, 116);
            buttonTreatmentEdit.Name = "buttonTreatmentEdit";
            buttonTreatmentEdit.Size = new Size(116, 54);
            buttonTreatmentEdit.TabIndex = 2;
            buttonTreatmentEdit.Text = "Edit";
            buttonTreatmentEdit.UseVisualStyleBackColor = false;
            // 
            // buttonTreatmentDelete
            // 
            buttonTreatmentDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTreatmentDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonTreatmentDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentDelete.ForeColor = Color.White;
            buttonTreatmentDelete.Location = new Point(764, 116);
            buttonTreatmentDelete.Name = "buttonTreatmentDelete";
            buttonTreatmentDelete.Size = new Size(116, 54);
            buttonTreatmentDelete.TabIndex = 3;
            buttonTreatmentDelete.Text = "Delete";
            buttonTreatmentDelete.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(23, 29);
            label8.Name = "label8";
            label8.Size = new Size(218, 54);
            label8.TabIndex = 20;
            label8.Text = "Treatment";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(34, 94);
            label7.Name = "label7";
            label7.Size = new Size(89, 32);
            label7.TabIndex = 22;
            label7.Text = "Search";
            // 
            // textBoxTreatmentSearch
            // 
            textBoxTreatmentSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTreatmentSearch.Location = new Point(34, 131);
            textBoxTreatmentSearch.Name = "textBoxTreatmentSearch";
            textBoxTreatmentSearch.Size = new Size(371, 39);
            textBoxTreatmentSearch.TabIndex = 17;
            // 
            // FormTreatment
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(914, 1013);
            Controls.Add(label7);
            Controls.Add(textBoxTreatmentSearch);
            Controls.Add(label8);
            Controls.Add(dataGridViewTreatment);
            Controls.Add(buttonTreatmentAdd);
            Controls.Add(buttonTreatmentEdit);
            Controls.Add(buttonTreatmentDelete);
            Name = "FormTreatment";
            Text = "Treatment";
            WindowState = FormWindowState.Maximized;
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
        private Label label7;
        private TextBox textBoxTreatmentSearch;
    }
}
