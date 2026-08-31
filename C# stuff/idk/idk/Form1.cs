namespace idk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            while (true)
            {
                bird.Location = new Point(bird.Location.X + 1, 0);
                Thread.Sleep(3);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
