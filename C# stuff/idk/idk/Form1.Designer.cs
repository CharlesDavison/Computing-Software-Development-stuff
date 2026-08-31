namespace idk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bird = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            SuspendLayout();
            // 
            // bird
            // 
            bird.Image = (Image)resources.GetObject("bird.Image");
            bird.Location = new Point(0, 0);
            bird.Name = "bird";
            bird.Size = new Size(97, 74);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 0;
            bird.TabStop = false;
            bird.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bird);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bird;
    }
}
