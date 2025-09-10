namespace EstiponaClinic
{
    partial class FormBilling
    {
        private System.ComponentModel.IContainer components = null;

        // Patient Info
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAddress;

        // Treatments
        private System.Windows.Forms.DataGridView dataGridViewTreatments;

        // Billing Summary
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;

        // Payment
        private System.Windows.Forms.Label labelAmountPaid;
        private System.Windows.Forms.TextBox textBoxAmountPaid;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;

        // Actions
        private System.Windows.Forms.Button buttonSaveBill;
        private System.Windows.Forms.Button buttonPrintReceipt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ========== PATIENT INFO ==========
            this.labelPatient = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();

            // ========== TREATMENTS ==========
            this.dataGridViewTreatments = new System.Windows.Forms.DataGridView();

            // ========== BILLING SUMMARY ==========
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();

            // ========== PAYMENT ==========
            this.labelAmountPaid = new System.Windows.Forms.Label();
            this.textBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();

            // ========== ACTIONS ==========
            this.buttonSaveBill = new System.Windows.Forms.Button();
            this.buttonPrintReceipt = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).BeginInit();
            this.SuspendLayout();

            // ---------- PATIENT INFO ----------
            this.labelPatient.Text = "Patient:";
            this.labelPatient.Location = new System.Drawing.Point(20, 20);
            this.labelPatient.AutoSize = true;

            this.comboBoxPatient.Location = new System.Drawing.Point(100, 18);
            this.comboBoxPatient.Size = new System.Drawing.Size(200, 25);

            this.textBoxAge.Location = new System.Drawing.Point(320, 18);
            this.textBoxAge.Size = new System.Drawing.Size(60, 25);
            this.textBoxAge.ReadOnly = true;

            this.textBoxAddress.Location = new System.Drawing.Point(400, 18);
            this.textBoxAddress.Size = new System.Drawing.Size(280, 25);
            this.textBoxAddress.ReadOnly = true;

            // ---------- TREATMENTS ----------
            this.dataGridViewTreatments.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewTreatments.Size = new System.Drawing.Size(660, 200);
            this.dataGridViewTreatments.AllowUserToAddRows = false;
            this.dataGridViewTreatments.AllowUserToDeleteRows = false;
            this.dataGridViewTreatments.ReadOnly = true;
            this.dataGridViewTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // ---------- BILLING SUMMARY ----------
            this.labelSubtotal.Text = "Subtotal:";
            this.labelSubtotal.Location = new System.Drawing.Point(20, 280);
            this.textBoxSubtotal.Location = new System.Drawing.Point(100, 277);
            this.textBoxSubtotal.Size = new System.Drawing.Size(100, 25);
            this.textBoxSubtotal.ReadOnly = true;

            this.labelDiscount.Text = "Discount:";
            this.labelDiscount.Location = new System.Drawing.Point(220, 280);
            this.textBoxDiscount.Location = new System.Drawing.Point(300, 277);
            this.textBoxDiscount.Size = new System.Drawing.Size(100, 25);

            this.labelTotal.Text = "Total:";
            this.labelTotal.Location = new System.Drawing.Point(420, 280);
            this.textBoxTotal.Location = new System.Drawing.Point(470, 277);
            this.textBoxTotal.Size = new System.Drawing.Size(100, 25);
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // ---------- PAYMENT ----------
            this.labelAmountPaid.Text = "Amount Paid:";
            this.labelAmountPaid.Location = new System.Drawing.Point(20, 320);
            this.textBoxAmountPaid.Location = new System.Drawing.Point(120, 317);
            this.textBoxAmountPaid.Size = new System.Drawing.Size(100, 25);

            this.labelChange.Text = "Change:";
            this.labelChange.Location = new System.Drawing.Point(240, 320);
            this.textBoxChange.Location = new System.Drawing.Point(300, 317);
            this.textBoxChange.Size = new System.Drawing.Size(100, 25);
            this.textBoxChange.ReadOnly = true;

            this.labelPaymentMethod.Text = "Payment:";
            this.labelPaymentMethod.Location = new System.Drawing.Point(420, 320);
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(490, 317);
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(120, 25);
            this.comboBoxPaymentMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card" });

            // ---------- ACTIONS ----------
            this.buttonSaveBill.Text = "Save Bill";
            this.buttonSaveBill.Location = new System.Drawing.Point(360, 360);
            this.buttonSaveBill.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveBill.BackColor = System.Drawing.Color.Green;
            this.buttonSaveBill.ForeColor = System.Drawing.Color.White;

            this.buttonPrintReceipt.Text = "Print Receipt";
            this.buttonPrintReceipt.Location = new System.Drawing.Point(480, 360);
            this.buttonPrintReceipt.Size = new System.Drawing.Size(120, 30);
            this.buttonPrintReceipt.BackColor = System.Drawing.Color.Blue;
            this.buttonPrintReceipt.ForeColor = System.Drawing.Color.White;

            // ---------- FORM ----------
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                labelPatient, comboBoxPatient, textBoxAge, textBoxAddress,
                dataGridViewTreatments,
                labelSubtotal, textBoxSubtotal, labelDiscount, textBoxDiscount, labelTotal, textBoxTotal,
                labelAmountPaid, textBoxAmountPaid, labelChange, textBoxChange,
                labelPaymentMethod, comboBoxPaymentMethod,
                buttonSaveBill, buttonPrintReceipt
            });
            this.Text = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
