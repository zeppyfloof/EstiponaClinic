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
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // buttonAppointmentsAdd
            // 
            buttonAppointmentsAdd.BackColor = Color.Green;
            buttonAppointmentsAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentsAdd.ForeColor = Color.White;
            buttonAppointmentsAdd.Location = new Point(30, 80);
            buttonAppointmentsAdd.Name = "buttonAppointmentsAdd";
            buttonAppointmentsAdd.Size = new Size(80, 35);
            buttonAppointmentsAdd.TabIndex = 0;
            buttonAppointmentsAdd.Text = "Add";
            buttonAppointmentsAdd.UseVisualStyleBackColor = false;
            // 
            // buttonAppointmentsEdit
            // 
            buttonAppointmentsEdit.BackColor = Color.Green;
            buttonAppointmentsEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentsEdit.ForeColor = Color.White;
            buttonAppointmentsEdit.Location = new Point(120, 80);
            buttonAppointmentsEdit.Name = "buttonAppointmentsEdit";
            buttonAppointmentsEdit.Size = new Size(80, 35);
            buttonAppointmentsEdit.TabIndex = 1;
            buttonAppointmentsEdit.Text = "Edit";
            buttonAppointmentsEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAppointmentsDelete
            // 
            buttonAppointmentsDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonAppointmentsDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentsDelete.ForeColor = Color.White;
            buttonAppointmentsDelete.Location = new Point(210, 80);
            buttonAppointmentsDelete.Name = "buttonAppointmentsDelete";
            buttonAppointmentsDelete.Size = new Size(80, 35);
            buttonAppointmentsDelete.TabIndex = 2;
            buttonAppointmentsDelete.Text = "Delete";
            buttonAppointmentsDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointments.Location = new Point(30, 140);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewAppointments.RowTemplate.Height = 25;
            dataGridViewAppointments.Size = new Size(740, 580);
            dataGridViewAppointments.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(201, 37);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Appointments";
            // 
            // FormAppointment
            // 
            ClientSize = new Size(800, 760);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(buttonAppointmentsDelete);
            Controls.Add(buttonAppointmentsEdit);
            Controls.Add(buttonAppointmentsAdd);
            Name = "FormAppointment";
            Text = "Appointments";
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
    }
}
