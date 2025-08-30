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
            textBoxPatientNameTeethChart.Location = new Point(127, 33);
            textBoxPatientNameTeethChart.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientNameTeethChart.Name = "textBoxPatientNameTeethChart";
            textBoxPatientNameTeethChart.ReadOnly = true;
            textBoxPatientNameTeethChart.Size = new Size(263, 39);
            textBoxPatientNameTeethChart.TabIndex = 0;
            // 
            // panelTeethChartEdit
            // 
            panelTeethChartEdit.BorderStyle = BorderStyle.FixedSingle;
            panelTeethChartEdit.Location = new Point(14, 80);
            panelTeethChartEdit.Margin = new Padding(3, 4, 3, 4);
            panelTeethChartEdit.Name = "panelTeethChartEdit";
            panelTeethChartEdit.Size = new Size(843, 173);
            panelTeethChartEdit.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Green;
            buttonSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(729, 277);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(128, 46);
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
            label7.Location = new Point(12, 33);
            label7.Name = "label7";
            label7.Size = new Size(101, 32);
            label7.TabIndex = 19;
            label7.Text = "Patient:";
            // 
            // FormTeethChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(874, 347);
            Controls.Add(label7);
            Controls.Add(textBoxPatientNameTeethChart);
            Controls.Add(panelTeethChartEdit);
            Controls.Add(buttonSave);
            Margin = new Padding(3, 4, 3, 4);
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
