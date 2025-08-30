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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDental.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDental.Location = new Point(34, 736);
            dataGridViewDental.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDental.Name = "dataGridViewDental";
            dataGridViewDental.ReadOnly = true;
            dataGridViewDental.RowHeadersWidth = 51;
            dataGridViewDental.RowTemplate.Height = 25;
            dataGridViewDental.Size = new Size(1571, 293);
            dataGridViewDental.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Green;
            labelTitle.Location = new Point(34, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(308, 54);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Dental Records";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.ForeColor = Color.Green;
            labelSearch.Location = new Point(34, 663);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(71, 25);
            labelSearch.TabIndex = 5;
            labelSearch.Text = "Search";
            // 
            // textBoxDentalSearch
            // 
            textBoxDentalSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDentalSearch.Location = new Point(34, 692);
            textBoxDentalSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxDentalSearch.Name = "textBoxDentalSearch";
            textBoxDentalSearch.Size = new Size(285, 32);
            textBoxDentalSearch.TabIndex = 6;
            // 
            // panelTeethChart
            // 
            panelTeethChart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTeethChart.BorderStyle = BorderStyle.FixedSingle;
            panelTeethChart.Location = new Point(34, 329);
            panelTeethChart.Margin = new Padding(3, 4, 3, 4);
            panelTeethChart.Name = "panelTeethChart";
            panelTeethChart.Size = new Size(1570, 257);
            panelTeethChart.TabIndex = 7;
            // 
            // labelLegend
            // 
            labelLegend.AutoSize = true;
            labelLegend.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelLegend.ForeColor = Color.Green;
            labelLegend.Location = new Point(34, 600);
            labelLegend.Name = "labelLegend";
            labelLegend.Size = new Size(716, 50);
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
            panelPatientInfo.Location = new Point(34, 80);
            panelPatientInfo.Margin = new Padding(3, 4, 3, 4);
            panelPatientInfo.Name = "panelPatientInfo";
            panelPatientInfo.Size = new Size(1570, 229);
            panelPatientInfo.TabIndex = 9;
            // 
            // dateTimePickerDateRecorded
            // 
            dateTimePickerDateRecorded.Anchor = AnchorStyles.Top;
            dateTimePickerDateRecorded.Enabled = false;
            dateTimePickerDateRecorded.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateRecorded.Format = DateTimePickerFormat.Short;
            dateTimePickerDateRecorded.Location = new Point(791, 84);
            dateTimePickerDateRecorded.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDateRecorded.Name = "dateTimePickerDateRecorded";
            dateTimePickerDateRecorded.Size = new Size(234, 32);
            dateTimePickerDateRecorded.TabIndex = 5;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelCondition.ForeColor = Color.Green;
            labelCondition.Location = new Point(50, 133);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(106, 25);
            labelCondition.TabIndex = 12;
            labelCondition.Text = "Condition:";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCondition.Location = new Point(155, 130);
            textBoxCondition.Margin = new Padding(3, 4, 3, 4);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(437, 32);
            textBoxCondition.TabIndex = 13;
            // 
            // labelDateRecorded
            // 
            labelDateRecorded.Anchor = AnchorStyles.Top;
            labelDateRecorded.AutoSize = true;
            labelDateRecorded.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateRecorded.ForeColor = Color.Green;
            labelDateRecorded.Location = new Point(637, 90);
            labelDateRecorded.Name = "labelDateRecorded";
            labelDateRecorded.Size = new Size(148, 25);
            labelDateRecorded.TabIndex = 14;
            labelDateRecorded.Text = "Date Recorded:";
            // 
            // labelAllergies
            // 
            labelAllergies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAllergies.AutoSize = true;
            labelAllergies.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllergies.ForeColor = Color.Green;
            labelAllergies.Location = new Point(1066, 130);
            labelAllergies.Name = "labelAllergies";
            labelAllergies.Size = new Size(93, 25);
            labelAllergies.TabIndex = 16;
            labelAllergies.Text = "Allergies:";
            // 
            // textBoxAllergies
            // 
            textBoxAllergies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAllergies.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAllergies.Location = new Point(1161, 124);
            textBoxAllergies.Margin = new Padding(3, 4, 3, 4);
            textBoxAllergies.Name = "textBoxAllergies";
            textBoxAllergies.ReadOnly = true;
            textBoxAllergies.Size = new Size(393, 32);
            textBoxAllergies.TabIndex = 17;
            // 
            // labelAbnormalities
            // 
            labelAbnormalities.AutoSize = true;
            labelAbnormalities.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbnormalities.ForeColor = Color.Green;
            labelAbnormalities.Location = new Point(16, 180);
            labelAbnormalities.Name = "labelAbnormalities";
            labelAbnormalities.Size = new Size(141, 25);
            labelAbnormalities.TabIndex = 18;
            labelAbnormalities.Text = "Abnormalities:";
            // 
            // textBoxAbnormalities
            // 
            textBoxAbnormalities.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAbnormalities.Location = new Point(155, 180);
            textBoxAbnormalities.Margin = new Padding(3, 4, 3, 4);
            textBoxAbnormalities.Name = "textBoxAbnormalities";
            textBoxAbnormalities.ReadOnly = true;
            textBoxAbnormalities.Size = new Size(437, 32);
            textBoxAbnormalities.TabIndex = 19;
            // 
            // labelBloodPressure
            // 
            labelBloodPressure.Anchor = AnchorStyles.Top;
            labelBloodPressure.AutoSize = true;
            labelBloodPressure.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelBloodPressure.ForeColor = Color.Green;
            labelBloodPressure.Location = new Point(634, 159);
            labelBloodPressure.Name = "labelBloodPressure";
            labelBloodPressure.Size = new Size(151, 25);
            labelBloodPressure.TabIndex = 20;
            labelBloodPressure.Text = "Blood Pressure:";
            // 
            // textBoxBloodPressure
            // 
            textBoxBloodPressure.Anchor = AnchorStyles.Top;
            textBoxBloodPressure.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBloodPressure.Location = new Point(791, 156);
            textBoxBloodPressure.Margin = new Padding(3, 4, 3, 4);
            textBoxBloodPressure.Name = "textBoxBloodPressure";
            textBoxBloodPressure.ReadOnly = true;
            textBoxBloodPressure.Size = new Size(234, 32);
            textBoxBloodPressure.TabIndex = 21;
            // 
            // labelDrugsTaken
            // 
            labelDrugsTaken.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDrugsTaken.AutoSize = true;
            labelDrugsTaken.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelDrugsTaken.ForeColor = Color.Green;
            labelDrugsTaken.Location = new Point(1031, 173);
            labelDrugsTaken.Name = "labelDrugsTaken";
            labelDrugsTaken.Size = new Size(128, 25);
            labelDrugsTaken.TabIndex = 22;
            labelDrugsTaken.Text = "Drugs Taken:";
            // 
            // textBoxDrugsTaken
            // 
            textBoxDrugsTaken.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxDrugsTaken.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDrugsTaken.Location = new Point(1161, 170);
            textBoxDrugsTaken.Margin = new Padding(3, 4, 3, 4);
            textBoxDrugsTaken.Name = "textBoxDrugsTaken";
            textBoxDrugsTaken.ReadOnly = true;
            textBoxDrugsTaken.Size = new Size(393, 32);
            textBoxDrugsTaken.TabIndex = 23;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.Green;
            labelName.Location = new Point(48, 27);
            labelName.Name = "labelName";
            labelName.Size = new Size(106, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Full Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(155, 20);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(437, 32);
            textBoxName.TabIndex = 1;
            // 
            // labelAge
            // 
            labelAge.Anchor = AnchorStyles.Top;
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAge.ForeColor = Color.Green;
            labelAge.Location = new Point(637, 20);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(52, 25);
            labelAge.TabIndex = 2;
            labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            textBoxAge.Anchor = AnchorStyles.Top;
            textBoxAge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.Location = new Point(692, 17);
            textBoxAge.Margin = new Padding(3, 4, 3, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.ReadOnly = true;
            textBoxAge.Size = new Size(83, 32);
            textBoxAge.TabIndex = 3;
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Top;
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.ForeColor = Color.Green;
            labelGender.Location = new Point(794, 20);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(84, 25);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender:";
            // 
            // textBoxGender
            // 
            textBoxGender.Anchor = AnchorStyles.Top;
            textBoxGender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGender.Location = new Point(878, 16);
            textBoxGender.Margin = new Padding(3, 4, 3, 4);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.ReadOnly = true;
            textBoxGender.Size = new Size(147, 32);
            textBoxGender.TabIndex = 5;
            // 
            // labelContact
            // 
            labelContact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelContact.ForeColor = Color.Green;
            labelContact.Location = new Point(1074, 20);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(86, 25);
            labelContact.TabIndex = 6;
            labelContact.Text = "Contact:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(1161, 17);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(393, 32);
            textBoxPhone.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddress.ForeColor = Color.Green;
            labelAddress.Location = new Point(66, 79);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(88, 25);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(155, 76);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(437, 32);
            textBoxAddress.TabIndex = 9;
            // 
            // labelNotes
            // 
            labelNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelNotes.ForeColor = Color.Green;
            labelNotes.Location = new Point(1090, 73);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(69, 25);
            labelNotes.TabIndex = 10;
            labelNotes.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNotes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNotes.Location = new Point(1161, 70);
            textBoxNotes.Margin = new Padding(3, 4, 3, 4);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ReadOnly = true;
            textBoxNotes.Size = new Size(394, 32);
            textBoxNotes.TabIndex = 11;
            // 
            // buttonTeethChartEdit
            // 
            buttonTeethChartEdit.BackColor = Color.Green;
            buttonTeethChartEdit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTeethChartEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonTeethChartEdit.Location = new Point(790, 600);
            buttonTeethChartEdit.Margin = new Padding(3, 4, 3, 4);
            buttonTeethChartEdit.Name = "buttonTeethChartEdit";
            buttonTeethChartEdit.Size = new Size(123, 50);
            buttonTeethChartEdit.TabIndex = 24;
            buttonTeethChartEdit.Text = "Edit";
            buttonTeethChartEdit.UseVisualStyleBackColor = false;
            buttonTeethChartEdit.Click += buttonTeethChartEdit_Click;
            // 
            // FormDentalRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1639, 1055);
            Controls.Add(buttonTeethChartEdit);
            Controls.Add(panelPatientInfo);
            Controls.Add(labelLegend);
            Controls.Add(panelTeethChart);
            Controls.Add(textBoxDentalSearch);
            Controls.Add(labelSearch);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewDental);
            Margin = new Padding(3, 4, 3, 4);
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
