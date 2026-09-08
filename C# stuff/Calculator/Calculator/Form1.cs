using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string equation;
        double sum = 0d;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Clear();
            sum = 0d;
        }

        
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (RtbCalculatorDisplay.Text.Length > 0)
            {
                RtbCalculatorDisplay.Text = RtbCalculatorDisplay.Text.Remove(RtbCalculatorDisplay.Text.Length - 1, 1);
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "9";

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "+";

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "-";

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "x";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "÷";

        }
        private void btnModulus_Click(object sender, EventArgs e)
        {
            RtbCalculatorDisplay.Text += "%";

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // If it's empty, exit the function.
            equation = RtbCalculatorDisplay.Text;
            if (string.IsNullOrWhiteSpace(equation))
            {
                return;
            }

            // Replace the special characters in the richTextBox with the correct operations.
            string expr = equation.Replace('x', '*').Replace('÷', '/');

            double result = 0d;
            double lastValue = 0d;
            char lastOp = '+';
            var numberBuilder = new StringBuilder();

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];
                bool isLastChar = (i == expr.Length - 1);

                // If the character the loop is currently on is a valid number or decimal, add it to the expression.
                if (char.IsDigit(c) || c == '.')
                {
                    numberBuilder.Append(c);
                }

                // If the character is somehow invalid, or it's the last character in the equation, calculate the final number.
                if ((!char.IsDigit(c) && c != '.') || isLastChar)
                {
                    string numStr = numberBuilder.ToString();
                    double currentNum;

                    // If it can't parse the string, set the number to 0.
                    if (!double.TryParse(numStr, out currentNum))
                    {
                        currentNum = 0d;
                    }

                    switch (lastOp)
                    {
                        case '+':
                            result += lastValue;
                            lastValue = currentNum;
                            break;
                        case '-':
                            result += lastValue;
                            lastValue = -currentNum;
                            break;
                        case '*':
                            lastValue = lastValue * currentNum;
                            break;
                        case '/':
                            if (currentNum == 0d)
                            {
                                MessageBox.Show("Division by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            lastValue = lastValue / currentNum;
                            break;
                        case '%':
                            lastValue = lastValue % currentNum;
                            break;
                    }

                    numberBuilder.Clear();

                    if (!isLastChar)
                    {
                        lastOp = c;
                    }
                }
            }

            result += lastValue;
            sum = result;

            RtbCalculatorDisplay.Text = sum.ToString();
        }

    }
}
