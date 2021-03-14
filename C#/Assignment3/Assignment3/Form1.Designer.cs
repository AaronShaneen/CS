namespace Assignment3
{
    partial class StudentScoreForm
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
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.numOfAssTB = new System.Windows.Forms.TextBox();
            this.numOfStudsTB = new System.Windows.Forms.TextBox();
            this.numOfAssLbl = new System.Windows.Forms.Label();
            this.numOfStudsLbl = new System.Windows.Forms.Label();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.lastStudBtn = new System.Windows.Forms.Button();
            this.nextStudBtn = new System.Windows.Forms.Button();
            this.prevStudBtn = new System.Windows.Forms.Button();
            this.firstStudBtn = new System.Windows.Forms.Button();
            this.GB3 = new System.Windows.Forms.GroupBox();
            this.saveStudBtn = new System.Windows.Forms.Button();
            this.studentNameTB = new System.Windows.Forms.TextBox();
            this.studentNumLbl = new System.Windows.Forms.Label();
            this.GB4 = new System.Windows.Forms.GroupBox();
            this.saveScoreBtn = new System.Windows.Forms.Button();
            this.assScoreTB = new System.Windows.Forms.TextBox();
            this.assNumTB = new System.Windows.Forms.TextBox();
            this.assScoreLbl = new System.Windows.Forms.Label();
            this.assNumLbl = new System.Windows.Forms.Label();
            this.scoresRTB = new System.Windows.Forms.RichTextBox();
            this.displayScoreBtn = new System.Windows.Forms.Button();
            this.outputBtn = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.GB1.SuspendLayout();
            this.GB2.SuspendLayout();
            this.GB3.SuspendLayout();
            this.GB4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.resetBtn);
            this.GB1.Controls.Add(this.submitBtn);
            this.GB1.Controls.Add(this.numOfAssTB);
            this.GB1.Controls.Add(this.numOfStudsTB);
            this.GB1.Controls.Add(this.numOfAssLbl);
            this.GB1.Controls.Add(this.numOfStudsLbl);
            this.GB1.Location = new System.Drawing.Point(12, 12);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(460, 71);
            this.GB1.TabIndex = 0;
            this.GB1.TabStop = false;
            this.GB1.Text = "Counts";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(370, 18);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(285, 18);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // numOfAssTB
            // 
            this.numOfAssTB.Location = new System.Drawing.Point(170, 40);
            this.numOfAssTB.Name = "numOfAssTB";
            this.numOfAssTB.Size = new System.Drawing.Size(100, 20);
            this.numOfAssTB.TabIndex = 3;
            // 
            // numOfStudsTB
            // 
            this.numOfStudsTB.Location = new System.Drawing.Point(170, 18);
            this.numOfStudsTB.Name = "numOfStudsTB";
            this.numOfStudsTB.Size = new System.Drawing.Size(100, 20);
            this.numOfStudsTB.TabIndex = 2;
            // 
            // numOfAssLbl
            // 
            this.numOfAssLbl.AutoSize = true;
            this.numOfAssLbl.Location = new System.Drawing.Point(41, 43);
            this.numOfAssLbl.Name = "numOfAssLbl";
            this.numOfAssLbl.Size = new System.Drawing.Size(121, 13);
            this.numOfAssLbl.TabIndex = 1;
            this.numOfAssLbl.Text = "Number of Assignments:";
            // 
            // numOfStudsLbl
            // 
            this.numOfStudsLbl.AutoSize = true;
            this.numOfStudsLbl.Location = new System.Drawing.Point(41, 21);
            this.numOfStudsLbl.Name = "numOfStudsLbl";
            this.numOfStudsLbl.Size = new System.Drawing.Size(104, 13);
            this.numOfStudsLbl.TabIndex = 0;
            this.numOfStudsLbl.Text = "Number of Students:";
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.lastStudBtn);
            this.GB2.Controls.Add(this.nextStudBtn);
            this.GB2.Controls.Add(this.prevStudBtn);
            this.GB2.Controls.Add(this.firstStudBtn);
            this.GB2.Location = new System.Drawing.Point(12, 89);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(460, 56);
            this.GB2.TabIndex = 1;
            this.GB2.TabStop = false;
            this.GB2.Text = "Navigate";
            // 
            // lastStudBtn
            // 
            this.lastStudBtn.Location = new System.Drawing.Point(332, 19);
            this.lastStudBtn.Name = "lastStudBtn";
            this.lastStudBtn.Size = new System.Drawing.Size(94, 23);
            this.lastStudBtn.TabIndex = 3;
            this.lastStudBtn.Text = "Last Student >>";
            this.lastStudBtn.UseVisualStyleBackColor = true;
            this.lastStudBtn.Click += new System.EventHandler(this.lastStudBtn_Click);
            // 
            // nextStudBtn
            // 
            this.nextStudBtn.Location = new System.Drawing.Point(232, 19);
            this.nextStudBtn.Name = "nextStudBtn";
            this.nextStudBtn.Size = new System.Drawing.Size(94, 23);
            this.nextStudBtn.TabIndex = 2;
            this.nextStudBtn.Text = "Next Student >";
            this.nextStudBtn.UseVisualStyleBackColor = true;
            this.nextStudBtn.Click += new System.EventHandler(this.nextStudBtn_Click);
            // 
            // prevStudBtn
            // 
            this.prevStudBtn.Location = new System.Drawing.Point(132, 19);
            this.prevStudBtn.Name = "prevStudBtn";
            this.prevStudBtn.Size = new System.Drawing.Size(94, 23);
            this.prevStudBtn.TabIndex = 1;
            this.prevStudBtn.Text = "< Prev Student";
            this.prevStudBtn.UseVisualStyleBackColor = true;
            this.prevStudBtn.Click += new System.EventHandler(this.prevStudBtn_Click);
            // 
            // firstStudBtn
            // 
            this.firstStudBtn.Location = new System.Drawing.Point(35, 19);
            this.firstStudBtn.Name = "firstStudBtn";
            this.firstStudBtn.Size = new System.Drawing.Size(91, 23);
            this.firstStudBtn.TabIndex = 0;
            this.firstStudBtn.Text = "<< First Student";
            this.firstStudBtn.UseVisualStyleBackColor = true;
            this.firstStudBtn.Click += new System.EventHandler(this.firstStudBtn_Click);
            // 
            // GB3
            // 
            this.GB3.Controls.Add(this.saveStudBtn);
            this.GB3.Controls.Add(this.studentNameTB);
            this.GB3.Controls.Add(this.studentNumLbl);
            this.GB3.Location = new System.Drawing.Point(12, 151);
            this.GB3.Name = "GB3";
            this.GB3.Size = new System.Drawing.Size(460, 57);
            this.GB3.TabIndex = 2;
            this.GB3.TabStop = false;
            this.GB3.Text = "Student";
            // 
            // saveStudBtn
            // 
            this.saveStudBtn.Location = new System.Drawing.Point(370, 20);
            this.saveStudBtn.Name = "saveStudBtn";
            this.saveStudBtn.Size = new System.Drawing.Size(75, 23);
            this.saveStudBtn.TabIndex = 2;
            this.saveStudBtn.Text = "Save Name";
            this.saveStudBtn.UseVisualStyleBackColor = true;
            this.saveStudBtn.Click += new System.EventHandler(this.saveStudBtn_Click);
            // 
            // studentNameTB
            // 
            this.studentNameTB.Location = new System.Drawing.Point(104, 22);
            this.studentNameTB.Name = "studentNameTB";
            this.studentNameTB.Size = new System.Drawing.Size(256, 20);
            this.studentNameTB.TabIndex = 1;
            // 
            // studentNumLbl
            // 
            this.studentNumLbl.AutoSize = true;
            this.studentNumLbl.Location = new System.Drawing.Point(16, 25);
            this.studentNumLbl.Name = "studentNumLbl";
            this.studentNumLbl.Size = new System.Drawing.Size(51, 13);
            this.studentNumLbl.TabIndex = 0;
            this.studentNumLbl.Text = "Student#";
            // 
            // GB4
            // 
            this.GB4.Controls.Add(this.saveScoreBtn);
            this.GB4.Controls.Add(this.assScoreTB);
            this.GB4.Controls.Add(this.assNumTB);
            this.GB4.Controls.Add(this.assScoreLbl);
            this.GB4.Controls.Add(this.assNumLbl);
            this.GB4.Location = new System.Drawing.Point(12, 214);
            this.GB4.Name = "GB4";
            this.GB4.Size = new System.Drawing.Size(460, 73);
            this.GB4.TabIndex = 3;
            this.GB4.TabStop = false;
            this.GB4.Text = "Assignment";
            // 
            // saveScoreBtn
            // 
            this.saveScoreBtn.Location = new System.Drawing.Point(285, 18);
            this.saveScoreBtn.Name = "saveScoreBtn";
            this.saveScoreBtn.Size = new System.Drawing.Size(75, 23);
            this.saveScoreBtn.TabIndex = 4;
            this.saveScoreBtn.Text = "Save Score";
            this.saveScoreBtn.UseVisualStyleBackColor = true;
            this.saveScoreBtn.Click += new System.EventHandler(this.saveScoreBtn_Click);
            // 
            // assScoreTB
            // 
            this.assScoreTB.Location = new System.Drawing.Point(170, 42);
            this.assScoreTB.Name = "assScoreTB";
            this.assScoreTB.Size = new System.Drawing.Size(100, 20);
            this.assScoreTB.TabIndex = 3;
            // 
            // assNumTB
            // 
            this.assNumTB.Location = new System.Drawing.Point(170, 20);
            this.assNumTB.Name = "assNumTB";
            this.assNumTB.Size = new System.Drawing.Size(100, 20);
            this.assNumTB.TabIndex = 2;
            // 
            // assScoreLbl
            // 
            this.assScoreLbl.AutoSize = true;
            this.assScoreLbl.Location = new System.Drawing.Point(41, 45);
            this.assScoreLbl.Name = "assScoreLbl";
            this.assScoreLbl.Size = new System.Drawing.Size(95, 13);
            this.assScoreLbl.TabIndex = 1;
            this.assScoreLbl.Text = "Assignment Score:";
            // 
            // assNumLbl
            // 
            this.assNumLbl.AutoSize = true;
            this.assNumLbl.Location = new System.Drawing.Point(41, 23);
            this.assNumLbl.Name = "assNumLbl";
            this.assNumLbl.Size = new System.Drawing.Size(102, 13);
            this.assNumLbl.TabIndex = 0;
            this.assNumLbl.Text = "Enter Assignment #:";
            // 
            // scoresRTB
            // 
            this.scoresRTB.Location = new System.Drawing.Point(13, 323);
            this.scoresRTB.Name = "scoresRTB";
            this.scoresRTB.Size = new System.Drawing.Size(459, 126);
            this.scoresRTB.TabIndex = 4;
            this.scoresRTB.Text = "";
            // 
            // displayScoreBtn
            // 
            this.displayScoreBtn.Location = new System.Drawing.Point(56, 293);
            this.displayScoreBtn.Name = "displayScoreBtn";
            this.displayScoreBtn.Size = new System.Drawing.Size(100, 23);
            this.displayScoreBtn.TabIndex = 5;
            this.displayScoreBtn.Text = "Display Scores";
            this.displayScoreBtn.UseVisualStyleBackColor = true;
            this.displayScoreBtn.Click += new System.EventHandler(this.displayScoreBtn_Click);
            // 
            // outputBtn
            // 
            this.outputBtn.Location = new System.Drawing.Point(182, 293);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(100, 23);
            this.outputBtn.TabIndex = 6;
            this.outputBtn.Text = "Output To File";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(297, 295);
            this.outputTB.Name = "outputTB";
            this.outputTB.Size = new System.Drawing.Size(160, 20);
            this.outputTB.TabIndex = 7;
            // 
            // StudentScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.displayScoreBtn);
            this.Controls.Add(this.scoresRTB);
            this.Controls.Add(this.GB4);
            this.Controls.Add(this.GB3);
            this.Controls.Add(this.GB2);
            this.Controls.Add(this.GB1);
            this.Name = "StudentScoreForm";
            this.Text = "Scores";
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.GB2.ResumeLayout(false);
            this.GB3.ResumeLayout(false);
            this.GB3.PerformLayout();
            this.GB4.ResumeLayout(false);
            this.GB4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox numOfAssTB;
        private System.Windows.Forms.TextBox numOfStudsTB;
        private System.Windows.Forms.Label numOfAssLbl;
        private System.Windows.Forms.Label numOfStudsLbl;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.Button lastStudBtn;
        private System.Windows.Forms.Button nextStudBtn;
        private System.Windows.Forms.Button prevStudBtn;
        private System.Windows.Forms.Button firstStudBtn;
        private System.Windows.Forms.GroupBox GB3;
        private System.Windows.Forms.Button saveStudBtn;
        private System.Windows.Forms.TextBox studentNameTB;
        private System.Windows.Forms.Label studentNumLbl;
        private System.Windows.Forms.GroupBox GB4;
        private System.Windows.Forms.Button saveScoreBtn;
        private System.Windows.Forms.TextBox assScoreTB;
        private System.Windows.Forms.TextBox assNumTB;
        private System.Windows.Forms.Label assScoreLbl;
        private System.Windows.Forms.Label assNumLbl;
        private System.Windows.Forms.RichTextBox scoresRTB;
        private System.Windows.Forms.Button displayScoreBtn;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.TextBox outputTB;
    }
}

