namespace EstiponaClinic
{
    partial class FormDentalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewDental = new DataGridView();
            labelTitle = new Label();
            labelSearch = new Label();
            textBoxDentalSearch = new TextBox();
            panelTeethChart = new Panel();
            labelLegend = new Label();
            panelPatientInfo = new Panel();
            dateTimePickerDateRecorded = new DateTimePicker();
            labelCondition = new Label();
            textBoxCondition = new TextBox();
            labelDateRecorded = new Label();
            labelAllergies = new Label();
            textBoxAllergies = new TextBox();
            labelAbnormalities = new Label();
            textBoxAbnormalities = new TextBox();
            labelBloodPressure = new Label();
            textBoxBloodPressure = new TextBox();
            labelDrugsTaken = new Label();
            textBoxDrugsTaken = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            labelAge = new Label();
            textBoxAge = new TextBox();
            labelGender = new Label();
            textBoxGender = new TextBox();
            labelContact = new Label();
            textBoxPhone = new TextBox();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            labelNotes = new Label();
            textBoxNotes = new TextBox();
            buttonTeethChartEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDental).BeginInit();
            panelPatientInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDental
            // 
            dataGridViewDental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDental.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewDental.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDental.Location = new Point(30, 552);
            dataGridViewDental.Name = "dataGridViewDental";
            dataGridViewDental.ReadOnly = true;
            dataGridViewDental.RowTemplate.Height = 25;
            dataGridViewDental.Size = new Size(740, 188);
            dataGridViewDental.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(211, 37);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Dental Records";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(30, 493);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 5;
            labelSearch.Text = "Search";
            // 
            // textBoxDentalSearch
            // 
            textBoxDentalSearch.Location = new Point(30, 513);
            textBoxDentalSearch.Name = "textBoxDentalSearch";
            textBoxDentalSearch.Size = new Size(250, 23);
            textBoxDentalSearch.TabIndex = 6;
            // 
            // panelTeethChart
            // 
            panelTeethChart.BorderStyle = BorderStyle.FixedSingle;
            panelTeethChart.Location = new Point(30, 310);
            panelTeethChart.Name = "panelTeethChart";
            panelTeethChart.Size = new Size(740, 130);
            panelTeethChart.TabIndex = 7;
            // 
            // labelLegend
            // 
            labelLegend.AutoSize = true;
            labelLegend.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLegend.Location = new Point(30, 450);
            labelLegend.Name = "labelLegend";
            labelLegend.Size = new Size(429, 30);
            labelLegend.TabIndex = 3;
            labelLegend.Text = "Legend:\nHealthy = Green,   To be Completed = Red,   Completed = Blue   Black = Missing";
            // 
            // panelPatientInfo
            // 
            panelPatientInfo.BorderStyle = BorderStyle.FixedSingle;
            panelPatientInfo.Controls.Add(dateTimePickerDateRecorded);
            panelPatientInfo.Controls.Add(labelCondition);
            panelPatientInfo.Controls.Add(textBoxCondition);
            panelPatientInfo.Controls.Add(labelDateRecorded);
            panelPatientInfo.Controls.Add(labelAllergies);
            panelPatientInfo.Controls.Add(textBoxAllergies);
            panelPatientInfo.Controls.Add(labelAbnormalities);
            panelPatientInfo.Controls.Add(textBoxAbnormalities);
            panelPatientInfo.Controls.Add(labelBloodPressure);
            panelPatientInfo.Controls.Add(textBoxBloodPressure);
            panelPatientInfo.Controls.Add(labelDrugsTaken);
            panelPatientInfo.Controls.Add(textBoxDrugsTaken);
            panelPatientInfo.Controls.Add(labelName);
            panelPatientInfo.Controls.Add(textBoxName);
            panelPatientInfo.Controls.Add(labelAge);
            panelPatientInfo.Controls.Add(textBoxAge);
            panelPatientInfo.Controls.Add(labelGender);
            panelPatientInfo.Controls.Add(textBoxGender);
            panelPatientInfo.Controls.Add(labelContact);
            panelPatientInfo.Controls.Add(textBoxPhone);
            panelPatientInfo.Controls.Add(labelAddress);
            panelPatientInfo.Controls.Add(textBoxAddress);
            panelPatientInfo.Controls.Add(labelNotes);
            panelPatientInfo.Controls.Add(textBoxNotes);
            panelPatientInfo.Location = new Point(30, 60);
            panelPatientInfo.Name = "panelPatientInfo";
            panelPatientInfo.Size = new Size(740, 235);
            panelPatientInfo.TabIndex = 9;
            // 
            // dateTimePickerDateRecorded
            // 
            dateTimePickerDateRecorded.Enabled = false;
            dateTimePickerDateRecorded.Format = DateTimePickerFormat.Short;
            dateTimePickerDateRecorded.Location = new Point(390, 94);
            dateTimePickerDateRecorded.Name = "dateTimePickerDateRecorded";
            dateTimePickerDateRecorded.Size = new Size(120, 23);
            dateTimePickerDateRecorded.TabIndex = 5;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(14, 100);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(63, 15);
            labelCondition.TabIndex = 12;
            labelCondition.Text = "Condition:";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(100, 97);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(180, 23);
            textBoxCondition.TabIndex = 13;
            // 
            // labelDateRecorded
            // 
            labelDateRecorded.AutoSize = true;
            labelDateRecorded.Location = new Point(300, 100);
            labelDateRecorded.Name = "labelDateRecorded";
            labelDateRecorded.Size = new Size(87, 15);
            labelDateRecorded.TabIndex = 14;
            labelDateRecorded.Text = "Date Recorded:";
            // 
            // labelAllergies
            // 
            labelAllergies.AutoSize = true;
            labelAllergies.Location = new Point(520, 100);
            labelAllergies.Name = "labelAllergies";
            labelAllergies.Size = new Size(55, 15);
            labelAllergies.TabIndex = 16;
            labelAllergies.Text = "Allergies:";
            // 
            // textBoxAllergies
            // 
            textBoxAllergies.Location = new Point(600, 97);
            textBoxAllergies.Name = "textBoxAllergies";
            textBoxAllergies.ReadOnly = true;
            textBoxAllergies.Size = new Size(120, 23);
            textBoxAllergies.TabIndex = 17;
            // 
            // labelAbnormalities
            // 
            labelAbnormalities.AutoSize = true;
            labelAbnormalities.Location = new Point(14, 135);
            labelAbnormalities.Name = "labelAbnormalities";
            labelAbnormalities.Size = new Size(84, 15);
            labelAbnormalities.TabIndex = 18;
            labelAbnormalities.Text = "Abnormalities:";
            // 
            // textBoxAbnormalities
            // 
            textBoxAbnormalities.Location = new Point(100, 132);
            textBoxAbnormalities.Name = "textBoxAbnormalities";
            textBoxAbnormalities.ReadOnly = true;
            textBoxAbnormalities.Size = new Size(180, 23);
            textBoxAbnormalities.TabIndex = 19;
            // 
            // labelBloodPressure
            // 
            labelBloodPressure.AutoSize = true;
            labelBloodPressure.Location = new Point(300, 135);
            labelBloodPressure.Name = "labelBloodPressure";
            labelBloodPressure.Size = new Size(88, 15);
            labelBloodPressure.TabIndex = 20;
            labelBloodPressure.Text = "Blood Pressure:";
            // 
            // textBoxBloodPressure
            // 
            textBoxBloodPressure.Location = new Point(390, 132);
            textBoxBloodPressure.Name = "textBoxBloodPressure";
            textBoxBloodPressure.ReadOnly = true;
            textBoxBloodPressure.Size = new Size(120, 23);
            textBoxBloodPressure.TabIndex = 21;
            // 
            // labelDrugsTaken
            // 
            labelDrugsTaken.AutoSize = true;
            labelDrugsTaken.Location = new Point(520, 135);
            labelDrugsTaken.Name = "labelDrugsTaken";
            labelDrugsTaken.Size = new Size(74, 15);
            labelDrugsTaken.TabIndex = 22;
            labelDrugsTaken.Text = "Drugs Taken:";
            // 
            // textBoxDrugsTaken
            // 
            textBoxDrugsTaken.Location = new Point(600, 132);
            textBoxDrugsTaken.Name = "textBoxDrugsTaken";
            textBoxDrugsTaken.ReadOnly = true;
            textBoxDrugsTaken.Size = new Size(120, 23);
            textBoxDrugsTaken.TabIndex = 23;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(14, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Full Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 17);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(320, 20);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(31, 15);
            labelAge.TabIndex = 2;
            labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(360, 17);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.ReadOnly = true;
            textBoxAge.Size = new Size(50, 23);
            textBoxAge.TabIndex = 3;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(430, 20);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(48, 15);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender:";
            // 
            // textBoxGender
            // 
            textBoxGender.Location = new Point(485, 17);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.ReadOnly = true;
            textBoxGender.Size = new Size(100, 23);
            textBoxGender.TabIndex = 5;
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Location = new Point(600, 20);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(52, 15);
            labelContact.TabIndex = 6;
            labelContact.Text = "Contact:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(660, 17);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(70, 23);
            textBoxPhone.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(14, 60);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(52, 15);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(100, 57);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(300, 23);
            textBoxAddress.TabIndex = 9;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(420, 60);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(41, 15);
            labelNotes.TabIndex = 10;
            labelNotes.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(470, 57);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ReadOnly = true;
            textBoxNotes.Size = new Size(260, 23);
            textBoxNotes.TabIndex = 11;
            // 
            // buttonTeethChartEdit
            // 
            buttonTeethChartEdit.BackColor = Color.Green;
            buttonTeethChartEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTeethChartEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonTeethChartEdit.Location = new Point(691, 450);
            buttonTeethChartEdit.Name = "buttonTeethChartEdit";
            buttonTeethChartEdit.Size = new Size(80, 35);
            buttonTeethChartEdit.TabIndex = 24;
            buttonTeethChartEdit.Text = "Edit";
            buttonTeethChartEdit.UseVisualStyleBackColor = false;
            buttonTeethChartEdit.Click += buttonTeethChartEdit_Click;
            // 
            // FormDentalRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 760);
            Controls.Add(buttonTeethChartEdit);
            Controls.Add(panelPatientInfo);
            Controls.Add(labelLegend);
            Controls.Add(panelTeethChart);
            Controls.Add(textBoxDentalSearch);
            Controls.Add(labelSearch);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewDental);
            Name = "FormDentalRecord";
            Text = "Dental Record Management";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDental).EndInit();
            panelPatientInfo.ResumeLayout(false);
            panelPatientInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDental;
        private Label labelTitle;
        private Label labelSearch;
        private TextBox textBoxDentalSearch;
        private Panel panelTeethChart;
        private Label labelLegend;
        private Panel panelPatientInfo;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelAge;
        private TextBox textBoxAge;
        private Label labelGender;
        private TextBox textBoxGender;
        private Label labelContact;
        private TextBox textBoxPhone;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelNotes;
        private TextBox textBoxNotes;
        private Label labelCondition;
        private TextBox textBoxCondition;
        private Label labelDateRecorded;
        private Label labelAllergies;
        private TextBox textBoxAllergies;
        private Label labelAbnormalities;
        private TextBox textBoxAbnormalities;
        private Label labelBloodPressure;
        private TextBox textBoxBloodPressure;
        private Label labelDrugsTaken;
        private TextBox textBoxDrugsTaken;
        private DateTimePicker dateTimePickerDateRecorded;
        private Button buttonTeethChartEdit;
    }
}
