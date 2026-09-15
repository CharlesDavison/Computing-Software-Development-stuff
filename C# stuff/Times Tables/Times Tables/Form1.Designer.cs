namespace Times_Tables
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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.rtbStart = new System.Windows.Forms.RichTextBox();
            this.rtbEnd = new System.Windows.Forms.RichTextBox();
            this.btnLoop = new System.Windows.Forms.Button();
            this.lbFinal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(7, 43);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(181, 39);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Loop start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(17, 119);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(171, 39);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "Loop End";
            // 
            // rtbStart
            // 
            this.rtbStart.Location = new System.Drawing.Point(194, 43);
            this.rtbStart.Name = "rtbStart";
            this.rtbStart.Size = new System.Drawing.Size(100, 38);
            this.rtbStart.TabIndex = 2;
            this.rtbStart.Text = "";
            // 
            // rtbEnd
            // 
            this.rtbEnd.Location = new System.Drawing.Point(194, 119);
            this.rtbEnd.Name = "rtbEnd";
            this.rtbEnd.Size = new System.Drawing.Size(100, 38);
            this.rtbEnd.TabIndex = 3;
            this.rtbEnd.Text = "";
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(300, 81);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(124, 42);
            this.btnLoop.TabIndex = 4;
            this.btnLoop.Text = "Start Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // lbFinal
            // 
            this.lbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinal.FormattingEnabled = true;
            this.lbFinal.ItemHeight = 20;
            this.lbFinal.Location = new System.Drawing.Point(79, 225);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(272, 244);
            this.lbFinal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 520);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.rtbEnd);
            this.Controls.Add(this.rtbStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.RichTextBox rtbStart;
        private System.Windows.Forms.RichTextBox rtbEnd;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.ListBox lbFinal;
    }
}

