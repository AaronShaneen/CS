namespace Assignment5
{
    partial class GameForm
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
            this.gamePnl = new System.Windows.Forms.Panel();
            this.gameSelectPnl = new System.Windows.Forms.Panel();
            this.divisionGameBtn = new System.Windows.Forms.Button();
            this.multiplyGameBtn = new System.Windows.Forms.Button();
            this.subtractGameBtn = new System.Windows.Forms.Button();
            this.addGameBtn = new System.Windows.Forms.Button();
            this.gameTypeLbl = new System.Windows.Forms.Label();
            this.correctLbl = new System.Windows.Forms.Label();
            this.guessTB = new System.Windows.Forms.TextBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.gamePnl.SuspendLayout();
            this.gameSelectPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePnl
            // 
            this.gamePnl.Controls.Add(this.correctLbl);
            this.gamePnl.Controls.Add(this.guessTB);
            this.gamePnl.Controls.Add(this.questionLbl);
            this.gamePnl.Controls.Add(this.cancelBtn);
            this.gamePnl.Controls.Add(this.submitBtn);
            this.gamePnl.Controls.Add(this.startBtn);
            this.gamePnl.Location = new System.Drawing.Point(12, 12);
            this.gamePnl.Name = "gamePnl";
            this.gamePnl.Size = new System.Drawing.Size(260, 237);
            this.gamePnl.TabIndex = 0;
            // 
            // gameSelectPnl
            // 
            this.gameSelectPnl.Controls.Add(this.divisionGameBtn);
            this.gameSelectPnl.Controls.Add(this.multiplyGameBtn);
            this.gameSelectPnl.Controls.Add(this.subtractGameBtn);
            this.gameSelectPnl.Controls.Add(this.addGameBtn);
            this.gameSelectPnl.Controls.Add(this.gameTypeLbl);
            this.gameSelectPnl.Location = new System.Drawing.Point(12, 12);
            this.gameSelectPnl.Name = "gameSelectPnl";
            this.gameSelectPnl.Size = new System.Drawing.Size(260, 237);
            this.gameSelectPnl.TabIndex = 40;
            // 
            // divisionGameBtn
            // 
            this.divisionGameBtn.Location = new System.Drawing.Point(90, 195);
            this.divisionGameBtn.Name = "divisionGameBtn";
            this.divisionGameBtn.Size = new System.Drawing.Size(81, 23);
            this.divisionGameBtn.TabIndex = 48;
            this.divisionGameBtn.Text = "Division";
            this.divisionGameBtn.UseVisualStyleBackColor = true;
            this.divisionGameBtn.Click += new System.EventHandler(this.divisionGameBtn_Click);
            // 
            // multiplyGameBtn
            // 
            this.multiplyGameBtn.Location = new System.Drawing.Point(90, 144);
            this.multiplyGameBtn.Name = "multiplyGameBtn";
            this.multiplyGameBtn.Size = new System.Drawing.Size(81, 23);
            this.multiplyGameBtn.TabIndex = 47;
            this.multiplyGameBtn.Text = "Multiplication";
            this.multiplyGameBtn.UseVisualStyleBackColor = true;
            this.multiplyGameBtn.Click += new System.EventHandler(this.multiplyGameBtn_Click);
            // 
            // subtractGameBtn
            // 
            this.subtractGameBtn.Location = new System.Drawing.Point(90, 91);
            this.subtractGameBtn.Name = "subtractGameBtn";
            this.subtractGameBtn.Size = new System.Drawing.Size(81, 23);
            this.subtractGameBtn.TabIndex = 46;
            this.subtractGameBtn.Text = "Subtraction";
            this.subtractGameBtn.UseVisualStyleBackColor = true;
            this.subtractGameBtn.Click += new System.EventHandler(this.subtractGameBtn_Click);
            // 
            // addGameBtn
            // 
            this.addGameBtn.Location = new System.Drawing.Point(90, 41);
            this.addGameBtn.Name = "addGameBtn";
            this.addGameBtn.Size = new System.Drawing.Size(81, 23);
            this.addGameBtn.TabIndex = 45;
            this.addGameBtn.Text = "Addition";
            this.addGameBtn.UseVisualStyleBackColor = true;
            this.addGameBtn.Click += new System.EventHandler(this.addGameBtn_Click);
            // 
            // gameTypeLbl
            // 
            this.gameTypeLbl.AutoSize = true;
            this.gameTypeLbl.Location = new System.Drawing.Point(14, 19);
            this.gameTypeLbl.Name = "gameTypeLbl";
            this.gameTypeLbl.Size = new System.Drawing.Size(233, 13);
            this.gameTypeLbl.TabIndex = 44;
            this.gameTypeLbl.Text = "What type of math game would you like to play?";
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.Location = new System.Drawing.Point(102, 147);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(61, 13);
            this.correctLbl.TabIndex = 39;
            this.correctLbl.Text = "right/wrong";
            // 
            // guessTB
            // 
            this.guessTB.Location = new System.Drawing.Point(171, 79);
            this.guessTB.Name = "guessTB";
            this.guessTB.Size = new System.Drawing.Size(49, 20);
            this.guessTB.TabIndex = 38;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Location = new System.Drawing.Point(41, 82);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(47, 13);
            this.questionLbl.TabIndex = 37;
            this.questionLbl.Text = "question";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(145, 211);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 36;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(44, 211);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 35;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(88, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 34;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gameSelectPnl);
            this.Controls.Add(this.gamePnl);
            this.Name = "GameForm";
            this.Text = "Game Select";
            this.Load += new System.EventHandler(this.GameSelectForm_Load);
            this.gamePnl.ResumeLayout(false);
            this.gamePnl.PerformLayout();
            this.gameSelectPnl.ResumeLayout(false);
            this.gameSelectPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePnl;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.TextBox guessTB;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel gameSelectPnl;
        private System.Windows.Forms.Button divisionGameBtn;
        private System.Windows.Forms.Button multiplyGameBtn;
        private System.Windows.Forms.Button subtractGameBtn;
        private System.Windows.Forms.Button addGameBtn;
        private System.Windows.Forms.Label gameTypeLbl;



    }
}