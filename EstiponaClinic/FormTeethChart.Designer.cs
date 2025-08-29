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
            SuspendLayout();
            // 
            // textBoxPatientNameTeethChart
            // 
            textBoxPatientNameTeethChart.Location = new Point(83, 20);
            textBoxPatientNameTeethChart.Name = "textBoxPatientNameTeethChart";
            textBoxPatientNameTeethChart.ReadOnly = true;
            textBoxPatientNameTeethChart.Size = new Size(200, 23);
            textBoxPatientNameTeethChart.TabIndex = 0;
            // 
            // panelTeethChartEdit
            // 
            panelTeethChartEdit.BorderStyle = BorderStyle.FixedSingle;
            panelTeethChartEdit.Location = new Point(12, 60);
            panelTeethChartEdit.Name = "panelTeethChartEdit";
            panelTeethChartEdit.Size = new Size(738, 130);
            panelTeethChartEdit.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(660, 208);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(90, 30);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormTeethChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 260);
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
    }
}
