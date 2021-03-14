namespace Assignment4
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
            this.startGameBtn = new System.Windows.Forms.Button();
            this.player1StatsLbl = new System.Windows.Forms.Label();
            this.player2StatsLbl = new System.Windows.Forms.Label();
            this.tiesLbl = new System.Windows.Forms.Label();
            this.gameStatusGB = new System.Windows.Forms.GroupBox();
            this.gameStatusLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.gameStatusGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(31, 22);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(75, 23);
            this.startGameBtn.TabIndex = 0;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // player1StatsLbl
            // 
            this.player1StatsLbl.AutoSize = true;
            this.player1StatsLbl.BackColor = System.Drawing.Color.OrangeRed;
            this.player1StatsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1StatsLbl.Location = new System.Drawing.Point(28, 71);
            this.player1StatsLbl.Name = "player1StatsLbl";
            this.player1StatsLbl.Size = new System.Drawing.Size(80, 15);
            this.player1StatsLbl.TabIndex = 1;
            this.player1StatsLbl.Text = "Player 1 Wins: ";
            // 
            // player2StatsLbl
            // 
            this.player2StatsLbl.AutoSize = true;
            this.player2StatsLbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.player2StatsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2StatsLbl.Location = new System.Drawing.Point(28, 114);
            this.player2StatsLbl.Name = "player2StatsLbl";
            this.player2StatsLbl.Size = new System.Drawing.Size(80, 15);
            this.player2StatsLbl.TabIndex = 2;
            this.player2StatsLbl.Text = "Player 2 Wins: ";
            // 
            // tiesLbl
            // 
            this.tiesLbl.AutoSize = true;
            this.tiesLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiesLbl.Location = new System.Drawing.Point(28, 159);
            this.tiesLbl.Name = "tiesLbl";
            this.tiesLbl.Size = new System.Drawing.Size(35, 15);
            this.tiesLbl.TabIndex = 3;
            this.tiesLbl.Text = "Ties: ";
            // 
            // gameStatusGB
            // 
            this.gameStatusGB.BackColor = System.Drawing.Color.White;
            this.gameStatusGB.Controls.Add(this.gameStatusLbl);
            this.gameStatusGB.Location = new System.Drawing.Point(12, 198);
            this.gameStatusGB.Name = "gameStatusGB";
            this.gameStatusGB.Size = new System.Drawing.Size(132, 43);
            this.gameStatusGB.TabIndex = 13;
            this.gameStatusGB.TabStop = false;
            this.gameStatusGB.Text = "Game Status";
            // 
            // gameStatusLbl
            // 
            this.gameStatusLbl.AutoSize = true;
            this.gameStatusLbl.Location = new System.Drawing.Point(16, 19);
            this.gameStatusLbl.Name = "gameStatusLbl";
            this.gameStatusLbl.Size = new System.Drawing.Size(0, 13);
            this.gameStatusLbl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(164, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 14;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(243, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(322, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(164, 90);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(243, 90);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(322, 90);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 17;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(164, 169);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 22;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(243, 169);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 21;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(322, 169);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 20;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameStatusGB);
            this.Controls.Add(this.tiesLbl);
            this.Controls.Add(this.player2StatsLbl);
            this.Controls.Add(this.player1StatsLbl);
            this.Controls.Add(this.startGameBtn);
            this.MaximumSize = new System.Drawing.Size(424, 292);
            this.MinimumSize = new System.Drawing.Size(424, 292);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.gameStatusGB.ResumeLayout(false);
            this.gameStatusGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Label player1StatsLbl;
        private System.Windows.Forms.Label player2StatsLbl;
        private System.Windows.Forms.Label tiesLbl;
        private System.Windows.Forms.GroupBox gameStatusGB;
        private System.Windows.Forms.Label gameStatusLbl;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button1;
    }
}

