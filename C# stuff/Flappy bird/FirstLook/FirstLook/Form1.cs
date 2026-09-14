// The majority of these are unused, but idk if removing them will break something. ¯\_(ツ)_/¯
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FirstLook
{
    public partial class Form1 : Form
    {
        // Global variabled are initialised here.
        private int jumpVelocity = 0;
        private const int Gravity = 1;
        private Timer gameTimer;
        private Random rnd = new Random();
        private int Score = 0;

        // Start button clicked. Hides the start button and shows the jump button, and starts the game timer.
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Shit happens.
            lblStart.Visible = false;
            btnJump.Enabled = true;

            btnStart.Visible = false;
            btnStart.Enabled = false;
            lblScore.Visible = true;
            lblTitle.Visible = false;
            lblHighScore.Visible = true;
            btnRestart.Visible = false;

            gameTimer.Start();
        }

        // Exit button. Closes the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Jump button clicked.
        private void button1_Click(object sender, EventArgs e)
        {
            jumpVelocity = -10;
        }

        // Game loop
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Gravity and jumping.
            jumpVelocity += Gravity;

            pctBird.Top += jumpVelocity;

            // Pipes + Score
            pctPipeTop.Left -= 5;
            pctPipeBottom.Left -= 5;

            // When the pipes reach the edge of the screen, move them back at a random height, and increment the score.
            if (pctPipeBottom.Location.X < 0)
            {
                // Pick a random position for the pipes to be in.
                int newY = rnd.Next(300, 500);
                pctPipeBottom.Location = new Point(800, newY);
                pctPipeTop.Location = new Point(800, newY - 900);

                // Add a point, and update the counter.
                Score++;
                lblScore.Text = Score.ToString();
            }

            // Death Detection
            // If the bird goes off screen, or falls, it dies.
            if (pctBird.Location.Y > 558 || pctBird.Location.Y < 0)
            {
                // die
                die();
            }

            // Cool af function that means i don't have to do any annoying maths to figure out collision. Also, if touch pipe then die.
            if (pctBird.Bounds.IntersectsWith(pctPipeTop.Bounds) || pctBird.Bounds.IntersectsWith(pctPipeBottom.Bounds))
            {
                // die
                die();
            }
        }
        
        // Saves the highscore to a text file and appends a message to lblGameOver if the score is higher than the previous highscore. If the file doesn't exist, it creates it. If the file is empty or has invalid data, it sets the highscore to 0.
        private void saveHighScore()
        {
            // It tries to parse file for a score. If it succeeds, it goes into highscore. If it fails, it sets highscore to 0.
            if (!int.TryParse(File.ReadAllText("score.txt"), out int highScore))
            {
                highScore = 0;
            }

            // If the highscore from the file is less than the current score, it overwrites the contents of the score file with the current score.
            if (Score > highScore)
            {
                File.WriteAllText("score.txt", Score.ToString());
                lblGameOver.Text += "\nNew High Score!";
            }
        }

        // loads the highscore from a text file and displays it in lblHighScore.
        private void loadHighScore()
        {
            // If the score file doesn't exist, make it. This only happens in this function as it's the first function that accesses the file to run, and saveHighScore can not physically run unless this has run first. If it does run before this one, something has gone TERRIBLY WRONG.
            if (!File.Exists("score.txt"))
            {
                try
                {
                    File.Create("score.txt").Close();
                }
                // If it fails at all, it will error and exit after a bit.
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating score.txt: " + ex.Message);
                    Task.Delay(10000).Wait();
                    Application.Exit();
                }
            }

            // It tries to parse file for a score. If it succeeds, it goes into highscore. If it fails, it sets highscore to 0.
            if (!int.TryParse(File.ReadAllText("score.txt"), out int highScore))
            {
                highScore = 0;
            }

            lblHighScore.Text = "High Score: " + highScore.ToString();

            lblTitle.Text = "Bird Game\nHigh Score: " + highScore.ToString();
            lblHighScore.Text = "High Score: " + highScore.ToString();
        }

        // Bird player clicked
        private void pctBird_Click(object sender, EventArgs e)
        {
            // Nothing happens, but if i delete it, everything breaks. Could make an easter egg. That would be cool.
        }

        private void startGame()
        {
            // Get high score from file
            loadHighScore();

            // So you don't accidentally click the jump button before the game starts. I don't know if microsoft has weird things about stuff.
            btnJump.Enabled = false;


            // Make sure the bird and pipes are in the right place, in case i accidentally move them in the designer.
            pctBird.Location = new Point(300, 200);
            pctPipeBottom.Location = new Point(800, 400);
            pctPipeTop.Location = new Point(800, -500);

            // Pick a random position for the pipes to be in for the start.
            int newY = rnd.Next(300, 500);
            pctPipeBottom.Location = new Point(800, newY);
            pctPipeTop.Location = new Point(800, newY - 900);

            // The game timer. This is what makes the game run. It runs the GameTimer_Tick function every 16 milliseconds, which is about 60 times per second.
            gameTimer = new Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += GameTimer_Tick;
        }

        // This function is called when the player dies. It stops the game, disables the jump button, and shows the game over screen.
        private void die()
        {
            // Stop the game loop.
            gameTimer.Stop();

            // Shit happens
            pctBird.Visible = false;
            pctBird.Enabled = false;

            btnJump.Enabled = false;
            btnJump.Visible = false;

            pctPipeBottom.Enabled = false;
            pctPipeTop.Enabled = false;

            lblScore.Visible = false;
            lblHighScore.Visible = false;


            lblGameOver.Text = "Game Over!\nScore: " + Score.ToString();
            lblGameOver.Enabled = true;
            lblGameOver.Visible = true;
            btnRestart.Visible = true;

            saveHighScore();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pctBird.Visible = true;
            pctBird.Enabled = true;

            btnJump.Visible = true;

            pctPipeBottom.Enabled = true;
            pctPipeTop.Enabled = true;

            lblScore.Visible = true;
            lblHighScore.Visible = true;


            lblGameOver.Enabled = false;
            lblGameOver.Visible = false;
            btnRestart.Visible = false;

            jumpVelocity = 0;
            Score = 0;
            lblScore.Text = "0";


            btnStart.Visible = true;
            btnStart.Enabled = true;

            startGame();
        }

        // Everything in here gets ran immediately when the program starts.
        public Form1()
        {
            // idk. autogenerated
            InitializeComponent();

            // Start the game loop.
            startGame();
        }

    }
}
