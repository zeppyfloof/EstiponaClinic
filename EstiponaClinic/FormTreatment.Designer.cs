namespace EstiponaClinic
{
    partial class FormTreatment
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxTreatmentCost = new TextBox();
            textBoxTreatmentDescription = new TextBox();
            textBoxTreatmentName = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            dataGridViewTreatment = new DataGridView();
            buttonTreatmentDelete = new Button();
            buttonTreatmentEdit = new Button();
            buttonTreatmentSave = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 70);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 13;
            label3.Text = "Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 12;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 11;
            label1.Text = "Treatment Name";
            // 
            // textBoxTreatmentCost
            // 
            textBoxTreatmentCost.Location = new Point(352, 90);
            textBoxTreatmentCost.Name = "textBoxTreatmentCost";
            textBoxTreatmentCost.Size = new Size(250, 23);
            textBoxTreatmentCost.TabIndex = 10;
            // 
            // textBoxTreatmentDescription
            // 
            textBoxTreatmentDescription.Location = new Point(30, 140);
            textBoxTreatmentDescription.Multiline = true;
            textBoxTreatmentDescription.Name = "textBoxTreatmentDescription";
            textBoxTreatmentDescription.Size = new Size(250, 60);
            textBoxTreatmentDescription.TabIndex = 9;
            // 
            // textBoxTreatmentName
            // 
            textBoxTreatmentName.Location = new Point(30, 90);
            textBoxTreatmentName.Name = "textBoxTreatmentName";
            textBoxTreatmentName.Size = new Size(250, 23);
            textBoxTreatmentName.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 221);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 24;
            label7.Text = "Search";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 23;
            // 
            // dataGridViewTreatment
            // 
            dataGridViewTreatment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTreatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTreatment.Location = new Point(30, 320);
            dataGridViewTreatment.Name = "dataGridViewTreatment";
            dataGridViewTreatment.ReadOnly = true;
            dataGridViewTreatment.RowTemplate.Height = 25;
            dataGridViewTreatment.Size = new Size(740, 428);
            dataGridViewTreatment.TabIndex = 22;
            // 
            // buttonTreatmentDelete
            // 
            buttonTreatmentDelete.BackColor = Color.Green;
            buttonTreatmentDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonTreatmentDelete.Location = new Point(210, 270);
            buttonTreatmentDelete.Name = "buttonTreatmentDelete";
            buttonTreatmentDelete.Size = new Size(80, 35);
            buttonTreatmentDelete.TabIndex = 21;
            buttonTreatmentDelete.Text = "Delete";
            buttonTreatmentDelete.UseVisualStyleBackColor = false;
            buttonTreatmentDelete.Click += buttonTreatmentDelete_Click;
            // 
            // buttonTreatmentEdit
            // 
            buttonTreatmentEdit.BackColor = Color.Green;
            buttonTreatmentEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonTreatmentEdit.Location = new Point(120, 270);
            buttonTreatmentEdit.Name = "buttonTreatmentEdit";
            buttonTreatmentEdit.Size = new Size(80, 35);
            buttonTreatmentEdit.TabIndex = 20;
            buttonTreatmentEdit.Text = "Edit";
            buttonTreatmentEdit.UseVisualStyleBackColor = false;
            // 
            // buttonTreatmentSave
            // 
            buttonTreatmentSave.BackColor = Color.Green;
            buttonTreatmentSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTreatmentSave.ForeColor = SystemColors.ButtonHighlight;
            buttonTreatmentSave.Location = new Point(30, 270);
            buttonTreatmentSave.Name = "buttonTreatmentSave";
            buttonTreatmentSave.Size = new Size(80, 35);
            buttonTreatmentSave.TabIndex = 19;
            buttonTreatmentSave.Text = "Save";
            buttonTreatmentSave.UseVisualStyleBackColor = false;
            buttonTreatmentSave.Click += buttonTreatmentSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 20);
            label8.Name = "label8";
            label8.Size = new Size(150, 37);
            label8.TabIndex = 25;
            label8.Text = "Treatment";
            // 
            // FormTreatment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 760);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(dataGridViewTreatment);
            Controls.Add(buttonTreatmentDelete);
            Controls.Add(buttonTreatmentEdit);
            Controls.Add(buttonTreatmentSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTreatmentCost);
            Controls.Add(textBoxTreatmentDescription);
            Controls.Add(textBoxTreatmentName);
            Name = "FormTreatment";
            Text = "Treatment Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxTreatmentCost;
        private TextBox textBoxTreatmentDescription;
        private TextBox textBoxTreatmentName;
        private Label label7;
        private TextBox textBox2;
        private DataGridView dataGridViewTreatment;
        private Button buttonTreatmentDelete;
        private Button buttonTreatmentEdit;
        private Button buttonTreatmentSave;
        private Label label8;
    }
}