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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBoxPatientsFullName = new TextBox();
            textBoxPatientsPhoneNumber = new TextBox();
            textBoxPatientsAddress = new TextBox();
            comboBoxPatientsGender = new ComboBox();
            dateTimePickerBirthDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxPatientsAllergies = new TextBox();
            buttonPatientsSave = new Button();
            buttonPatientsEdit = new Button();
            buttonPatientsDelete = new Button();
            dataGridViewPatients = new DataGridView();
            textBoxPatientsSearch = new TextBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // label8 (Title)
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 20);
            label8.Name = "label8";
            label8.Size = new Size(121, 37);
            label8.TabIndex = 19;
            label8.Text = "Patients";
            // 
            // label1 (Full Name)
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 5;
            label1.Text = "Full Name";
            // 
            // textBoxPatientsFullName
            // 
            textBoxPatientsFullName.Location = new Point(30, 90);
            textBoxPatientsFullName.Name = "textBoxPatientsFullName";
            textBoxPatientsFullName.Size = new Size(250, 23);
            textBoxPatientsFullName.TabIndex = 0;
            // 
            // label2 (Phone)
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Phone";
            // 
            // textBoxPatientsPhoneNumber
            // 
            textBoxPatientsPhoneNumber.Location = new Point(30, 140);
            textBoxPatientsPhoneNumber.Name = "textBoxPatientsPhoneNumber";
            textBoxPatientsPhoneNumber.Size = new Size(250, 23);
            textBoxPatientsPhoneNumber.TabIndex = 1;
            // 
            // label3 (Address)
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 170);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // textBoxPatientsAddress
            // 
            textBoxPatientsAddress.Location = new Point(30, 190);
            textBoxPatientsAddress.Name = "textBoxPatientsAddress";
            textBoxPatientsAddress.Size = new Size(250, 23);
            textBoxPatientsAddress.TabIndex = 2;
            // 
            // label4 (Date of Birth)
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 220);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Date of Birth";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(30, 240);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(250, 23);
            dateTimePickerBirthDate.TabIndex = 4;
            // 
            // label5 (Gender)
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 270);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // comboBoxPatientsGender
            // 
            comboBoxPatientsGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatientsGender.FormattingEnabled = true;
            comboBoxPatientsGender.Location = new Point(30, 290);
            comboBoxPatientsGender.Name = "comboBoxPatientsGender";
            comboBoxPatientsGender.Size = new Size(250, 23);
            comboBoxPatientsGender.TabIndex = 3;
            // 
            // label6 (Allergies)
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 320);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 11;
            label6.Text = "Allergies";
            // 
            // textBoxPatientsAllergies
            // 
            textBoxPatientsAllergies.Location = new Point(30, 340);
            textBoxPatientsAllergies.Name = "textBoxPatientsAllergies";
            textBoxPatientsAllergies.Multiline = true;
            textBoxPatientsAllergies.Size = new Size(250, 60);
            textBoxPatientsAllergies.TabIndex = 12;
            // 
            // buttonPatientsSave
            // 
            buttonPatientsSave.BackColor = Color.Green;
            buttonPatientsSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsSave.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsSave.Location = new Point(30, 410);
            buttonPatientsSave.Name = "buttonPatientsSave";
            buttonPatientsSave.Size = new Size(80, 35);
            buttonPatientsSave.TabIndex = 13;
            buttonPatientsSave.Text = "Save";
            buttonPatientsSave.UseVisualStyleBackColor = false;
            // 
            // buttonPatientsEdit
            // 
            buttonPatientsEdit.BackColor = Color.Green;
            buttonPatientsEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsEdit.Location = new Point(120, 410);
            buttonPatientsEdit.Name = "buttonPatientsEdit";
            buttonPatientsEdit.Size = new Size(80, 35);
            buttonPatientsEdit.TabIndex = 14;
            buttonPatientsEdit.Text = "Edit";
            buttonPatientsEdit.UseVisualStyleBackColor = false;
            // 
            // buttonPatientsDelete
            // 
            buttonPatientsDelete.BackColor = Color.Green;
            buttonPatientsDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPatientsDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonPatientsDelete.Location = new Point(210, 410);
            buttonPatientsDelete.Name = "buttonPatientsDelete";
            buttonPatientsDelete.Size = new Size(80, 35);
            buttonPatientsDelete.TabIndex = 15;
            buttonPatientsDelete.Text = "Delete";
            buttonPatientsDelete.UseVisualStyleBackColor = false;
            // 
            // label7 (Search)
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
            // dataGridViewPatients
            // 
            dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatients.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPatients.Location = new Point(30, 460);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.RowTemplate.Height = 25;
            dataGridViewPatients.Size = new Size(740, 280);
            dataGridViewPatients.TabIndex = 16;
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
            Controls.Add(textBoxPatientsAllergies);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(comboBoxPatientsGender);
            Controls.Add(textBoxPatientsAddress);
            Controls.Add(textBoxPatientsPhoneNumber);
            Controls.Add(textBoxPatientsFullName);
            Name = "FormPatients";
            // Updated the title to reflect the form's purpose
            Text = "Patient Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPatientsFullName;
        private TextBox textBoxPatientsPhoneNumber;
        private TextBox textBoxPatientsAddress;
        private ComboBox comboBoxPatientsGender;
        private DateTimePicker dateTimePickerBirthDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxPatientsAllergies;
        private Button buttonPatientsSave;
        private Button buttonPatientsEdit;
        private Button buttonPatientsDelete;
        private DataGridView dataGridViewPatients;
        private TextBox textBoxPatientsSearch;
        private Label label7;
        private Label label8;
    }
}