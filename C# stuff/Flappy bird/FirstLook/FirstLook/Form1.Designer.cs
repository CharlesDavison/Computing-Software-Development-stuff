namespace FirstLook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctBird = new System.Windows.Forms.PictureBox();
            this.btnJump = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pctPipeBottom = new System.Windows.Forms.PictureBox();
            this.pctPipeTop = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBird
            // 
            this.pctBird.Image = ((System.Drawing.Image)(resources.GetObject("pctBird.Image")));
            this.pctBird.Location = new System.Drawing.Point(300, 200);
            this.pctBird.Name = "pctBird";
            this.pctBird.Size = new System.Drawing.Size(95, 78);
            this.pctBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBird.TabIndex = 0;
            this.pctBird.TabStop = false;
            this.pctBird.Click += new System.EventHandler(this.pctBird_Click);
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(292, 564);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(129, 105);
            this.btnJump.TabIndex = 1;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(423, 72);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(460, 39);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Click the start button to start.";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(950, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 105);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pctPipeBottom
            // 
            this.pctPipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pctPipeBottom.Image")));
            this.pctPipeBottom.Location = new System.Drawing.Point(800, 432);
            this.pctPipeBottom.Name = "pctPipeBottom";
            this.pctPipeBottom.Size = new System.Drawing.Size(100, 387);
            this.pctPipeBottom.TabIndex = 5;
            this.pctPipeBottom.TabStop = false;
            // 
            // pctPipeTop
            // 
            this.pctPipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pctPipeTop.Image")));
            this.pctPipeTop.Location = new System.Drawing.Point(800, -500);
            this.pctPipeTop.Name = "pctPipeTop";
            this.pctPipeTop.Size = new System.Drawing.Size(100, 672);
            this.pctPipeTop.TabIndex = 6;
            this.pctPipeTop.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1267, 685);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Enabled = false;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(448, 246);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(349, 110);
            this.lblGameOver.TabIndex = 8;
            this.lblGameOver.Text = "0";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(423, 72);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(460, 39);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(292, 564);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 105);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.pctBird);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.pctPipeTop);
            this.Controls.Add(this.pctPipeBottom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Balls";
            ((System.ComponentModel.ISupportInitialize)(this.pctBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBird;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pctPipeBottom;
        private System.Windows.Forms.PictureBox pctPipeTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStart;
    }
}

