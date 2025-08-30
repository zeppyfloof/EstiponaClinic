namespace EstiponaClinic
{
    partial class FormAddTreatment
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
            labelName = new Label();
            labelDescription = new Label();
            labelCost = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxCost = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.Green;
            labelName.Location = new Point(95, 27);
            labelName.Name = "labelName";
            labelName.Size = new Size(92, 37);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelDescription
            // 
            labelDescription.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescription.ForeColor = Color.Green;
            labelDescription.Location = new Point(30, 89);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(157, 37);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Description:";
            // 
            // labelCost
            // 
            labelCost.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelCost.ForeColor = Color.Green;
            labelCost.Location = new Point(111, 206);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(76, 37);
            labelCost.TabIndex = 2;
            labelCost.Text = "Cost:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(210, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(282, 39);
            textBoxName.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(210, 86);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(282, 98);
            textBoxDescription.TabIndex = 4;
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = SystemColors.ControlLight;
            textBoxCost.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCost.Location = new Point(210, 206);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(282, 39);
            textBoxCost.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Green;
            buttonSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(83, 278);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(137, 59);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(342, 278);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(137, 59);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormAddTreatment
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(558, 365);
            Controls.Add(labelName);
            Controls.Add(labelDescription);
            Controls.Add(labelCost);
            Controls.Add(textBoxName);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxCost);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddTreatment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Treatment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
