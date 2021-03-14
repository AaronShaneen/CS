namespace Assignment5
{
    partial class MenuForm
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
            this.menuGB = new System.Windows.Forms.GroupBox();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.gameBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.userInfoGB = new System.Windows.Forms.GroupBox();
            this.submitInfoBtn = new System.Windows.Forms.Button();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.menuGB.SuspendLayout();
            this.userInfoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGB
            // 
            this.menuGB.Controls.Add(this.scoreBtn);
            this.menuGB.Controls.Add(this.gameBtn);
            this.menuGB.Controls.Add(this.infoBtn);
            this.menuGB.Location = new System.Drawing.Point(12, 200);
            this.menuGB.Name = "menuGB";
            this.menuGB.Size = new System.Drawing.Size(260, 49);
            this.menuGB.TabIndex = 27;
            this.menuGB.TabStop = false;
            this.menuGB.Text = "Menu";
            // 
            // scoreBtn
            // 
            this.scoreBtn.Location = new System.Drawing.Point(179, 19);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(75, 23);
            this.scoreBtn.TabIndex = 5;
            this.scoreBtn.Text = "Score";
            this.scoreBtn.UseVisualStyleBackColor = true;
            // 
            // gameBtn
            // 
            this.gameBtn.Location = new System.Drawing.Point(93, 19);
            this.gameBtn.Name = "gameBtn";
            this.gameBtn.Size = new System.Drawing.Size(75, 23);
            this.gameBtn.TabIndex = 4;
            this.gameBtn.Text = "Game";
            this.gameBtn.UseVisualStyleBackColor = true;
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(6, 19);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(75, 23);
            this.infoBtn.TabIndex = 3;
            this.infoBtn.Text = "Information";
            this.infoBtn.UseVisualStyleBackColor = true;
            // 
            // userInfoGB
            // 
            this.userInfoGB.Controls.Add(this.submitInfoBtn);
            this.userInfoGB.Controls.Add(this.emailTB);
            this.userInfoGB.Controls.Add(this.phoneTB);
            this.userInfoGB.Controls.Add(this.ageTB);
            this.userInfoGB.Controls.Add(this.lastNameTB);
            this.userInfoGB.Controls.Add(this.firstNameTB);
            this.userInfoGB.Controls.Add(this.emailLbl);
            this.userInfoGB.Controls.Add(this.phoneLbl);
            this.userInfoGB.Controls.Add(this.ageLbl);
            this.userInfoGB.Controls.Add(this.lastNameLbl);
            this.userInfoGB.Controls.Add(this.firstNameLbl);
            this.userInfoGB.Location = new System.Drawing.Point(13, 6);
            this.userInfoGB.Name = "userInfoGB";
            this.userInfoGB.Size = new System.Drawing.Size(259, 188);
            this.userInfoGB.TabIndex = 28;
            this.userInfoGB.TabStop = false;
            this.userInfoGB.Text = "User Information";
            // 
            // submitInfoBtn
            // 
            this.submitInfoBtn.Location = new System.Drawing.Point(92, 159);
            this.submitInfoBtn.Name = "submitInfoBtn";
            this.submitInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.submitInfoBtn.TabIndex = 14;
            this.submitInfoBtn.Text = "Submit";
            this.submitInfoBtn.UseVisualStyleBackColor = true;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(120, 123);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 13;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(120, 97);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(100, 20);
            this.phoneTB.TabIndex = 12;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(120, 71);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(100, 20);
            this.ageTB.TabIndex = 11;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(120, 45);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 10;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(120, 19);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 9;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(37, 126);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Email:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(37, 100);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(41, 13);
            this.phoneLbl.TabIndex = 7;
            this.phoneLbl.Text = "Phone:";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(37, 74);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(29, 13);
            this.ageLbl.TabIndex = 6;
            this.ageLbl.Text = "Age:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(37, 48);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(61, 13);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Last Name:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(37, 22);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.firstNameLbl.TabIndex = 4;
            this.firstNameLbl.Text = "First Name:";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.userInfoGB);
            this.Controls.Add(this.menuGB);
            this.Name = "MenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuGB.ResumeLayout(false);
            this.userInfoGB.ResumeLayout(false);
            this.userInfoGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox menuGB;
        private System.Windows.Forms.Button scoreBtn;
        private System.Windows.Forms.Button gameBtn;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.GroupBox userInfoGB;
        private System.Windows.Forms.Button submitInfoBtn;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;

    }
}

