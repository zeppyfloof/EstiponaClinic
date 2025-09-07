namespace EstiponaClinic
{
    partial class FormTeethChart
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox textBoxPatientNameTeethChart;
        private Panel panelTeethChartEdit;
        private Button buttonSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxPatientNameTeethChart = new TextBox();
            panelTeethChartEdit = new Panel();
            buttonSave = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBoxPatientNameTeethChart
            // 
            textBoxPatientNameTeethChart.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatientNameTeethChart.Location = new Point(111, 25);
            textBoxPatientNameTeethChart.Name = "textBoxPatientNameTeethChart";
            textBoxPatientNameTeethChart.ReadOnly = true;
            textBoxPatientNameTeethChart.Size = new Size(295, 32);
            textBoxPatientNameTeethChart.TabIndex = 0;
            // 
            // panelTeethChartEdit
            // 
            panelTeethChartEdit.BorderStyle = BorderStyle.FixedSingle;
            panelTeethChartEdit.Location = new Point(12, 60);
            panelTeethChartEdit.Name = "panelTeethChartEdit";
            panelTeethChartEdit.Size = new Size(1030, 130);
            panelTeethChartEdit.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Green;
            buttonSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(930, 205);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(10, 25);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 19;
            label7.Text = "Patient:";
            // 
            // FormTeethChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1054, 260);
            Controls.Add(label7);
            Controls.Add(textBoxPatientNameTeethChart);
            Controls.Add(panelTeethChartEdit);
            Controls.Add(buttonSave);
            Name = "FormTeethChart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teeth Chart Editor";
            Load += FormTeethChart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label7;
    }
}
