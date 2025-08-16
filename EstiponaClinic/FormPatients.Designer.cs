namespace EstiponaClinic
{
    partial class FormPatients
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewPatients = new DataGridView();
            textBoxPatientsSearch = new TextBox();
            label8 = new Label();
            btnManage = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatients.ColumnHeadersHeight = 39;
            dataGridViewPatients.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPatients.Location = new Point(34, 179);
            dataGridViewPatients.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPatients.RowTemplate.Height = 25;
            dataGridViewPatients.Size = new Size(846, 807);
            dataGridViewPatients.TabIndex = 16;
            // 
            // textBoxPatientsSearch
            // 
            textBoxPatientsSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsSearch.Location = new Point(30, 90);
            textBoxPatientsSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientsSearch.Name = "textBoxPatientsSearch";
            textBoxPatientsSearch.Size = new Size(333, 39);
            textBoxPatientsSearch.TabIndex = 17;
            textBoxPatientsSearch.Text = "Search";
            textBoxPatientsSearch.TextChanged += textBoxPatientsSearch_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(21, 22);
            label8.Name = "label8";
            label8.Size = new Size(148, 46);
            label8.TabIndex = 19;
            label8.Text = "Patients";
            // 
            // btnManage
            // 
            btnManage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManage.BackColor = Color.Green;
            btnManage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnManage.ForeColor = SystemColors.Control;
            btnManage.Location = new Point(742, 83);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(138, 53);
            btnManage.TabIndex = 20;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // FormPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(914, 1013);
            Controls.Add(btnManage);
            Controls.Add(label8);
            Controls.Add(textBoxPatientsSearch);
            Controls.Add(dataGridViewPatients);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPatients";
            Text = "Patient Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewPatients;
        private TextBox textBoxPatientsSearch;
        private Label label8;
        private Button btnManage;
    }
}