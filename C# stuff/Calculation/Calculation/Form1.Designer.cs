namespace Calculation
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
            this.rtbNum1 = new System.Windows.Forms.RichTextBox();
            this.rtbNum2 = new System.Windows.Forms.RichTextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.rtbSubtraction = new System.Windows.Forms.RichTextBox();
            this.rtbAddition = new System.Windows.Forms.RichTextBox();
            this.rtbDivision = new System.Windows.Forms.RichTextBox();
            this.rtbMultiplication = new System.Windows.Forms.RichTextBox();
            this.rtbModulus = new System.Windows.Forms.RichTextBox();
            this.lblSubtraction = new System.Windows.Forms.Label();
            this.lblAddition = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblMultiplication = new System.Windows.Forms.Label();
            this.lblModulus = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbNum1
            // 
            this.rtbNum1.Location = new System.Drawing.Point(183, 59);
            this.rtbNum1.Name = "rtbNum1";
            this.rtbNum1.Size = new System.Drawing.Size(125, 29);
            this.rtbNum1.TabIndex = 0;
            this.rtbNum1.Text = "";
            this.rtbNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_KeyDown);
            // 
            // rtbNum2
            // 
            this.rtbNum2.Location = new System.Drawing.Point(183, 94);
            this.rtbNum2.Name = "rtbNum2";
            this.rtbNum2.Size = new System.Drawing.Size(125, 29);
            this.rtbNum2.TabIndex = 1;
            this.rtbNum2.Text = "";
            this.rtbNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_KeyDown);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(128, 62);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(50, 13);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Number1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(128, 97);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(50, 13);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "Number2";
            // 
            // rtbSubtraction
            // 
            this.rtbSubtraction.Location = new System.Drawing.Point(183, 243);
            this.rtbSubtraction.Name = "rtbSubtraction";
            this.rtbSubtraction.ReadOnly = true;
            this.rtbSubtraction.Size = new System.Drawing.Size(125, 29);
            this.rtbSubtraction.TabIndex = 5;
            this.rtbSubtraction.Text = "";
            // 
            // rtbAddition
            // 
            this.rtbAddition.Location = new System.Drawing.Point(183, 208);
            this.rtbAddition.Name = "rtbAddition";
            this.rtbAddition.ReadOnly = true;
            this.rtbAddition.Size = new System.Drawing.Size(125, 29);
            this.rtbAddition.TabIndex = 4;
            this.rtbAddition.Text = "";
            // 
            // rtbDivision
            // 
            this.rtbDivision.Location = new System.Drawing.Point(183, 313);
            this.rtbDivision.Name = "rtbDivision";
            this.rtbDivision.ReadOnly = true;
            this.rtbDivision.Size = new System.Drawing.Size(125, 29);
            this.rtbDivision.TabIndex = 7;
            this.rtbDivision.Text = "";
            // 
            // rtbMultiplication
            // 
            this.rtbMultiplication.Location = new System.Drawing.Point(183, 278);
            this.rtbMultiplication.Name = "rtbMultiplication";
            this.rtbMultiplication.ReadOnly = true;
            this.rtbMultiplication.Size = new System.Drawing.Size(125, 29);
            this.rtbMultiplication.TabIndex = 6;
            this.rtbMultiplication.Text = "";
            // 
            // rtbModulus
            // 
            this.rtbModulus.Location = new System.Drawing.Point(183, 348);
            this.rtbModulus.Name = "rtbModulus";
            this.rtbModulus.ReadOnly = true;
            this.rtbModulus.Size = new System.Drawing.Size(125, 29);
            this.rtbModulus.TabIndex = 8;
            this.rtbModulus.Text = "";
            // 
            // lblSubtraction
            // 
            this.lblSubtraction.AutoSize = true;
            this.lblSubtraction.Location = new System.Drawing.Point(116, 246);
            this.lblSubtraction.Name = "lblSubtraction";
            this.lblSubtraction.Size = new System.Drawing.Size(61, 13);
            this.lblSubtraction.TabIndex = 10;
            this.lblSubtraction.Text = "Subtraction";
            // 
            // lblAddition
            // 
            this.lblAddition.AutoSize = true;
            this.lblAddition.Location = new System.Drawing.Point(127, 211);
            this.lblAddition.Name = "lblAddition";
            this.lblAddition.Size = new System.Drawing.Size(45, 13);
            this.lblAddition.TabIndex = 9;
            this.lblAddition.Text = "Addition";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(127, 316);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(42, 13);
            this.lblDivision.TabIndex = 12;
            this.lblDivision.Text = "Divison";
            // 
            // lblMultiplication
            // 
            this.lblMultiplication.AutoSize = true;
            this.lblMultiplication.Location = new System.Drawing.Point(109, 281);
            this.lblMultiplication.Name = "lblMultiplication";
            this.lblMultiplication.Size = new System.Drawing.Size(68, 13);
            this.lblMultiplication.TabIndex = 11;
            this.lblMultiplication.Text = "Multiplication";
            // 
            // lblModulus
            // 
            this.lblModulus.AutoSize = true;
            this.lblModulus.Location = new System.Drawing.Point(128, 351);
            this.lblModulus.Name = "lblModulus";
            this.lblModulus.Size = new System.Drawing.Size(47, 13);
            this.lblModulus.TabIndex = 13;
            this.lblModulus.Text = "Modulus";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(187, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(121, 13);
            this.lblInstruction.TabIndex = 14;
            this.lblInstruction.Text = "Press enter to calculate.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 532);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblModulus);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplication);
            this.Controls.Add(this.lblSubtraction);
            this.Controls.Add(this.lblAddition);
            this.Controls.Add(this.rtbModulus);
            this.Controls.Add(this.rtbDivision);
            this.Controls.Add(this.rtbMultiplication);
            this.Controls.Add(this.rtbSubtraction);
            this.Controls.Add(this.rtbAddition);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.rtbNum2);
            this.Controls.Add(this.rtbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNum1;
        private System.Windows.Forms.RichTextBox rtbNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.RichTextBox rtbSubtraction;
        private System.Windows.Forms.RichTextBox rtbAddition;
        private System.Windows.Forms.RichTextBox rtbDivision;
        private System.Windows.Forms.RichTextBox rtbMultiplication;
        private System.Windows.Forms.RichTextBox rtbModulus;
        private System.Windows.Forms.Label lblSubtraction;
        private System.Windows.Forms.Label lblAddition;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblMultiplication;
        private System.Windows.Forms.Label lblModulus;
        private System.Windows.Forms.Label lblInstruction;
    }
}

