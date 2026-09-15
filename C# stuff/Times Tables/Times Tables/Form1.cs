using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Times_Tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            lbFinal.Items.Clear();

            if (rtbStart.Text.Length == 0 || rtbEnd.Text.Length == 0)
            {
                MessageBox.Show("Fill in the numbers.");
                return;
            }

            int startLoop;
            int endLoop;

            if (!int.TryParse(rtbStart.Text, out startLoop) || !int.TryParse(rtbEnd.Text, out endLoop))
            {
                MessageBox.Show("Not valid integers.");
                return;
            }

            for (int i = startLoop; i < endLoop+1; i++)
            {
                lbFinal.Items.Add((i * 10).ToString());
            }
        }
    }
}
