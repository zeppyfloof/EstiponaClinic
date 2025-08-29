namespace EstiponaClinic
{
    partial class FormEditTreatment
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
            labelName.Location = new Point(30, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(30, 70);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(100, 23);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Description:";
            // 
            // labelCost
            // 
            labelCost.Location = new Point(30, 110);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(100, 23);
            labelCost.TabIndex = 2;
            labelCost.Text = "Cost:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(140, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(140, 67);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 23);
            textBoxDescription.TabIndex = 4;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(140, 107);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(200, 23);
            textBoxCost.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkGreen;
            buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(140, 160);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(80, 35);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(260, 160);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(80, 35);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormEditTreatment
            // 
            ClientSize = new Size(400, 230);
            Controls.Add(labelName);
            Controls.Add(labelDescription);
            Controls.Add(labelCost);
            Controls.Add(textBoxName);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxCost);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Name = "FormEditTreatment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Treatment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelDescription;
        private Label labelCost;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxCost;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
