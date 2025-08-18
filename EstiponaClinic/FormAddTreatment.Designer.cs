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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();

            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();

            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // Labels
            // 
            this.labelName.Location = new System.Drawing.Point(30, 30);
            this.labelName.Text = "Name:";
            this.labelDescription.Location = new System.Drawing.Point(30, 70);
            this.labelDescription.Text = "Description:";
            this.labelCost.Location = new System.Drawing.Point(30, 110);
            this.labelCost.Text = "Cost:";
            // 
            // Textboxes
            // 
            this.textBoxName.Location = new System.Drawing.Point(140, 27);
            this.textBoxName.Size = new System.Drawing.Size(200, 23);

            this.textBoxDescription.Location = new System.Drawing.Point(140, 67);
            this.textBoxDescription.Size = new System.Drawing.Size(200, 23);

            this.textBoxCost.Location = new System.Drawing.Point(140, 107);
            this.textBoxCost.Size = new System.Drawing.Size(200, 23);
            // 
            // Buttons
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Green;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(140, 160);
            this.buttonSave.Size = new System.Drawing.Size(80, 35);
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.Location = new System.Drawing.Point(260, 160);
            this.buttonCancel.Size = new System.Drawing.Size(80, 35);
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddTreatment
            // 
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormAddTreatment";
            this.Text = "Add Treatment";
            this.ResumeLayout(false);
            this.PerformLayout();
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
