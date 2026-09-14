using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtb_KeyDown(object sender, KeyEventArgs e)
        {
            // If the key pressed is enter...
            if (e.KeyCode == Keys.Enter)
            {
                // Don't register the enter press.
                e.SuppressKeyPress = true;

                // If the text boxes are empty, tell the user to fill them.
                if (rtbNum1.Text.Length == 0 || rtbNum2.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the numbers.");
                    return;
                }

                double Num1;
                double Num2;

                // If the values in the text boxes are not a valid integer, then tell the user to enter valid numbers.
                if (!double.TryParse(rtbNum1.Text, out Num1) || !double.TryParse(rtbNum2.Text, out Num2))
                {
                    MessageBox.Show("Not valid numbers.");
                    return;
                }

                rtbAddition.Text = Convert.ToString(Num1 + Num2);
                rtbSubtraction.Text = Convert.ToString(Num1 - Num2);
                rtbMultiplication.Text = Convert.ToString(Num1 * Num2);
                rtbDivision.Text = Convert.ToString(Num1 / Num2);
                rtbModulus.Text = Convert.ToString(Num1 % Num2);
            }
        }
    }
}
