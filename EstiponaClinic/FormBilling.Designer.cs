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
            buttonPrintReceipt = new Button();
            buttonRecordPayment = new Button();
            buttonViewPayments = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatments).BeginInit();
            SuspendLayout();
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPatient.ForeColor = Color.Green;
            labelPatient.Location = new Point(20, 18);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(101, 32);
            labelPatient.TabIndex = 0;
            labelPatient.Text = "Patient:";
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatient.Location = new Point(127, 17);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(354, 37);
            comboBoxPatient.TabIndex = 1;
            // 
            // textBoxAge
            // 
            textBoxAge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAge.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.Location = new Point(737, 20);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.ReadOnly = true;
            textBoxAge.Size = new Size(88, 34);
            textBoxAge.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAddress.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(874, 21);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(362, 34);
            textBoxAddress.TabIndex = 3;
            // 
            // dataGridViewTreatments
            // 
            dataGridViewTreatments.AllowUserToAddRows = false;
            dataGridViewTreatments.AllowUserToDeleteRows = false;
            dataGridViewTreatments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTreatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTreatments.BackgroundColor = Color.Azure;
            dataGridViewTreatments.ColumnHeadersHeight = 48;
            dataGridViewTreatments.Location = new Point(20, 130);
            dataGridViewTreatments.Name = "dataGridViewTreatments";
            dataGridViewTreatments.ReadOnly = true;
            dataGridViewTreatments.RowHeadersWidth = 61;
            dataGridViewTreatments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTreatments.Size = new Size(1216, 300);
            dataGridViewTreatments.TabIndex = 4;
            // 
            // labelSubtotal
            // 
            labelSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSubtotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubtotal.ForeColor = Color.Green;
            labelSubtotal.Location = new Point(73, 444);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(119, 36);
            labelSubtotal.TabIndex = 5;
            labelSubtotal.Text = "Subtotal:";
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSubtotal.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSubtotal.Location = new Point(198, 448);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.ReadOnly = true;
            textBoxSubtotal.Size = new Size(332, 34);
            textBoxSubtotal.TabIndex = 6;
            // 
            // labelDiscount
            // 
            labelDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDiscount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelDiscount.ForeColor = Color.Green;
            labelDiscount.Location = new Point(536, 445);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(128, 37);
            labelDiscount.TabIndex = 7;
            labelDiscount.Text = "Discount:";
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDiscount.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDiscount.Location = new Point(670, 449);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(105, 34);
            textBoxDiscount.TabIndex = 8;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.Green;
            labelTotal.Location = new Point(822, 445);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(79, 34);
            labelTotal.TabIndex = 9;
            labelTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTotal.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotal.Location = new Point(907, 445);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(329, 34);
            textBoxTotal.TabIndex = 10;
            // 
            // labelAmountPaid
            // 
            labelAmountPaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelAmountPaid.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelAmountPaid.ForeColor = Color.Green;
            labelAmountPaid.Location = new Point(20, 509);
            labelAmountPaid.Name = "labelAmountPaid";
            labelAmountPaid.Size = new Size(171, 38);
            labelAmountPaid.TabIndex = 11;
            labelAmountPaid.Text = "Amount Paid:";
            // 
            // textBoxAmountPaid
            // 
            textBoxAmountPaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxAmountPaid.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmountPaid.Location = new Point(198, 508);
            textBoxAmountPaid.Name = "textBoxAmountPaid";
            textBoxAmountPaid.Size = new Size(332, 34);
            textBoxAmountPaid.TabIndex = 12;
            // 
            // labelChange
            // 
            labelChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelChange.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelChange.ForeColor = Color.Green;
            labelChange.Location = new Point(554, 510);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(110, 35);
            labelChange.TabIndex = 13;
            labelChange.Text = "Change:";
            // 
            // textBoxChange
            // 
            textBoxChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxChange.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxChange.Location = new Point(670, 511);
            textBoxChange.Name = "textBoxChange";
            textBoxChange.ReadOnly = true;
            textBoxChange.Size = new Size(105, 34);
            textBoxChange.TabIndex = 14;
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPaymentMethod.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPaymentMethod.ForeColor = Color.Green;
            labelPaymentMethod.Location = new Point(781, 508);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(120, 37);
            labelPaymentMethod.TabIndex = 15;
            labelPaymentMethod.Text = "Payment:";
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxPaymentMethod.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPaymentMethod.Location = new Point(907, 512);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(329, 37);
            comboBoxPaymentMethod.TabIndex = 16;
            // 
            // buttonPrintReceipt
            // 
            buttonPrintReceipt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPrintReceipt.BackColor = Color.LightSlateGray;
            buttonPrintReceipt.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrintReceipt.ForeColor = Color.White;
            buttonPrintReceipt.Location = new Point(20, 588);
            buttonPrintReceipt.Name = "buttonPrintReceipt";
            buttonPrintReceipt.Size = new Size(237, 59);
            buttonPrintReceipt.TabIndex = 18;
            buttonPrintReceipt.Text = "Print Receipt";
            buttonPrintReceipt.UseVisualStyleBackColor = false;
            buttonPrintReceipt.Click += buttonPrintReceipt_Click;
            // 
            // buttonRecordPayment
            // 
            buttonRecordPayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRecordPayment.BackColor = Color.Green;
            buttonRecordPayment.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRecordPayment.ForeColor = Color.White;
            buttonRecordPayment.Location = new Point(999, 588);
            buttonRecordPayment.Name = "buttonRecordPayment";
            buttonRecordPayment.Size = new Size(237, 59);
            buttonRecordPayment.TabIndex = 19;
            buttonRecordPayment.Text = "Submit Payment";
            buttonRecordPayment.UseVisualStyleBackColor = false;
            buttonRecordPayment.Click += buttonRecordPayment_Click;
            // 
            // buttonViewPayments
            // 
            buttonViewPayments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonViewPayments.BackColor = Color.Azure;
            buttonViewPayments.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonViewPayments.Location = new Point(1088, 78);
            buttonViewPayments.Name = "buttonViewPayments";
            buttonViewPayments.Size = new Size(148, 46);
            buttonViewPayments.TabIndex = 20;
            buttonViewPayments.Text = "History";
            buttonViewPayments.UseVisualStyleBackColor = false;
            buttonViewPayments.Click += buttonViewPayments_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(665, 17);
            label1.Name = "label1";
            label1.Size = new Size(66, 32);
            label1.TabIndex = 0;
            label1.Text = "Age:";
            // 
            // FormBilling
            // 
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1264, 671);
            Controls.Add(buttonViewPayments);
            Controls.Add(buttonRecordPayment);
            Controls.Add(label1);
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
            Controls.Add(buttonPrintReceipt);
            Name = "FormBilling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTreatments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonRecordPayment;
        private Button buttonViewPayments;
        private Label label1;
    }
}
