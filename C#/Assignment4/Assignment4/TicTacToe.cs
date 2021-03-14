using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public class TicTacToe
    {
        /// <summary>
        /// Setting a form to the active
        /// game form instance that is running
        /// </summary>
        Form1 gameForm = (Form1)Form1.ActiveForm;

        /// <summary>
        /// Checks the gameBoard array for
        /// possible wins, returns true
        /// if the game is won and updates
        /// the button colors, otherwise
        /// returns false
        /// </summary>
        public bool checkWin(string[] gameBoard)
        {
            /// <summary>
            /// Checks first horizontal row
            /// </summary>
            if ((gameBoard[0] == gameBoard[1]) && (gameBoard[1] == gameBoard[2]))
            {
                gameForm.button1.BackColor = Color.Yellow;
                gameForm.button2.BackColor = Color.Yellow;
                gameForm.button3.BackColor = Color.Yellow;
                return true;
            }

            /// <summary>
            /// Checks second horizontal row
            /// </summary>
            if ((gameBoard[3] == gameBoard[4]) && (gameBoard[4] == gameBoard[5]))
            {
                gameForm.button4.BackColor = Color.Yellow;
                gameForm.button5.BackColor = Color.Yellow;
                gameForm.button6.BackColor = Color.Yellow;
                return true;
            }

            /// <summary>
            /// Checks third horizontal row
            /// </summary>
            if ((gameBoard[6] == gameBoard[7]) && (gameBoard[7] == gameBoard[8]))
            {
                gameForm.button7.BackColor = Color.Yellow;
                gameForm.button8.BackColor = Color.Yellow;
                gameForm.button9.BackColor = Color.Yellow;
                return true;
            }

            /// <summary>
            /// Checks first verticle column
            /// </summary>
            if ((gameBoard[0] == gameBoard[3]) && (gameBoard[3] == gameBoard[6]))
            {
                gameForm.button1.BackColor = Color.Yellow;
                gameForm.button4.BackColor = Color.Yellow;
                gameForm.button7.BackColor = Color.Yellow;
                return true;
            }

            /// <summary>
            /// Checks second verticle column
            /// </summary>
            if ((gameBoard[1] == gameBoard[4]) && (gameBoard[4] == gameBoard[7]))
            {
                gameForm.button2.BackColor = Color.Yellow;
                gameForm.button5.BackColor = Color.Yellow;
                gameForm.button8.BackColor = Color.Yellow;
                return true;
            }

            /// <summary>
            /// Checks third verticle column
            /// </summary>
            if ((gameBoard[2] == gameBoard[5]) && (gameBoard[5] == gameBoard[8]))
            {
                gameForm.button3.BackColor = Color.Yellow;
                gameForm.button6.BackColor = Color.Yellow;
                gameForm.button9.BackColor = Color.Yellow;
                return true;
            }

            /// <summary>
            /// Checks first diagonal
            /// </summary>
            if ((gameBoard[0] == gameBoard[4]) && (gameBoard[4] == gameBoard[8]))
            {
                gameForm.button1.BackColor = Color.Yellow;
                gameForm.button5.BackColor = Color.Yellow;
                gameForm.button9.BackColor = Color.Yellow;
                return true;
            }

            /// <summary>
            /// Checks second diagonal
            /// </summary>
            if ((gameBoard[2] == gameBoard[4]) && (gameBoard[4] == gameBoard[6]))
            {
                gameForm.button3.BackColor = Color.Yellow;
                gameForm.button5.BackColor = Color.Yellow;
                gameForm.button7.BackColor = Color.Yellow;
                return true;
            }

            /// <summary>
            /// If no wins occured then
            /// false is returned instead
            /// </summary>
            else
            {
                return false;
            }
        } /// end checkWin()
    } /// end TicTacToe class
} /// end Assignment4
