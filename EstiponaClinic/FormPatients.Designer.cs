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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttonPatientsSave = new Button();
            buttonPatientsEdit = new Button();
            buttonPatientsDelete = new Button();
            dataGridViewPatients = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            textBoxPatientsSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // buttonPatientsSave
            // 
            buttonPatientsSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPatientsSave.BackColor = Color.Green;
            buttonPatientsSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsSave.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsSave.Location = new Point(520, 116);
            buttonPatientsSave.Margin = new Padding(3, 4, 3, 4);
            buttonPatientsSave.Name = "buttonPatientsSave";
            buttonPatientsSave.Size = new Size(116, 54);
            buttonPatientsSave.TabIndex = 13;
            buttonPatientsSave.Text = "Add";
            buttonPatientsSave.UseVisualStyleBackColor = false;
            // 
            // buttonPatientsEdit
            // 
            buttonPatientsEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPatientsEdit.BackColor = Color.Green;
            buttonPatientsEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsEdit.Location = new Point(642, 116);
            buttonPatientsEdit.Margin = new Padding(3, 4, 3, 4);
            buttonPatientsEdit.Name = "buttonPatientsEdit";
            buttonPatientsEdit.Size = new Size(116, 54);
            buttonPatientsEdit.TabIndex = 14;
            buttonPatientsEdit.Text = "Edit";
            buttonPatientsEdit.UseVisualStyleBackColor = false;
            // 
            // buttonPatientsDelete
            // 
            buttonPatientsDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPatientsDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonPatientsDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsDelete.Location = new Point(764, 116);
            buttonPatientsDelete.Margin = new Padding(3, 4, 3, 4);
            buttonPatientsDelete.Name = "buttonPatientsDelete";
            buttonPatientsDelete.Size = new Size(116, 54);
            buttonPatientsDelete.TabIndex = 15;
            buttonPatientsDelete.Text = "Delete";
            buttonPatientsDelete.UseVisualStyleBackColor = false;
            buttonPatientsDelete.Click += buttonPatientsDelete_Click;
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatients.BackgroundColor = Color.Azure;
            dataGridViewPatients.ColumnHeadersHeight = 29;
            dataGridViewPatients.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPatients.Location = new Point(34, 189);
            dataGridViewPatients.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.RowHeadersWidth = 51;
            dataGridViewPatients.RowTemplate.Height = 25;
            dataGridViewPatients.Size = new Size(846, 797);
            dataGridViewPatients.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(23, 29);
            label8.Name = "label8";
            label8.Size = new Size(176, 54);
            label8.TabIndex = 19;
            label8.Text = "Patients";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(34, 94);
            label7.Name = "label7";
            label7.Size = new Size(89, 32);
            label7.TabIndex = 18;
            label7.Text = "Search";
            // 
            // textBoxPatientsSearch
            // 
            textBoxPatientsSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientsSearch.Location = new Point(34, 131);
            textBoxPatientsSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientsSearch.Name = "textBoxPatientsSearch";
            textBoxPatientsSearch.Size = new Size(371, 39);
            textBoxPatientsSearch.TabIndex = 17;
            // 
            // FormPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(914, 1013);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxPatientsSearch);
            Controls.Add(dataGridViewPatients);
            Controls.Add(buttonPatientsDelete);
            Controls.Add(buttonPatientsEdit);
            Controls.Add(buttonPatientsSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPatients";
            Text = "Patient Management";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonPatientsSave;
        private Button buttonPatientsEdit;
        private Button buttonPatientsDelete;
        private DataGridView dataGridViewPatients;
        private Label label8;
        private Label label7;
        private TextBox textBoxPatientsSearch;
    }
}