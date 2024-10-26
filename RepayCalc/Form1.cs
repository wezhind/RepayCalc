using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepayCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click; // Link button event
                                                      // Subscribe to the TextChanged event
            txtPrincipal.TextChanged += Txt_TextChanged;
            txtRemainingDebt.TextChanged += Txt_TextChanged;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Input loan details
                double principal = Convert.ToDouble(txtPrincipal.Text); // Keep the name as txtPrincipal
                double remainingDebt = Convert.ToDouble(txtRemainingDebt.Text);
                double annualInterestRate = Convert.ToDouble(txtInterestRate.Text);
                string paymentFrequency = cmbPaymentFrequency.SelectedItem.ToString().ToLower();
                double paymentAmount = Convert.ToDouble(txtPaymentAmount.Text);

                // Calculate total payments made
                double totalPaid = principal - remainingDebt;

                // Calculate total payments and payoff date
                int paymentsPerYear = GetPaymentsPerYear(paymentFrequency);
                double monthlyInterestRate = (annualInterestRate / 100) / paymentsPerYear;

                // Assess when the loan will be paid off based on remaining debt
                int totalPayments = CalculatePayoffPeriod(remainingDebt, monthlyInterestRate, paymentAmount);

                // Output the result
                if (totalPayments < 0)
                {
                    txtResult.Text = "The payment amount is not sufficient to pay off the loan.";
                }
                else
                {
                    int years = totalPayments / paymentsPerYear;
                    int months = totalPayments % paymentsPerYear;
                    txtResult.Text = $"Total paid so far: {totalPaid:C}{Environment.NewLine}Remaining loan will be paid off in {years} years and {months} months.";

                    // Generate the amortization schedule and bind it to the DataGridView
                    List<AmortizationRow> schedule = GenerateAmortizationSchedule(remainingDebt, monthlyInterestRate, paymentAmount);
                    dataGridViewAmortization.DataSource = schedule;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetPaymentsPerYear(string frequency)
        {
            return frequency switch
            {
                "monthly" => 12,
                "fortnightly" => 26,
                "weekly" => 52,
                _ => throw new ArgumentException("Invalid payment frequency. Use monthly, fortnightly, or weekly.")
            };
        }

        private int CalculatePayoffPeriod(double principal, double monthlyInterestRate, double paymentAmount)
        {
            int totalPayments = 0;

            while (principal > 0)
            {
                // Calculate interest for the current principal
                double interest = principal * monthlyInterestRate;

                // If the payment is less than the interest, it's insufficient
                if (paymentAmount <= interest)
                {
                    return -1; // Insufficient payment
                }

                // Subtract the payment from the total principal
                principal = principal + interest - paymentAmount;
                totalPayments++;
            }

            return totalPayments;
        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            // Get the sender TextBox
            TextBox textBox = sender as TextBox;

            // If the TextBox is not null
            if (textBox != null)
            {
                // Remove any non-numeric characters except for commas
                string sanitizedInput = new string(textBox.Text.Where(c => char.IsDigit(c) || c == ',').ToArray());

                // Check if the input can be parsed as a double
                if (double.TryParse(sanitizedInput.Replace(",", ""), out double result))
                {
                    // Set the formatted text back to the TextBox
                    textBox.TextChanged -= Txt_TextChanged; // Unsubscribe to avoid recursion
                    textBox.Text = String.Format("{0:N0}", result); // Format with commas
                    textBox.SelectionStart = textBox.Text.Length; // Move cursor to end
                    textBox.TextChanged += Txt_TextChanged; // Resubscribe
                }
            }
        }

        private List<AmortizationRow> GenerateAmortizationSchedule(double principal, double monthlyInterestRate, double paymentAmount)
        {
            var schedule = new List<AmortizationRow>();
            int paymentNumber = 1;

            while (principal > 0)
            {
                double interestPayment = principal * monthlyInterestRate;
                double principalPayment = paymentAmount - interestPayment;

                if (principalPayment < 0)
                {
                    // If the payment is less than the interest, the loan can't be paid off.
                    throw new InvalidOperationException("Payment amount is insufficient to cover interest.");
                }

                principal -= principalPayment;

                if (principal < 0)
                {
                    principalPayment += principal; // Adjust for final payment
                    principal = 0;
                }

                schedule.Add(new AmortizationRow
                {
                    PaymentNumber = paymentNumber,
                    PaymentAmount = paymentAmount,
                    InterestPayment = interestPayment,
                    PrincipalPayment = principalPayment,
                    RemainingBalance = principal
                });

                paymentNumber++;
            }

            return schedule;
        }

        public class AmortizationRow
        {
            public int PaymentNumber { get; set; }
            public double PaymentAmount { get; set; }
            public double InterestPayment { get; set; }
            public double PrincipalPayment { get; set; }
            public double RemainingBalance { get; set; }
        }

    }
}