using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using Newtonsoft.Json;

namespace EstiponaClinic
{
    public partial class FormBilling : Form
    {
        private List<FormPatients.Patient> patients = new();
        private List<FormAppointment.Appointment> appointments = new();
        private List<Billing> billings = new();
        private readonly string patientFile;
        private readonly string appointmentFile;
        private readonly string billingFile;
        private Billing? selectedBillingForPrint;
        private int receiptWidth = 280;


        public FormBilling()
        {
            InitializeComponent();

            patientFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "patients.json"
            );

            appointmentFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "appointments.json"
            );

            billingFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "EstiponaClinic",
                "billings.json"
            );

            Directory.CreateDirectory(Path.GetDirectoryName(patientFile)!);

            LoadPatients();
            LoadAppointments();
            LoadBillings();
            PopulatePatientCombo();

            comboBoxPatient.SelectedIndexChanged += ComboBoxPatient_SelectedIndexChanged;

            // ✅ Setup payment methods
            comboBoxPaymentMethod.Items.AddRange(new string[] { "Cash", "GCash", "Card" });

            // ✅ Wire discount & amount textbox events
            textBoxDiscount.TextChanged += textBoxDiscount_TextChanged;
            textBoxAmountPaid.TextChanged += textBoxAmount_TextChanged;

            // ✅ Handle row click to show billing details
            dataGridViewTreatments.CellClick += DataGridViewTreatments_CellClick;
        }

        // ------------------ MODELS ------------------
        public class Treatment
        {
            public string TreatmentName { get; set; } = string.Empty;
            public decimal Cost { get; set; }
        }

        public class Payment
        {
            public DateTime Date { get; set; }
            public decimal Amount { get; set; }
        }

        public class Billing
        {
            public int BillingID { get; set; }
            public int PatientID { get; set; }
            public string PatientName { get; set; } = string.Empty;
            public DateTime Date { get; set; }
            public List<Treatment> Treatments { get; set; } = new();
            public decimal Subtotal => Treatments.Sum(t => t.Cost);
            public decimal Discount { get; set; }
            public decimal Total => Subtotal - Discount;
            public decimal AmountPaid { get; set; }
            public List<Payment> Payments { get; set; } = new();
            public string PaymentMethod { get; set; } = string.Empty;
            public decimal Balance => Total - AmountPaid;
        }

        // ------------------ LOAD/SAVE ------------------
        private void LoadPatients()
        {
            if (File.Exists(patientFile))
            {
                string json = File.ReadAllText(patientFile);
                patients = JsonConvert.DeserializeObject<List<FormPatients.Patient>>(json) ?? new();
                patients = patients.Where(p => p != null).ToList();
            }
        }

        private void LoadAppointments()
        {
            if (File.Exists(appointmentFile))
            {
                string json = File.ReadAllText(appointmentFile);
                appointments = JsonConvert.DeserializeObject<List<FormAppointment.Appointment>>(json) ?? new();
            }
        }

        private void LoadBillings()
        {
            if (File.Exists(billingFile))
            {
                string json = File.ReadAllText(billingFile);
                billings = JsonConvert.DeserializeObject<List<Billing>>(json) ?? new();
            }
        }

        private void SaveBillings()
        {
            File.WriteAllText(billingFile, JsonConvert.SerializeObject(billings, Formatting.Indented));
        }

        // ------------------ POPULATE PATIENTS ------------------
        private void PopulatePatientCombo()
        {
            comboBoxPatient.DataSource = null;

            var validPatients = patients.Where(p => p != null).ToList();

            comboBoxPatient.DataSource = patients;
            comboBoxPatient.DisplayMember = "Name";
            comboBoxPatient.ValueMember = "PatientID";

            comboBoxPatient.SelectedIndexChanged += ComboBoxPatient_SelectedIndexChanged;
        }

        private void ComboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem is FormPatients.Patient selected)
            {
                textBoxAge.Text = CalculateAge(selected.BirthDate).ToString();
                textBoxAddress.Text = selected.Address;

                // 1. Get this patient’s appointments
                foreach (var app in appointments.Where(a => a.PatientName == selected.Name))
                {
                    bool alreadyBilled = billings.Any(b =>
                        b.PatientID == selected.PatientID &&
                        b.Date.Date == app.AppointmentDate.Date &&
                        b.Treatments.Any(t => t.TreatmentName == app.TreatmentName));

                    if (!alreadyBilled)
                    {
                        var billing = new Billing
                        {
                            BillingID = GenerateBillingID(),
                            PatientID = selected.PatientID,
                            PatientName = selected.Name,
                            Date = app.AppointmentDate,
                            Treatments = new List<Treatment>
                            {
                                new Treatment { TreatmentName = app.TreatmentName, Cost = app.TreatmentCost }
                            }
                        };

                        billings.Add(billing);
                    }
                }
                SaveBillings();

                RefreshBillingGrid(selected.PatientID);
            }
        }

        // ------------------ HELPERS ------------------
        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (DateTime.Today < birthDate.AddYears(age)) age--;
            return age;
        }

        private int GenerateBillingID()
        {
            return billings.Any() ? billings.Max(b => b.BillingID) + 1 : 1;
        }

        private void RefreshBillingGrid(int patientId)
        {
            var patientBills = billings.Where(b => b.PatientID == patientId).ToList();

            dataGridViewTreatments.DataSource = null;
            dataGridViewTreatments.DataSource = patientBills
                .SelectMany(b => b.Treatments.Select(t => new
                {
                    b.BillingID,
                    b.Date,
                    t.TreatmentName,
                    t.Cost,
                    b.Subtotal,
                    b.Discount,
                    b.Total,
                    b.AmountPaid,
                    Balance = b.Balance,
                    b.PaymentMethod
                }))
                .ToList();
        }

        // ------------------ NEW: Show details when clicking a row ------------------
        private void DataGridViewTreatments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dataGridViewTreatments.Rows[e.RowIndex].Cells["BillingID"].Value is int billingId)
            {
                var billing = billings.FirstOrDefault(b => b.BillingID == billingId);
                if (billing != null)
                {
                    textBoxSubtotal.Text = billing.Subtotal.ToString("F2");
                    textBoxDiscount.Text = billing.Discount.ToString("F2");
                    textBoxTotal.Text = billing.Total.ToString("F2");
                    textBoxAmountPaid.Text = billing.AmountPaid.ToString("F2");
                    textBoxChange.Text = (billing.AmountPaid - billing.Total >= 0
                                          ? (billing.AmountPaid - billing.Total).ToString("F2")
                                          : "0.00");
                    comboBoxPaymentMethod.SelectedItem =
                        string.IsNullOrEmpty(billing.PaymentMethod) ? null : billing.PaymentMethod;
                }
            }
        }

        // ------------------ EVENTS ------------------
        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxSubtotal.Text, out decimal subtotal) &&
                decimal.TryParse(textBoxDiscount.Text, out decimal discount))
            {
                textBoxTotal.Text = (subtotal - discount).ToString("F2");
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxAmountPaid.Text, out decimal amount) &&
                decimal.TryParse(textBoxTotal.Text, out decimal total))
            {
                decimal change = amount - total;
                textBoxChange.Text = change >= 0 ? change.ToString("F2") : "0.00";
            }
        }

        private void buttonRecordPayment_Click(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem is FormPatients.Patient selected &&
                dataGridViewTreatments.CurrentRow != null &&
                dataGridViewTreatments.CurrentRow.Cells["BillingID"].Value is int billingId)
            {
                var billing = billings.FirstOrDefault(b => b.BillingID == billingId);
                if (billing == null)
                {
                    MessageBox.Show("No billing found for this appointment.");
                    return;
                }

                if (!decimal.TryParse(textBoxAmountPaid.Text, out decimal payment) || payment <= 0)
                {
                    MessageBox.Show("Invalid payment amount.");
                    return;
                }

                // Allow overpayment, but cap balance at 0
                decimal newAmountPaid = billing.AmountPaid + payment;

                // Save discount and method
                billing.Discount = decimal.TryParse(textBoxDiscount.Text, out var d) ? d : 0;
                billing.PaymentMethod = comboBoxPaymentMethod.SelectedItem?.ToString() ?? "Cash";

                // Add payment record
                billing.Payments.Add(new Payment
                {
                    Date = DateTime.Now,
                    Amount = payment
                });

                // Update AmountPaid (can exceed total, to show exact amount given)
                billing.AmountPaid = newAmountPaid;

                // Save
                SaveBillings();

                // Show balance (never below 0) and change
                decimal balance = Math.Max(0, billing.Total - billing.AmountPaid);
                decimal change = billing.AmountPaid > billing.Total ? billing.AmountPaid - billing.Total : 0;

                MessageBox.Show(
                    $"Payment recorded.\nPaid: {billing.AmountPaid:F2}\nBalance: {balance:F2}\nChange: {change:F2}"
                );

                RefreshBillingGrid(selected.PatientID);
            }
        }

        private void buttonViewPayments_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatments.CurrentRow != null &&
                dataGridViewTreatments.CurrentRow.Cells["BillingID"].Value is int billingId)
            {
                var billing = billings.FirstOrDefault(b => b.BillingID == billingId);
                if (billing == null || billing.Payments.Count == 0)
                {
                    MessageBox.Show("No payment history for this billing.");
                    return;
                }

                string history = $"Billing ID: {billing.BillingID}, Total: {billing.Total}, Paid: {billing.AmountPaid}, Balance: {billing.Balance}, Method: {billing.PaymentMethod}\n";
                foreach (var p in billing.Payments)
                {
                    history += $"   - {p.Date:g}: {p.Amount}\n";
                }

                MessageBox.Show(history, "Payment History");
            }
            else
            {
                MessageBox.Show("Please select a billing entry first.");
            }
        }

        private void buttonPrintReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatments.CurrentRow != null &&
                dataGridViewTreatments.CurrentRow.Cells["BillingID"].Value is int billingId)
            {
                selectedBillingForPrint = billings.FirstOrDefault(b => b.BillingID == billingId);
                if (selectedBillingForPrint == null)
                {
                    MessageBox.Show("No billing found for this entry.");
                    return;
                }

                PrintDocument pd = new PrintDocument();

                // ✅ Set custom paper size (80mm receipt)
                pd.DefaultPageSettings.PaperSize = new PaperSize("Receipt", receiptWidth, 600);

                pd.PrintPage += Pd_PrintPage;

                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = pd,
                    Width = 800,
                    Height = 600,
                    StartPosition = FormStartPosition.CenterScreen
                };

                preview.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a billing entry first.");
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (selectedBillingForPrint == null) return;

            Billing b = selectedBillingForPrint;
            Graphics g = e.Graphics;
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 9);
            Font boldFont = new Font("Arial", 9, FontStyle.Bold);

            float y = 30;

            // Header
            g.DrawString("ESTIPONA DENTAL CLINIC", headerFont, Brushes.Black, 40, y); y += 40;
            g.DrawString("Official Receipt", boldFont, Brushes.Black, 100, y); y += 40;
            g.DrawLine(Pens.Black, 0, y, receiptWidth, y); y += 10;

            // Patient info
            g.DrawString($"Patient: {b.PatientName}", bodyFont, Brushes.Black, 10, y); y += 35;
            g.DrawString($"Date: {b.Date:g}", bodyFont, Brushes.Black, 10, y); y += 35;
            g.DrawString($"Billing ID: {b.BillingID}", bodyFont, Brushes.Black, 10, y); y += 40;

            // Treatments
            g.DrawString("Treatments:", boldFont, Brushes.Black, 10, y); y += 35;
            foreach (var t in b.Treatments)
            {
                g.DrawString($"{t.TreatmentName}", bodyFont, Brushes.Black, 40, y);
                g.DrawString($"₱ {t.Cost:F2}", bodyFont, Brushes.Black, 180, y);
                y += 35;
            }

            g.DrawLine(Pens.Black, 0, y, receiptWidth, y); y += 10;

            // Summary
            g.DrawString($"Subtotal:", bodyFont, Brushes.Black, 10, y);
            g.DrawString($"₱ {b.Subtotal:F2}", bodyFont, Brushes.Black, 180, y); y += 35;

            g.DrawString($"Discount:", bodyFont, Brushes.Black, 10, y);
            g.DrawString($"₱ {b.Discount:F2}", bodyFont, Brushes.Black, 180, y); y += 35;

            g.DrawString($"TOTAL:", boldFont, Brushes.Black, 10, y);
            g.DrawString($"₱ {b.Total:F2}", boldFont, Brushes.Black, 180, y); y += 40;

            g.DrawString($"Paid:", bodyFont, Brushes.Black, 10, y);
            g.DrawString($"₱ {b.AmountPaid:F2}", bodyFont, Brushes.Black, 180, y); y += 35;

            g.DrawString($"Balance:", bodyFont, Brushes.Black, 10, y);
            g.DrawString($"₱ {b.Balance:F2}", bodyFont, Brushes.Black, 180, y); y += 40;

            g.DrawString($"Payment Method:", bodyFont, Brushes.Black, 10, y);
            g.DrawString($" {b.PaymentMethod:F2}", bodyFont, Brushes.Black, 180, y); y += 40;

            // Footer
            g.DrawLine(Pens.Black, 0, y, receiptWidth, y); y += 10;
            g.DrawString("Thank you for trusting us!", bodyFont, Brushes.Black, 70, y); y += 40;
            g.DrawString("Get well soon! 🦷", bodyFont, Brushes.Black, 90, y);
        }

    }
}
