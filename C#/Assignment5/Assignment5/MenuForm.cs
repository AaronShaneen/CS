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
    public partial class MenuForm : Form
    {
        UserClass User = new UserClass();       // initializing User class to keep track outside of user forms
        ScoreClass Score = new ScoreClass();    // initializing Score class to keep track outside of score forms

        public MenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// To load pictures and sounds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Loads User Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoBtn_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();

            userForm.Show();
        }

        /// <summary>
        /// Loads Game Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameBtn_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();

            gameForm.Show();
        }

        /// <summary>
        /// Loads Score Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scoreBtn_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm();

            scoreForm.Show();
        }
    }
}
