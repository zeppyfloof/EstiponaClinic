namespace EstiponaClinic
{
    partial class FormAppointment
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
            buttonAppointmentsAdd = new Button();
            buttonAppointmentsEdit = new Button();
            buttonAppointmentsDelete = new Button();
            dataGridViewAppointments = new DataGridView();
            labelTitle = new Label();
            label7 = new Label();
            textBoxAppointmentsSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // buttonAppointmentsAdd
            // 
            buttonAppointmentsAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAppointmentsAdd.BackColor = Color.Green;
            buttonAppointmentsAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentsAdd.ForeColor = Color.White;
            buttonAppointmentsAdd.Location = new Point(520, 116);
            buttonAppointmentsAdd.Name = "buttonAppointmentsAdd";
            buttonAppointmentsAdd.Size = new Size(116, 54);
            buttonAppointmentsAdd.TabIndex = 0;
            buttonAppointmentsAdd.Text = "Add";
            buttonAppointmentsAdd.UseVisualStyleBackColor = false;
            // 
            // buttonAppointmentsEdit
            // 
            buttonAppointmentsEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAppointmentsEdit.BackColor = Color.Green;
            buttonAppointmentsEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentsEdit.ForeColor = Color.White;
            buttonAppointmentsEdit.Location = new Point(642, 116);
            buttonAppointmentsEdit.Name = "buttonAppointmentsEdit";
            buttonAppointmentsEdit.Size = new Size(116, 54);
            buttonAppointmentsEdit.TabIndex = 1;
            buttonAppointmentsEdit.Text = "Edit";
            buttonAppointmentsEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAppointmentsDelete
            // 
            buttonAppointmentsDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAppointmentsDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonAppointmentsDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentsDelete.ForeColor = Color.White;
            buttonAppointmentsDelete.Location = new Point(764, 116);
            buttonAppointmentsDelete.Name = "buttonAppointmentsDelete";
            buttonAppointmentsDelete.Size = new Size(116, 54);
            buttonAppointmentsDelete.TabIndex = 2;
            buttonAppointmentsDelete.Text = "Delete";
            buttonAppointmentsDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointments.BackgroundColor = Color.Azure;
            dataGridViewAppointments.ColumnHeadersHeight = 29;
            dataGridViewAppointments.Location = new Point(34, 189);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewAppointments.RowHeadersWidth = 51;
            dataGridViewAppointments.RowTemplate.Height = 25;
            dataGridViewAppointments.Size = new Size(846, 797);
            dataGridViewAppointments.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Green;
            labelTitle.Location = new Point(23, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(293, 54);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Appointments";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(34, 94);
            label7.Name = "label7";
            label7.Size = new Size(89, 32);
            label7.TabIndex = 20;
            label7.Text = "Search";
            // 
            // textBoxAppointmentsSearch
            // 
            textBoxAppointmentsSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAppointmentsSearch.Location = new Point(34, 131);
            textBoxAppointmentsSearch.Name = "textBoxAppointmentsSearch";
            textBoxAppointmentsSearch.Size = new Size(371, 39);
            textBoxAppointmentsSearch.TabIndex = 17;
            // 
            // FormAppointment
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(914, 1013);
            Controls.Add(label7);
            Controls.Add(textBoxAppointmentsSearch);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(buttonAppointmentsDelete);
            Controls.Add(buttonAppointmentsEdit);
            Controls.Add(buttonAppointmentsAdd);
            Name = "FormAppointment";
            Text = "Appointments";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAppointmentsAdd;
        private Button buttonAppointmentsEdit;
        private Button buttonAppointmentsDelete;
        private DataGridView dataGridViewAppointments;
        private Label labelTitle;
        private Label label7;
        private TextBox textBoxAppointmentsSearch;
    }
}
