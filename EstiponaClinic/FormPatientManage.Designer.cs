namespace EstiponaClinic
{
    partial class FormPatientManage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// Clean up resources
        /// </summary>
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
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.textBoxAllergies = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Text = "Full Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 27);
            this.textBoxName.Width = 250;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(30, 70);
            this.lblNumber.Text = "Contact No.:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(150, 67);
            this.textBoxNumber.Width = 250;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(30, 110);
            this.lblAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(150, 107);
            this.textBoxAddress.Width = 250;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(30, 150);
            this.lblDOB.Text = "Date of Birth:";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(150, 147);
            this.dateTimePickerDOB.Width = 250;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(30, 190);
            this.lblGender.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Location = new System.Drawing.Point(150, 187);
            this.comboBoxGender.Width = 250;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(30, 230);
            this.lblAllergies.Text = "Allergies:";
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.Location = new System.Drawing.Point(150, 227);
            this.textBoxAllergies.Width = 250;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 280);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 280);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormPatientManage
            // 
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.lblAllergies);
            this.Controls.Add(this.textBoxAllergies);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormPatientManage";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Manage Patient";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
