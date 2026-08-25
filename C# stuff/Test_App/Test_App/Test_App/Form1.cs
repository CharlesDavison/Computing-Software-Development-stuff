namespace Test_App
{
    public partial class Form1 : Form
    {

        String Button3Text = "Change This Text";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Balls", "BallsTitle");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Button3Text == "Change This Text")
            {
                Button3Text = "Text Has been changed";
                button3.Text = Button3Text;
            } else
            {
                Button3Text = "Change This Text";
                button3.Text = Button3Text;
            }
        }
    }
}
