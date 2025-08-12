namespace EstiponaClinic
{
    partial class FormAppointment
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
            label7 = new Label();
            textBoxSearchAppointment = new TextBox();
            dataGridViewAppointments = new DataGridView();
            buttonAppointmentDelete = new Button();
            buttonAppointmentEdit = new Button();
            buttonAppointmentSave = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePickerAppointmentDate = new DateTimePicker();
            dateTimePickerAppointmentTime = new DateTimePicker();
            label8 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 70);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 36;
            label7.Text = "Search";
            // 
            // textBoxSearchAppointment
            // 
            textBoxSearchAppointment.Location = new Point(330, 90);
            textBoxSearchAppointment.Name = "textBoxSearchAppointment";
            textBoxSearchAppointment.Size = new Size(250, 23);
            textBoxSearchAppointment.TabIndex = 35;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.AllowUserToResizeRows = false;
            dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Location = new Point(30, 320);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewAppointments.RowTemplate.Height = 25;
            dataGridViewAppointments.Size = new Size(740, 428);
            dataGridViewAppointments.TabIndex = 34;
            // 
            // buttonAppointmentDelete
            // 
            buttonAppointmentDelete.BackColor = Color.Green;
            buttonAppointmentDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonAppointmentDelete.Location = new Point(210, 270);
            buttonAppointmentDelete.Name = "buttonAppointmentDelete";
            buttonAppointmentDelete.Size = new Size(80, 35);
            buttonAppointmentDelete.TabIndex = 7;
            buttonAppointmentDelete.Text = "Delete";
            buttonAppointmentDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAppointmentEdit
            // 
            buttonAppointmentEdit.BackColor = Color.Green;
            buttonAppointmentEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonAppointmentEdit.Location = new Point(120, 270);
            buttonAppointmentEdit.Name = "buttonAppointmentEdit";
            buttonAppointmentEdit.Size = new Size(80, 35);
            buttonAppointmentEdit.TabIndex = 6;
            buttonAppointmentEdit.Text = "Edit";
            buttonAppointmentEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAppointmentSave
            // 
            buttonAppointmentSave.BackColor = Color.Green;
            buttonAppointmentSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAppointmentSave.ForeColor = SystemColors.ButtonHighlight;
            buttonAppointmentSave.Location = new Point(30, 270);
            buttonAppointmentSave.Name = "buttonAppointmentSave";
            buttonAppointmentSave.Size = new Size(80, 35);
            buttonAppointmentSave.TabIndex = 5;
            buttonAppointmentSave.Text = "Save";
            buttonAppointmentSave.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 170);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 30;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 29;
            label2.Text = "Treatment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 28;
            label1.Text = "Patient";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 23);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 220);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 38;
            label4.Text = "Time";
            // 
            // dateTimePickerAppointmentDate
            // 
            dateTimePickerAppointmentDate.Location = new Point(30, 190);
            dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            dateTimePickerAppointmentDate.Size = new Size(250, 23);
            dateTimePickerAppointmentDate.TabIndex = 3;
            // 
            // dateTimePickerAppointmentTime
            // 
            dateTimePickerAppointmentTime.Format = DateTimePickerFormat.Time;
            dateTimePickerAppointmentTime.Location = new Point(30, 240);
            dateTimePickerAppointmentTime.Name = "dateTimePickerAppointmentTime";
            dateTimePickerAppointmentTime.ShowUpDown = true;
            dateTimePickerAppointmentTime.Size = new Size(250, 23);
            dateTimePickerAppointmentTime.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 20);
            label8.Name = "label8";
            label8.Size = new Size(189, 37);
            label8.TabIndex = 39;
            label8.Text = "Appointment";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(30, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 23);
            comboBox2.TabIndex = 2;
            // 
            // FormAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 760);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(dateTimePickerAppointmentTime);
            Controls.Add(dateTimePickerAppointmentDate);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBoxSearchAppointment);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(buttonAppointmentDelete);
            Controls.Add(buttonAppointmentEdit);
            Controls.Add(buttonAppointmentSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAppointment";
            Text = "Appointment Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBoxSearchAppointment;
        private DataGridView dataGridViewAppointments;
        private Button buttonAppointmentDelete;
        private Button buttonAppointmentEdit;
        private Button buttonAppointmentSave;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePickerAppointmentDate;
        private DateTimePicker dateTimePickerAppointmentTime;
        private Label label8;
        private ComboBox comboBox2;
    }
}