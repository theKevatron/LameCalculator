using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LameCalculator
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private string currentOperator = "";
        private bool isNewNumber = true; // Set to true when starting a new number after operator

        public Form1()
        {
            InitializeComponent();
        }

        private void AdjustDisplayFont()
        {
            int length = txtDisplay.Text.Length;

            if (length <= 10)
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 36);
            else if (length <= 15)
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 24);
            else
                txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 14);
        }

        private void ClearPrimeStatus()
        {
            txtDetermination.Text = "";
        }

        private bool IsPrime(double number)
        {
            if (number < 2 || number != Math.Floor(number))
                return false;

            int n = (int)number;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private void OnBackspaceClick(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                txtDisplay.Text = "0";
                isNewNumber = false;
                return;
            }

            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";

            ClearPrimeStatus();
        }


        private void OnClearAllClick(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtDisplay.Font = new Font(txtDisplay.Font.FontFamily, 36);
            txtEquation.Text = "";
            firstNumber = 0;
            currentOperator = "";
            isNewNumber = true;
            ClearPrimeStatus();
        }

        private void OnClearEntryClick(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            ClearPrimeStatus();
        }

        private void OnDecimalClick(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                txtDisplay.Text = "0";
                isNewNumber = false;
            }

            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }

            ClearPrimeStatus();
        }

        private void OnEqualsClick(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double secondNumber))
            {
                double result = 0;

                switch (currentOperator)
                {
                    case "+": result = firstNumber + secondNumber; break;
                    case "-": result = firstNumber - secondNumber; break;
                    case "*": result = firstNumber * secondNumber; break;
                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero");
                            result = 0;
                        }
                        break;
                }

                txtDisplay.Text = result.ToString();
                txtEquation.Text = firstNumber + " " + currentOperator + " " + secondNumber + " =";

                if (IsPrime(result))
                    txtDetermination.Text = "PRIME";
                else
                    txtDetermination.Text = "Gay Number";

                isNewNumber = true;
            }
        }

        private void OnInverseClick(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("-"))
                txtDisplay.Text = txtDisplay.Text.Substring(1);
            else if (txtDisplay.Text != "0")
                txtDisplay.Text = "-" + txtDisplay.Text;
            ClearPrimeStatus();
        }

        private void OnNumberClick(object sender, EventArgs e)
        {
            Button numberButton = (Button)sender;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = numberButton.Text;
                isNewNumber = false;
            }
            else
            {
                txtDisplay.Text += numberButton.Text;
            }

            AdjustDisplayFont();
            ClearPrimeStatus();
        }

        private void OnOperatorClick(object sender, EventArgs e)
        {
            Button opButton = (Button)sender;
            currentOperator = opButton.Text;

            if (double.TryParse(txtDisplay.Text, out firstNumber))
            {
                isNewNumber = true;
                txtEquation.Text = firstNumber + " " + currentOperator;
            }
        }
    }
}