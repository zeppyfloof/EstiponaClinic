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
            buttonEdit = new Button();
            buttonDelete = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicalHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMedicalHistory
            // 
            dataGridViewMedicalHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicalHistory.Location = new Point(30, 150);
            dataGridViewMedicalHistory.Name = "dataGridViewMedicalHistory";
            dataGridViewMedicalHistory.ReadOnly = true;
            dataGridViewMedicalHistory.RowTemplate.Height = 25;
            dataGridViewMedicalHistory.Size = new Size(740, 550);
            dataGridViewMedicalHistory.TabIndex = 0;
            dataGridViewMedicalHistory.AllowUserToAddRows = false;
            dataGridViewMedicalHistory.AllowUserToDeleteRows = false;
            dataGridViewMedicalHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMedicalHistory.MultiSelect = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(222, 37);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Medical History";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(30, 71);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 4;
            labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(30, 104);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(250, 23);
            textBoxSearch.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Green;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(518, 78);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(80, 35);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Green;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(604, 78);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(80, 35);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(690, 78);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 35);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // FormMedicalHistory
            // 
            ClientSize = new Size(800, 760);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewMedicalHistory);
            Name = "FormMedicalHistory";
            Text = "Medical History Management";
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
        private Button buttonEdit;
        private Button buttonDelete;
    }
}
