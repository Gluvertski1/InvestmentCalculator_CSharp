using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//===========================================================================
// Jared Day 1/28/2018
//
// Investment Calculator
// Create an windows application and use C# methods. Compound interest is 
// calculated by A=P(1+r/n)^(n*m/12). Amount (A) is the future value of the
// investment. Display in a label formatted with two decimal places. 
// Principal (P) is the principal amount invested.
// Rate (r) is the interest rate.
// Compound rate (n) is the number of times the amount is compounded per year
// (monthly = 12). The maximum compound rate should be 365 (daily).
// Number of months (m) is the number of months the principal amount is 
// invested for (max = 120). For practice, create two methods 1) Base: 1+r/n
// and 2) the exponent: n*m/12.Use these two methods in the C# power method.
// Include error checking. If the user types in a letter, negative number etc/
// and then clicks calculate then display an error provider for that textbox
// Use the double variable type. Display the resulting amount in the fuure 
// value label in the currency format. 
// ==========================================================================
namespace Investment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This is the quit button code. Upon clicking this key the program will end.
        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double r; // interest rate
            double P; // principal amount
            double n; // compound rate
            double months; // number of months
            double Anew;
            double A = 0.0; // final value
            double baseNum;
            double exponentialNum;


            double.TryParse(principal.Text, out P);         // getting principal value from text box.
            double.TryParse(interestRate.Text, out r);      // getting interest rate from text box.
            

            n = compoundRateScroll.Value;                   // getting compound rate from scroll bar.
            months = monthsAccrueScroll.Value;                   // getting number of months.

            baseNum = baseValue(r, n);
            
            exponentialNum = exponentialValue(n, months);

            Anew = Math.Pow(baseNum, exponentialNum);

            A = P *Anew;
         
            futureValue.Text = A.ToString("C2");

        }

        // calculates the base number and the returns.
        private double baseValue(double r, double n)
        {
            double baseNumber;

            r = r / 100;

            baseNumber = 1 + ((r) / n);
            return baseNumber;

        }

        private double exponentialValue(double n, double months)
        {
            double expNumber;

            expNumber = (n * months) / 12;
            
            return expNumber;
        }

        private void principal_KeyPress(object sender, KeyPressEventArgs e)
        {
             //checking for text box input. Will not allow the user to input
            // more than one '.' or anything other than a digit or command key.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar) != true && char.IsDigit(e.KeyChar) != true && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void interestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // checking for text box input. Will not allow the user to input
            // more than one '.' or anything other than a digit or command key.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar) != true && char.IsDigit(e.KeyChar) != true && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void compoundRateScroll_Scroll(object sender, ScrollEventArgs e)
        {
            compoundRateLabel.Text = compoundRateScroll.Value.ToString();
        }

        private void monthsAccrueScroll_Scroll(object sender, ScrollEventArgs e)
        {
            monthAccrueLabel.Text = monthsAccrueScroll.Value.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            principal.Clear();
            interestRate.Clear();
            futureValue.Text = "$0.00";
            principal.Text = "0.00";
            interestRate.Text = "0.00";
        }

        private void principal_Validating(object sender, CancelEventArgs e)
        {
            double parseValue1;
            if (string.IsNullOrEmpty(principal.Text) || !double.TryParse(principal.Text, out parseValue1))
            {
                e.Cancel = true;
                principal.Focus();
                errorProvider1.SetError(principal, "Please only enter a number in the form x.xx");
                principal.Clear();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(principal, null);
            }
        }

        private void interestRate_Validating(object sender, CancelEventArgs e)
        {
            double parseValue1;

            if (string.IsNullOrEmpty(interestRate.Text) || !double.TryParse(interestRate.Text, out parseValue1))
            {
                e.Cancel = true;
                interestRate.Focus();
                errorProvider1.SetError(interestRate, "Please only enter a number in the form x.xx");
                interestRate.Clear();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(interestRate, null);
            }
            
        }
    }
}
