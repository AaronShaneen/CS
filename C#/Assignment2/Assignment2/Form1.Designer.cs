namespace Assignment2
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
            this.diceLbl = new System.Windows.Forms.Label();
            this.playedLbl = new System.Windows.Forms.Label();
            this.guessTB = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.rollBtn = new System.Windows.Forms.Button();
            this.statRTB = new System.Windows.Forms.RichTextBox();
            this.guessLbl = new System.Windows.Forms.Label();
            this.wonLbl = new System.Windows.Forms.Label();
            this.lostLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diceLbl
            // 
            this.diceLbl.Image = global::Assignment2.Properties.Resources.die6;
            this.diceLbl.Location = new System.Drawing.Point(25, 25);
            this.diceLbl.MaximumSize = new System.Drawing.Size(60, 54);
            this.diceLbl.MinimumSize = new System.Drawing.Size(60, 54);
            this.diceLbl.Name = "diceLbl";
            this.diceLbl.Size = new System.Drawing.Size(60, 54);
            this.diceLbl.TabIndex = 0;
            // 
            // playedLbl
            // 
            this.playedLbl.AutoSize = true;
            this.playedLbl.Location = new System.Drawing.Point(132, 19);
            this.playedLbl.Name = "playedLbl";
            this.playedLbl.Size = new System.Drawing.Size(81, 13);
            this.playedLbl.TabIndex = 1;
            this.playedLbl.Text = "Games Played: ";
            // 
            // guessTB
            // 
            this.guessTB.Location = new System.Drawing.Point(12, 123);
            this.guessTB.Name = "guessTB";
            this.guessTB.Size = new System.Drawing.Size(100, 20);
            this.guessTB.TabIndex = 2;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(216, 120);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 25);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // rollBtn
            // 
            this.rollBtn.Location = new System.Drawing.Point(135, 120);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(75, 25);
            this.rollBtn.TabIndex = 4;
            this.rollBtn.Text = "ROLL";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // statRTB
            // 
            this.statRTB.Location = new System.Drawing.Point(12, 152);
            this.statRTB.Name = "statRTB";
            this.statRTB.Size = new System.Drawing.Size(279, 150);
            this.statRTB.TabIndex = 5;
            this.statRTB.Text = "\n";
            // 
            // guessLbl
            // 
            this.guessLbl.AutoSize = true;
            this.guessLbl.Location = new System.Drawing.Point(12, 107);
            this.guessLbl.Name = "guessLbl";
            this.guessLbl.Size = new System.Drawing.Size(97, 13);
            this.guessLbl.TabIndex = 6;
            this.guessLbl.Text = "Enter a number 1-6";
            // 
            // wonLbl
            // 
            this.wonLbl.AutoSize = true;
            this.wonLbl.Location = new System.Drawing.Point(132, 47);
            this.wonLbl.Name = "wonLbl";
            this.wonLbl.Size = new System.Drawing.Size(72, 13);
            this.wonLbl.TabIndex = 7;
            this.wonLbl.Text = "Games Won: ";
            // 
            // lostLbl
            // 
            this.lostLbl.AutoSize = true;
            this.lostLbl.Location = new System.Drawing.Point(132, 75);
            this.lostLbl.Name = "lostLbl";
            this.lostLbl.Size = new System.Drawing.Size(69, 13);
            this.lostLbl.TabIndex = 8;
            this.lostLbl.Text = "Games Lost: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 316);
            this.Controls.Add(this.lostLbl);
            this.Controls.Add(this.wonLbl);
            this.Controls.Add(this.guessLbl);
            this.Controls.Add(this.statRTB);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.guessTB);
            this.Controls.Add(this.playedLbl);
            this.Controls.Add(this.diceLbl);
            this.MaximumSize = new System.Drawing.Size(325, 355);
            this.MinimumSize = new System.Drawing.Size(325, 355);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diceLbl;
        private System.Windows.Forms.Label playedLbl;
        private System.Windows.Forms.TextBox guessTB;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.RichTextBox statRTB;
        private System.Windows.Forms.Label guessLbl;
        private System.Windows.Forms.Label wonLbl;
        private System.Windows.Forms.Label lostLbl;
    }
}

