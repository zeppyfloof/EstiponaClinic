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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            buttonPatientsSave.BackColor = Color.Green;
            buttonPatientsSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsSave.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsSave.Location = new Point(29, 81);
            buttonPatientsSave.Name = "buttonPatientsSave";
            buttonPatientsSave.Size = new Size(80, 35);
            buttonPatientsSave.TabIndex = 13;
            buttonPatientsSave.Text = "Add";
            buttonPatientsSave.UseVisualStyleBackColor = false;
            // 
            // buttonPatientsEdit
            // 
            buttonPatientsEdit.BackColor = Color.Green;
            buttonPatientsEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsEdit.Location = new Point(115, 81);
            buttonPatientsEdit.Name = "buttonPatientsEdit";
            buttonPatientsEdit.Size = new Size(80, 35);
            buttonPatientsEdit.TabIndex = 14;
            buttonPatientsEdit.Text = "Edit";
            buttonPatientsEdit.UseVisualStyleBackColor = false;
            // 
            // buttonPatientsDelete
            // 
            buttonPatientsDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonPatientsDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsDelete.Location = new Point(201, 81);
            buttonPatientsDelete.Name = "buttonPatientsDelete";
            buttonPatientsDelete.Size = new Size(80, 35);
            buttonPatientsDelete.TabIndex = 15;
            buttonPatientsDelete.Text = "Delete";
            buttonPatientsDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatients.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewPatients.Location = new Point(30, 142);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.RowTemplate.Height = 25;
            dataGridViewPatients.Size = new Size(740, 598);
            dataGridViewPatients.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 20);
            label8.Name = "label8";
            label8.Size = new Size(121, 37);
            label8.TabIndex = 19;
            label8.Text = "Patients";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 70);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 18;
            label7.Text = "Search";
            // 
            // textBoxPatientsSearch
            // 
            textBoxPatientsSearch.Location = new Point(330, 90);
            textBoxPatientsSearch.Name = "textBoxPatientsSearch";
            textBoxPatientsSearch.Size = new Size(250, 23);
            textBoxPatientsSearch.TabIndex = 17;
            // 
            // FormPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 760);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxPatientsSearch);
            Controls.Add(dataGridViewPatients);
            Controls.Add(buttonPatientsDelete);
            Controls.Add(buttonPatientsEdit);
            Controls.Add(buttonPatientsSave);
            Name = "FormPatients";
            Text = "Patient Management";
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