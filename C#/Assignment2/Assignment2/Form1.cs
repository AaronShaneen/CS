#region Namespace
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
#endregion

namespace Assignment2
{
    public partial class Form1 : Form
    {
        #region Variables
        Image[] dicePic =                   //Dice array to roll dice visually
        {   Properties.Resources.die1,
            Properties.Resources.die2,
            Properties.Resources.die3,
            Properties.Resources.die4,
            Properties.Resources.die5,
            Properties.Resources.die6,
        };
        Random randomNum = new Random();    //Random number generator for dice
        int userNum;                        //The number the user guesses
        int rolledNum;                      //The number rolled by the dice
        int validNum;                       //To test valid user input
        int playedNum = 0;                  //To keep track of games played
        int wonNum = 0;                     //To keep track of games won
        int lostNum = 0;                    //To keep track of games lost
        #endregion

        #region Methods
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieves user's guess and validates it,
        /// then rolls dice to determine if user won
        /// </summary>
        private void rollBtn_Click(object sender, EventArgs e)
        {
            //Input validation
            //If user input was not a valid number then ask to reenter
            if (!(int.TryParse(guessTB.Text, out validNum)))
            {
                MessageBox.Show("Please enter a valid number between 1 and 6");
            }

            //If user input was a valid number then continue on with the game
            else
            {
                //Retrieve user's guess
                userNum = Convert.ToInt32(guessTB.Text);

                //Resets the guess text box for the next guess
                guessTB.Text = "";

                //Generates rolled dice number
                rolledNum = randomNum.Next(1, 7);

                //Animates dice rolling visually
                roll_Dice();

                //If user guessed the right number
                if (userNum == rolledNum)
                {
                    wonNum++;
                    playedNum++;
                }

                //If user guessed the wrong number
                else
                {
                    lostNum++;
                    playedNum++;
                }

                //Updates score and stats
                updateScoreStats();
            }
        }

        /// <summary>
        /// Animates dice roll using Sleep() and Refresh()
        /// </summary>
        private void roll_Dice()
        {
            for (int i = 0; i < dicePic.Length; i++)
            {
                diceLbl.Image = dicePic[i];
                diceLbl.Refresh();
                Thread.Sleep(300);
            }

            diceLbl.Image = dicePic[rolledNum - 1];
        }

        /// <summary>
        /// Updates scores and stats
        /// </summary>
        private void updateScoreStats()
        {
            playedLbl.Text = "Games Played: " + playedNum;
            wonLbl.Text = "Games Won: " + wonNum;
            lostLbl.Text = "Games Lost: " + lostNum;

            //Calculate stats method used here

            statRTB.Text = ("Number" + '\t' + "Frequency" + '\t' + "Percent" + '\t' + "Guessed"
                + "1" + '\n'
                + "2" + '\n'
                + "3" + '\n'
                + "4" + '\n'
                + "5" + '\n'
                + "6" + '\n');
        }

        //Calculate stats method here

        /// <summary>
        /// Resets internal variables and scores when reset button is clicked
        /// </summary>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            userNum = 0;
            rolledNum = 0;
            playedNum = 0;
            wonNum = 0;
            lostNum = 0;

            playedLbl.Text = "Games Played: " + playedNum;
            wonLbl.Text = "Games Won: " + wonNum;
            lostLbl.Text = "Games Lost: " + lostNum;
        }
        #endregion
    }
}
