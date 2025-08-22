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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDental = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxDentalSearch = new System.Windows.Forms.TextBox();
            this.panelTeethChart = new System.Windows.Forms.Panel();
            this.labelLegend = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDental)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDental
            // 
            this.dataGridViewDental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDental.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDental.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDental.Location = new System.Drawing.Point(30, 552);
            this.dataGridViewDental.Name = "dataGridViewDental";
            this.dataGridViewDental.ReadOnly = true;
            this.dataGridViewDental.RowTemplate.Height = 25;
            this.dataGridViewDental.Size = new System.Drawing.Size(740, 188);
            this.dataGridViewDental.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(211, 37);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Dental Records";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(30, 493);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(42, 15);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "Search";
            // 
            // textBoxDentalSearch
            // 
            this.textBoxDentalSearch.Location = new System.Drawing.Point(30, 513);
            this.textBoxDentalSearch.Name = "textBoxDentalSearch";
            this.textBoxDentalSearch.Size = new System.Drawing.Size(250, 23);
            this.textBoxDentalSearch.TabIndex = 6;
            // 
            // panelTeethChart
            // 
            this.panelTeethChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTeethChart.Location = new System.Drawing.Point(30, 80);
            this.panelTeethChart.Name = "panelTeethChart";
            this.panelTeethChart.Size = new System.Drawing.Size(740, 260); // increased height
            this.panelTeethChart.TabIndex = 7;
            // 
            // labelLegend
            // 
            this.labelLegend.AutoSize = true;
            this.labelLegend.Location = new System.Drawing.Point(30, 360); // moved below the panel
            this.labelLegend.Name = "labelLegend";
            this.labelLegend.Size = new System.Drawing.Size(280, 60);
            this.labelLegend.TabIndex = 8;
            this.labelLegend.Text = "Legend:\n🟩 Healthy   🟥 Extracted   🟨 Needs Filling   🟦 Crown";
            // 
            // FormDentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.labelLegend);
            this.Controls.Add(this.panelTeethChart);
            this.Controls.Add(this.textBoxDentalSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewDental);
            this.Name = "FormDentalRecord";
            this.Text = "Dental Record Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDental;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxDentalSearch;
        private System.Windows.Forms.Panel panelTeethChart;
        private System.Windows.Forms.Label labelLegend;
    }
}
