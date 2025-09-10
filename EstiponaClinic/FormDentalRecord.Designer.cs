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
            dataGridViewDental.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDental.BackgroundColor = Color.Azure;
            dataGridViewDental.ColumnHeadersHeight = 29;
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
            dataGridViewDental.RowHeadersWidth = 51;
            dataGridViewDental.RowTemplate.Height = 25;
            dataGridViewDental.Size = new Size(1375, 220);
            dataGridViewDental.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Green;
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(246, 45);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Dental Records";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.ForeColor = Color.Green;
            labelSearch.Location = new Point(30, 497);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(55, 20);
            labelSearch.TabIndex = 5;
            labelSearch.Text = "Search";
            // 
            // textBoxDentalSearch
            // 
            textBoxDentalSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDentalSearch.Location = new Point(30, 519);
            textBoxDentalSearch.Name = "textBoxDentalSearch";
            textBoxDentalSearch.Size = new Size(250, 27);
            textBoxDentalSearch.TabIndex = 6;
            // 
            // panelTeethChart
            // 
            panelTeethChart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTeethChart.BorderStyle = BorderStyle.FixedSingle;
            panelTeethChart.Location = new Point(30, 247);
            panelTeethChart.Name = "panelTeethChart";
            panelTeethChart.Size = new Size(1374, 193);
            panelTeethChart.TabIndex = 7;
            // 
            // labelLegend
            // 
            labelLegend.AutoSize = true;
            labelLegend.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelLegend.ForeColor = Color.Green;
            labelLegend.Location = new Point(30, 450);
            labelLegend.Name = "labelLegend";
            labelLegend.Size = new Size(568, 40);
            labelLegend.TabIndex = 3;
            labelLegend.Text = "Legend:\nHealthy = Green,   To be Completed = Red,   Completed = Blue   Black = Missing";
            labelLegend.Click += labelLegend_Click;
            // 
            // panelPatientInfo
            // 
            panelPatientInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            panelPatientInfo.Size = new Size(1374, 172);
            panelPatientInfo.TabIndex = 9;
            // 
            // dateTimePickerDateRecorded
            // 
            dateTimePickerDateRecorded.Anchor = AnchorStyles.Top;
            dateTimePickerDateRecorded.Enabled = false;
            dateTimePickerDateRecorded.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateRecorded.Format = DateTimePickerFormat.Short;
            dateTimePickerDateRecorded.Location = new Point(692, 63);
            dateTimePickerDateRecorded.Name = "dateTimePickerDateRecorded";
            dateTimePickerDateRecorded.Size = new Size(205, 27);
            dateTimePickerDateRecorded.TabIndex = 5;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelCondition.ForeColor = Color.Green;
            labelCondition.Location = new Point(44, 100);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(81, 20);
            labelCondition.TabIndex = 12;
            labelCondition.Text = "Condition:";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCondition.Location = new Point(136, 98);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(383, 27);
            textBoxCondition.TabIndex = 13;
            // 
            // labelDateRecorded
            // 
            labelDateRecorded.Anchor = AnchorStyles.Top;
            labelDateRecorded.AutoSize = true;
            labelDateRecorded.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateRecorded.ForeColor = Color.Green;
            labelDateRecorded.Location = new Point(557, 68);
            labelDateRecorded.Name = "labelDateRecorded";
            labelDateRecorded.Size = new Size(116, 20);
            labelDateRecorded.TabIndex = 14;
            labelDateRecorded.Text = "Date Recorded:";
            // 
            // labelAllergies
            // 
            labelAllergies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAllergies.AutoSize = true;
            labelAllergies.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllergies.ForeColor = Color.Green;
            labelAllergies.Location = new Point(933, 98);
            labelAllergies.Name = "labelAllergies";
            labelAllergies.Size = new Size(74, 20);
            labelAllergies.TabIndex = 16;
            labelAllergies.Text = "Allergies:";
            // 
            // textBoxAllergies
            // 
            textBoxAllergies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAllergies.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAllergies.Location = new Point(1016, 93);
            textBoxAllergies.Name = "textBoxAllergies";
            textBoxAllergies.ReadOnly = true;
            textBoxAllergies.Size = new Size(344, 27);
            textBoxAllergies.TabIndex = 17;
            // 
            // labelAbnormalities
            // 
            labelAbnormalities.AutoSize = true;
            labelAbnormalities.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbnormalities.ForeColor = Color.Green;
            labelAbnormalities.Location = new Point(14, 135);
            labelAbnormalities.Name = "labelAbnormalities";
            labelAbnormalities.Size = new Size(112, 20);
            labelAbnormalities.TabIndex = 18;
            labelAbnormalities.Text = "Abnormalities:";
            // 
            // textBoxAbnormalities
            // 
            textBoxAbnormalities.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAbnormalities.Location = new Point(136, 135);
            textBoxAbnormalities.Name = "textBoxAbnormalities";
            textBoxAbnormalities.ReadOnly = true;
            textBoxAbnormalities.Size = new Size(383, 27);
            textBoxAbnormalities.TabIndex = 19;
            // 
            // labelBloodPressure
            // 
            labelBloodPressure.Anchor = AnchorStyles.Top;
            labelBloodPressure.AutoSize = true;
            labelBloodPressure.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelBloodPressure.ForeColor = Color.Green;
            labelBloodPressure.Location = new Point(555, 119);
            labelBloodPressure.Name = "labelBloodPressure";
            labelBloodPressure.Size = new Size(118, 20);
            labelBloodPressure.TabIndex = 20;
            labelBloodPressure.Text = "Blood Pressure:";
            // 
            // textBoxBloodPressure
            // 
            textBoxBloodPressure.Anchor = AnchorStyles.Top;
            textBoxBloodPressure.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBloodPressure.Location = new Point(692, 117);
            textBoxBloodPressure.Name = "textBoxBloodPressure";
            textBoxBloodPressure.ReadOnly = true;
            textBoxBloodPressure.Size = new Size(205, 27);
            textBoxBloodPressure.TabIndex = 21;
            // 
            // labelDrugsTaken
            // 
            labelDrugsTaken.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDrugsTaken.AutoSize = true;
            labelDrugsTaken.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelDrugsTaken.ForeColor = Color.Green;
            labelDrugsTaken.Location = new Point(902, 130);
            labelDrugsTaken.Name = "labelDrugsTaken";
            labelDrugsTaken.Size = new Size(100, 20);
            labelDrugsTaken.TabIndex = 22;
            labelDrugsTaken.Text = "Drugs Taken:";
            // 
            // textBoxDrugsTaken
            // 
            textBoxDrugsTaken.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxDrugsTaken.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDrugsTaken.Location = new Point(1016, 128);
            textBoxDrugsTaken.Name = "textBoxDrugsTaken";
            textBoxDrugsTaken.ReadOnly = true;
            textBoxDrugsTaken.Size = new Size(344, 27);
            textBoxDrugsTaken.TabIndex = 23;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.Green;
            labelName.Location = new Point(42, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Full Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(136, 15);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(383, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelAge
            // 
            labelAge.Anchor = AnchorStyles.Top;
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAge.ForeColor = Color.Green;
            labelAge.Location = new Point(557, 15);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(41, 20);
            labelAge.TabIndex = 2;
            labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            textBoxAge.Anchor = AnchorStyles.Top;
            textBoxAge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.Location = new Point(606, 13);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.ReadOnly = true;
            textBoxAge.Size = new Size(73, 27);
            textBoxAge.TabIndex = 3;
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Top;
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.ForeColor = Color.Green;
            labelGender.Location = new Point(695, 15);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(65, 20);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender:";
            // 
            // textBoxGender
            // 
            textBoxGender.Anchor = AnchorStyles.Top;
            textBoxGender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGender.Location = new Point(768, 12);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.ReadOnly = true;
            textBoxGender.Size = new Size(129, 27);
            textBoxGender.TabIndex = 5;
            // 
            // labelContact
            // 
            labelContact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelContact.ForeColor = Color.Green;
            labelContact.Location = new Point(940, 15);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(67, 20);
            labelContact.TabIndex = 6;
            labelContact.Text = "Contact:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(1016, 13);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(344, 27);
            textBoxPhone.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddress.ForeColor = Color.Green;
            labelAddress.Location = new Point(58, 59);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(70, 20);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(136, 57);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(383, 27);
            textBoxAddress.TabIndex = 9;
            // 
            // labelNotes
            // 
            labelNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelNotes.ForeColor = Color.Green;
            labelNotes.Location = new Point(954, 55);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(49, 20);
            labelNotes.TabIndex = 10;
            labelNotes.Text = "HMO:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNotes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNotes.Location = new Point(1016, 52);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ReadOnly = true;
            textBoxNotes.Size = new Size(345, 27);
            textBoxNotes.TabIndex = 11;
            // 
            // buttonTeethChartEdit
            // 
            buttonTeethChartEdit.BackColor = Color.Green;
            buttonTeethChartEdit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTeethChartEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonTeethChartEdit.Location = new Point(691, 450);
            buttonTeethChartEdit.Name = "buttonTeethChartEdit";
            buttonTeethChartEdit.Size = new Size(108, 38);
            buttonTeethChartEdit.TabIndex = 24;
            buttonTeethChartEdit.Text = "Edit";
            buttonTeethChartEdit.UseVisualStyleBackColor = false;
            buttonTeethChartEdit.Click += buttonTeethChartEdit_Click;
            // 
            // FormDentalRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1434, 791);
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
