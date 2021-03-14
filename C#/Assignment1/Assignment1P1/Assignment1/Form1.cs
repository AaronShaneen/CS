using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button 1 click event
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// specifies MessageBox properties and saves user button selection
            /// </summary>
            DialogResult msgBoxResult = MessageBox.Show(this.userInput.Text, " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            
            /// <summary>
            /// if user clicked OK
            /// </summary>
            if (msgBoxResult == DialogResult.OK)
            {
                this.showButton.Text = "You pressed OK";        // shows that OK button was used
            }
            
            /// <summary>
            /// if user clicked cancel
            /// </summary>
            else if (msgBoxResult == DialogResult.Cancel)
            {
                this.showButton.Text = "You pressed Cancel";    // shows that canel button was used
            }
        }

        /// <summary>
        /// button 2 click event
        /// </summary>
        private void Button2_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// specifies MessageBox properties and saves user button selection
            /// </summary>
            DialogResult msgBoxResult = MessageBox.Show(this.userInput.Text, " ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);

            /// <summary>
            /// if user clicked retry
            /// </summary>
            if (msgBoxResult == DialogResult.Retry)
            {
                this.showButton.Text = "You pressed Retry";     // shows that retry button was used
            }

            /// <summary>
            /// if user clicked cancel
            /// </summary>
            else if (msgBoxResult == DialogResult.Cancel)
            {
                this.showButton.Text = "You pressed Cancel";    // shows that cancel button was used
            } 
        }

        /// <summary>
        /// button 3 click event
        /// </summary>
        private void Button3_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Specifies MessageBox properties and saves user button selection
            /// </summary>
            DialogResult msgBoxResult = MessageBox.Show(this.userInput.Text, " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            /// <summary>
            /// if user clicked yes
            /// </summary>
            if (msgBoxResult == DialogResult.Yes)
            {
                this.showButton.Text = "You pressed Yes";       // shows that yes button was clicked
            }

            /// <summary>
            /// if user clicked no
            /// </summary>
            else if (msgBoxResult == DialogResult.No)
            {
                this.showButton.Text = "You pressed No";        // shows that no button was clicked
            }
        }
    }
}
