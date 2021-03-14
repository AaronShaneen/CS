using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class UserForm : Form
    {
        static UserClass userClass = new UserClass();

        public UserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads user information set prior or blank for default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserForm_Load(object sender, EventArgs e)
        {
            firstNameTB.Text = userClass.firstName;
            lastNameTB.Text = userClass.lastName;
            ageTB.Text = userClass.age;
            phoneTB.Text = userClass.phone;
            emailTB.Text = userClass.email;
        }

        /// <summary>
        /// Sets user information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitInfoBtn_Click(object sender, EventArgs e)
        {
            userClass.setUserInfo(firstNameTB.Text, lastNameTB.Text, ageTB.Text, phoneTB.Text, emailTB.Text);
        }

        /// <summary>
        /// Upon click event resets all user information to accept new user information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            userClass.resetUserInfo();

            UserForm_Load(sender, e);

            userClass.setUserInfo(firstNameTB.Text, lastNameTB.Text, ageTB.Text, phoneTB.Text, emailTB.Text);
        }
    }
}
