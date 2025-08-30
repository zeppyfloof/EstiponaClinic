namespace EstiponaClinic
{
    partial class FormMedicalHistory
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
            dataGridViewMedicalHistory = new DataGridView();
            labelTitle = new Label();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicalHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMedicalHistory
            // 
            dataGridViewMedicalHistory.AllowUserToAddRows = false;
            dataGridViewMedicalHistory.AllowUserToDeleteRows = false;
            dataGridViewMedicalHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMedicalHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicalHistory.BackgroundColor = Color.Azure;
            dataGridViewMedicalHistory.ColumnHeadersHeight = 29;
            dataGridViewMedicalHistory.Location = new Point(34, 189);
            dataGridViewMedicalHistory.MultiSelect = false;
            dataGridViewMedicalHistory.Name = "dataGridViewMedicalHistory";
            dataGridViewMedicalHistory.ReadOnly = true;
            dataGridViewMedicalHistory.RowHeadersWidth = 51;
            dataGridViewMedicalHistory.RowTemplate.Height = 25;
            dataGridViewMedicalHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMedicalHistory.Size = new Size(846, 797);
            dataGridViewMedicalHistory.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Green;
            labelTitle.Location = new Point(23, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(322, 54);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Medical History";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.ForeColor = Color.Green;
            labelSearch.Location = new Point(34, 94);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(89, 32);
            labelSearch.TabIndex = 4;
            labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(34, 131);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(371, 39);
            textBoxSearch.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.BackColor = Color.Green;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(520, 116);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(116, 54);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(764, 116);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(116, 54);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.BackColor = Color.Green;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(642, 116);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(116, 54);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // FormMedicalHistory
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(914, 1013);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewMedicalHistory);
            Name = "FormMedicalHistory";
            Text = "Medical History Management";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicalHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DataGridView dataGridViewMedicalHistory;
        private Label labelTitle;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}
