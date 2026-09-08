using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method to make it look cleaner.
            string caption = "Music";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string favouriteBand;

            // Displays the MessageBox.
            result = MessageBox.Show("Do you like music?", caption, buttons);

            // If they click yes, then ask the band question.
            if (result == DialogResult.Yes)
            {
                // Needed to add visual basic as a reference here, because i don't think C# has an equivalent to an InputBox.
                favouriteBand = Interaction.InputBox("What is your favourite band?");
                MessageBox.Show($"You are a loyal fan of {favouriteBand}", "Favourite Band");
            }
            else
            {
                result = MessageBox.Show("Are you sure?", caption, buttons);

                if (result == DialogResult.No)
                {
                    favouriteBand = Interaction.InputBox("What is your favourite band?");
                    MessageBox.Show($"You are a loyal fan of {favouriteBand}", "Favourite Band");
                }
            }

                Application.Exit();
        }
    }
}
