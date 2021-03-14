namespace Assignment5
{
    partial class UserForm
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
            this.userInfoGB = new System.Windows.Forms.GroupBox();
            this.editInfoBtn = new System.Windows.Forms.Button();
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
            this.userInfoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInfoGB
            // 
            this.userInfoGB.Controls.Add(this.editInfoBtn);
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
            this.userInfoGB.Location = new System.Drawing.Point(12, 12);
            this.userInfoGB.Name = "userInfoGB";
            this.userInfoGB.Size = new System.Drawing.Size(259, 236);
            this.userInfoGB.TabIndex = 4;
            this.userInfoGB.TabStop = false;
            this.userInfoGB.Text = "User Information";
            // 
            // editInfoBtn
            // 
            this.editInfoBtn.Location = new System.Drawing.Point(145, 207);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.editInfoBtn.TabIndex = 15;
            this.editInfoBtn.Text = "Edit";
            this.editInfoBtn.UseVisualStyleBackColor = true;
            this.editInfoBtn.Click += new System.EventHandler(this.editInfoBtn_Click);
            // 
            // submitInfoBtn
            // 
            this.submitInfoBtn.Location = new System.Drawing.Point(40, 207);
            this.submitInfoBtn.Name = "submitInfoBtn";
            this.submitInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.submitInfoBtn.TabIndex = 14;
            this.submitInfoBtn.Text = "Submit";
            this.submitInfoBtn.UseVisualStyleBackColor = true;
            this.submitInfoBtn.Click += new System.EventHandler(this.submitInfoBtn_Click);
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(120, 168);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 13;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(120, 133);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(100, 20);
            this.phoneTB.TabIndex = 12;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(120, 99);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(100, 20);
            this.ageTB.TabIndex = 11;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(120, 65);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 10;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(120, 32);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 9;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(37, 171);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Email:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(37, 136);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(41, 13);
            this.phoneLbl.TabIndex = 7;
            this.phoneLbl.Text = "Phone:";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(37, 102);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(29, 13);
            this.ageLbl.TabIndex = 6;
            this.ageLbl.Text = "Age:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(37, 68);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(61, 13);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Last Name:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(37, 35);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.firstNameLbl.TabIndex = 4;
            this.firstNameLbl.Text = "First Name:";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.userInfoGB);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.userInfoGB.ResumeLayout(false);
            this.userInfoGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userInfoGB;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Button editInfoBtn;
        private System.Windows.Forms.Button submitInfoBtn;
    }
}