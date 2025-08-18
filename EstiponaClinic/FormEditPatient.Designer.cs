namespace EstiponaClinic
{
    partial class FormEditPatient
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
            this.label1 = new Label();
            this.textBoxPatientsFullName = new TextBox();
            this.label2 = new Label();
            this.textBoxPatientsPhoneNumber = new TextBox();
            this.label3 = new Label();
            this.textBoxPatientsAddress = new TextBox();
            this.label4 = new Label();
            this.dateTimePickerBirthDate = new DateTimePicker();
            this.label5 = new Label();
            this.comboBoxPatientsGender = new ComboBox();
            this.label6 = new Label();
            this.textBoxPatientsAllergies = new TextBox();
            this.buttonUpdate = new Button();
            this.buttonCancel = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "Full Name:";
            this.label1.Location = new Point(20, 20);
            // 
            // textBoxPatientsFullName
            // 
            this.textBoxPatientsFullName.Location = new Point(150, 20);
            this.textBoxPatientsFullName.Width = 200;
            // 
            // label2
            // 
            this.label2.Text = "Phone Number:";
            this.label2.Location = new Point(20, 60);
            // 
            // textBoxPatientsPhoneNumber
            // 
            this.textBoxPatientsPhoneNumber.Location = new Point(150, 60);
            this.textBoxPatientsPhoneNumber.Width = 200;
            // 
            // label3
            // 
            this.label3.Text = "Address:";
            this.label3.Location = new Point(20, 100);
            // 
            // textBoxPatientsAddress
            // 
            this.textBoxPatientsAddress.Location = new Point(150, 100);
            this.textBoxPatientsAddress.Width = 200;
            // 
            // label4
            // 
            this.label4.Text = "Date of Birth:";
            this.label4.Location = new Point(20, 140);
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new Point(150, 140);
            this.dateTimePickerBirthDate.Width = 200;
            // 
            // label5
            // 
            this.label5.Text = "Gender:";
            this.label5.Location = new Point(20, 180);
            // 
            // comboBoxPatientsGender
            // 
            this.comboBoxPatientsGender.Location = new Point(150, 180);
            this.comboBoxPatientsGender.Width = 200;
            // 
            // label6
            // 
            this.label6.Text = "Allergies:";
            this.label6.Location = new Point(20, 220);
            // 
            // textBoxPatientsAllergies
            // 
            this.textBoxPatientsAllergies.Location = new Point(150, 220);
            this.textBoxPatientsAllergies.Width = 200;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Location = new Point(50, 270);
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Location = new Point(200, 270);
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
            // 
            // FormEditPatient
            // 
            this.ClientSize = new Size(400, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatientsFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPatientsPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPatientsAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPatientsGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPatientsAllergies);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCancel);
            this.Text = "Edit Patient";
            this.ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxPatientsFullName;
        private Label label2;
        private TextBox textBoxPatientsPhoneNumber;
        private Label label3;
        private TextBox textBoxPatientsAddress;
        private Label label4;
        private DateTimePicker dateTimePickerBirthDate;
        private Label label5;
        private ComboBox comboBoxPatientsGender;
        private Label label6;
        private TextBox textBoxPatientsAllergies;
        private Button buttonUpdate;
        private Button buttonCancel;
    }
}
