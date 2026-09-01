using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLook
{
    public partial class Form1 : Form
    {

        private int jumpVelocity = 0;
        private const int Gravity = 1;
        private Timer gameTimer;
        private Random rnd = new Random();
        private int Score = 0;

        public Form1()
        {
            InitializeComponent();

            btnJump.Enabled = false;

            gameTimer = new Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += GameTimer_Tick;

            pctBird.Location = new Point(300, 200);

            pctPipeBottom.Location = new Point(800, 400);
            pctPipeTop.Location = new Point(800, -500);
        }


        // Bird player
        private void pctBird_Click(object sender, EventArgs e)
        {

        }

        // Game loop
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Gravity
            jumpVelocity += Gravity;

            pctBird.Top += jumpVelocity;

            // Pipes + Score
            pctPipeTop.Left -= 5;
            pctPipeBottom.Left -= 5;

            if (pctPipeBottom.Location.X < 0)
            {
                int newY = rnd.Next(300, 500);
                pctPipeBottom.Location = new Point(800, newY);
                pctPipeTop.Location = new Point(800, newY - 900);

                Score++;
                lblScore.Text = Score.ToString();
            }

            // Death Detection
            if (pctBird.Location.Y > 558)
            {
                die();
            }

            if (pctBird.Bounds.IntersectsWith(pctPipeTop.Bounds) || pctBird.Bounds.IntersectsWith(pctPipeBottom.Bounds))
            {
                die();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jump();
        }

        private void Jump()
        {
            jumpVelocity = -10;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void die()
        {
            gameTimer.Stop();

            pctBird.Enabled = false;

            btnJump.Enabled = false;

            pctPipeBottom.Enabled = false;
            pctPipeTop.Enabled = false;

            lblScore.Visible = false;

            lblGameOver.Text = "Game Over!\nScore: " + Score.ToString();
            lblGameOver.Enabled = true;
            lblGameOver.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblStart.Visible = false;
            btnJump.Enabled = true;

            btnStart.Visible = false;
            btnStart.Enabled = false;
            lblScore.Visible = true;

            gameTimer.Start();
        }
    }
}
