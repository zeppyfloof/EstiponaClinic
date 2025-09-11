namespace EstiponaClinic
{
    partial class FormBilling
    {
        private System.ComponentModel.IContainer components = null;

        // Patient Info
        private Label labelPatient;
        private ComboBox comboBoxPatient;
        private TextBox textBoxAge;
        private TextBox textBoxAddress;

        // Treatments
        private DataGridView dataGridViewTreatments;

        // Billing Summary
        private Label labelSubtotal;
        private TextBox textBoxSubtotal;
        private Label labelDiscount;
        private TextBox textBoxDiscount;
        private Label labelTotal;
        private TextBox textBoxTotal;

        // Payment
        private Label labelAmountPaid;
        private TextBox textBoxAmountPaid;
        private Label labelChange;
        private TextBox textBoxChange;
        private Label labelPaymentMethod;
        private ComboBox comboBoxPaymentMethod;

        // Actions
        private Button buttonSaveBill;
        private Button buttonPrintReceipt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelPatient = new Label();
            comboBoxPatient = new ComboBox();
            textBoxAge = new TextBox();
            textBoxAddress = new TextBox();
            dataGridViewTreatments = new DataGridView();
            labelSubtotal = new Label();
            textBoxSubtotal = new TextBox();
            labelDiscount = new Label();
            textBoxDiscount = new TextBox();
            labelTotal = new Label();
            textBoxTotal = new TextBox();
            labelAmountPaid = new Label();
            textBoxAmountPaid = new TextBox();
            labelChange = new Label();
            textBoxChange = new TextBox();
            labelPaymentMethod = new Label();
            comboBoxPaymentMethod = new ComboBox();
            buttonSaveBill = new Button();
            buttonPrintReceipt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatments).BeginInit();
            SuspendLayout();
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Location = new Point(20, 20);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(47, 15);
            labelPatient.TabIndex = 0;
            labelPatient.Text = "Patient:";
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.Location = new Point(100, 18);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(200, 23);
            comboBoxPatient.TabIndex = 1;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(320, 18);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.ReadOnly = true;
            textBoxAge.Size = new Size(60, 23);
            textBoxAge.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(400, 18);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(280, 23);
            textBoxAddress.TabIndex = 3;
            // 
            // dataGridViewTreatments
            // 
            dataGridViewTreatments.AllowUserToAddRows = false;
            dataGridViewTreatments.AllowUserToDeleteRows = false;
            dataGridViewTreatments.Location = new Point(20, 60);
            dataGridViewTreatments.Name = "dataGridViewTreatments";
            dataGridViewTreatments.ReadOnly = true;
            dataGridViewTreatments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTreatments.Size = new Size(660, 200);
            dataGridViewTreatments.TabIndex = 4;
            // 
            // labelSubtotal
            // 
            labelSubtotal.Location = new Point(20, 280);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(61, 23);
            labelSubtotal.TabIndex = 5;
            labelSubtotal.Text = "Subtotal:";
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Location = new Point(100, 277);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.ReadOnly = true;
            textBoxSubtotal.Size = new Size(100, 23);
            textBoxSubtotal.TabIndex = 6;
            // 
            // labelDiscount
            // 
            labelDiscount.Location = new Point(220, 280);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(61, 23);
            labelDiscount.TabIndex = 7;
            labelDiscount.Text = "Discount:";
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Location = new Point(300, 277);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(100, 23);
            textBoxDiscount.TabIndex = 8;
            // 
            // labelTotal
            // 
            labelTotal.Location = new Point(420, 280);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(51, 23);
            labelTotal.TabIndex = 9;
            labelTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTotal.Location = new Point(490, 277);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(100, 23);
            textBoxTotal.TabIndex = 10;
            // 
            // labelAmountPaid
            // 
            labelAmountPaid.Location = new Point(20, 320);
            labelAmountPaid.Name = "labelAmountPaid";
            labelAmountPaid.Size = new Size(94, 23);
            labelAmountPaid.TabIndex = 11;
            labelAmountPaid.Text = "Amount Paid:";
            // 
            // textBoxAmountPaid
            // 
            textBoxAmountPaid.Location = new Point(120, 317);
            textBoxAmountPaid.Name = "textBoxAmountPaid";
            textBoxAmountPaid.Size = new Size(100, 23);
            textBoxAmountPaid.TabIndex = 12;
            // 
            // labelChange
            // 
            labelChange.Location = new Point(240, 320);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(54, 23);
            labelChange.TabIndex = 13;
            labelChange.Text = "Change:";
            // 
            // textBoxChange
            // 
            textBoxChange.Location = new Point(300, 317);
            textBoxChange.Name = "textBoxChange";
            textBoxChange.ReadOnly = true;
            textBoxChange.Size = new Size(100, 23);
            textBoxChange.TabIndex = 14;
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.Location = new Point(420, 320);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(64, 23);
            labelPaymentMethod.TabIndex = 15;
            labelPaymentMethod.Text = "Payment:";
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card" });
            comboBoxPaymentMethod.Location = new Point(490, 317);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(120, 23);
            comboBoxPaymentMethod.TabIndex = 16;
            // 
            // buttonSaveBill
            // 
            buttonSaveBill.BackColor = Color.Green;
            buttonSaveBill.ForeColor = Color.White;
            buttonSaveBill.Location = new Point(360, 360);
            buttonSaveBill.Name = "buttonSaveBill";
            buttonSaveBill.Size = new Size(100, 30);
            buttonSaveBill.TabIndex = 17;
            buttonSaveBill.Text = "Save Bill";
            buttonSaveBill.UseVisualStyleBackColor = false;
            // 
            // buttonPrintReceipt
            // 
            buttonPrintReceipt.BackColor = Color.Blue;
            buttonPrintReceipt.ForeColor = Color.White;
            buttonPrintReceipt.Location = new Point(480, 360);
            buttonPrintReceipt.Name = "buttonPrintReceipt";
            buttonPrintReceipt.Size = new Size(120, 30);
            buttonPrintReceipt.TabIndex = 18;
            buttonPrintReceipt.Text = "Print Receipt";
            buttonPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // FormBilling
            // 
            ClientSize = new Size(700, 420);
            Controls.Add(labelPatient);
            Controls.Add(comboBoxPatient);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxAddress);
            Controls.Add(dataGridViewTreatments);
            Controls.Add(labelSubtotal);
            Controls.Add(textBoxSubtotal);
            Controls.Add(labelDiscount);
            Controls.Add(textBoxDiscount);
            Controls.Add(labelTotal);
            Controls.Add(textBoxTotal);
            Controls.Add(labelAmountPaid);
            Controls.Add(textBoxAmountPaid);
            Controls.Add(labelChange);
            Controls.Add(textBoxChange);
            Controls.Add(labelPaymentMethod);
            Controls.Add(comboBoxPaymentMethod);
            Controls.Add(buttonSaveBill);
            Controls.Add(buttonPrintReceipt);
            Name = "FormBilling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
