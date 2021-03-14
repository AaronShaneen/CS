using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        #region Variables

        /// <summary>
        /// Declaring TicTacToe object
        /// to access checkWin() method
        /// </summary>
        TicTacToe Game;

        /// <summary>
        /// Declaring gameBoard array
        /// to store and check moves
        /// </summary>
        string[] gameBoard;

        /// <summary>
        /// Declaring/Initializing
        /// player 1 win count to 0
        /// </summary>
        int player1Wins = 0;

        /// <summary>
        /// Declaring/initializing
        /// player 2 win count to 0
        /// </summary>
        int player2Wins = 0;

        /// <summary>
        /// Declaring/Initializing
        /// games ties to 0
        /// </summary>
        int playerTies = 0;

        /// <summary>
        /// Declaring move count
        /// to keep track of 
        /// number of moves made
        /// </summary>
        int moveCount;

        /// <summary>
        /// Declaring bool to keep
        /// track of which player's
        /// turn it is
        /// </summary>
        bool whichPlayer;

        /// <summary>
        /// Declaring/Initializing
        /// winningMove bool to false
        /// until a winning move is made
        /// </summary>
        bool winningMove = false;
        #endregion

        /// <summary>
        /// Button click events
        /// </summary>
        #region Events

        /// <summary>
        /// Form1 initialization
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        } /// end Form1()

        /// <summary>
        /// If button1 is clicked
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 1 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[0] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 1 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[0] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 1 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button1_Click()

        /// <summary>
        /// If button2 is clicked
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 2 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[1] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 2 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[1] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 2 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button2_Click()

        /// <summary>
        /// If button3 is clicked
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 3 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[2] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 3 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[2] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 3 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button3_Click()

        /// <summary>
        /// If button4 is clicked
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 4 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[3] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 4 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[3] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 4 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button4_Click()

        /// <summary>
        /// If button5 is clicked
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 5 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[4] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 5 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[4] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 5 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button5_Click()

        /// <summary>
        /// If button6 is clicked
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 6 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[5] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 6 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[5] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 6 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button6_Click()

        /// <summary>
        /// If button7 is clicked
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 7 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[6] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 7 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[6] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 7 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button7_Click()

        /// <summary>
        /// If button8 is clicked
        /// </summary>
        private void button8_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 8 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[7] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 8 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[7] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 8 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button8_Click()

        /// <summary>
        /// If button9 is clicked
        /// </summary>
        private void button9_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If player 1 clicked
            /// button 9 set that
            /// array index to X
            /// </summary>
            if(whichPlayer)
            {
                gameBoard[8] = "X";
            }

            /// <summary>
            /// If player 2 clicked
            /// button 9 set that
            /// array index to O
            /// </summary>
            else
            {
                gameBoard[8] = "O";
            }

            /// <summary>
            /// Calling turnTaken() to set
            /// button 9 to player's mark
            /// and color and set game status
            /// </summary>
            turnTaken(whichPlayer, (Button)sender);

            /// <summary>
            /// Checking if move was a winning move
            /// setting winningMove bool to true if
            /// it was or else false if it wasn't
            /// </summary>
            winningMove = Game.checkWin(gameBoard);

            /// <summary>
            /// Checking if a winning move was made,
            /// if so player wins and game status is
            /// updated and the game ends, if not a
            /// tie is checked, or else it is the
            /// player's turn
            /// </summary>
            gameWon(winningMove);
        } /// end button9_Click()
        #endregion

        /// <summary>
        /// Form1 methods
        /// </summary>
        #region Methods

        /// <summary>
        /// When start button is clicked set remaining
        /// variables and enabled/reset buttons
        /// </summary>
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Initializing TicTacToe object
            /// in order to pass array to check
            /// for wins
            /// </summary>
            Game = new TicTacToe();

            /// <summary>
            /// Initializing array to random
            /// strings to be overwritten
            /// when a player makes a move
            /// </summary>
            gameBoard = new string[9] {"A", "B", "C", "D", "E", "F", "G", "H", "I"};

            /// <summary>
            /// Updating player 1's wins
            /// </summary>
            player1StatsLbl.Text = "Player 1 Wins: " + player1Wins;

            /// <summary>
            /// Updating player 2's wins
            /// </summary>
            player2StatsLbl.Text = "Player 2 Wins: " + player2Wins;

            /// <summary>
            /// Updating game ties
            /// </summary>
            tiesLbl.Text = "Ties: " + playerTies;

            /// <summary>
            /// Updating game status to
            /// player 1's turn at the 
            /// start of a new game
            /// </summary>
            gameStatusLbl.Text = "Player 1's turn";

            /// <summary>
            /// Setting move count to 0
            /// at the start of a new game
            /// </summary>
            moveCount = 0;

            /// <summary>
            /// Setting whichPlayer bool
            /// to true so that player 1
            /// makes their move first
            /// </summary>
            whichPlayer = true;

            /// <summary>
            /// Resetting buttons to default
            /// values and colors in case a
            /// game was just played
            /// </summary>
            resetBtns();

            /// <summary>
            /// Enabling all buttons from
            /// default of being disabled
            /// before a game or after a
            /// game just completed
            /// </summary>
            enableBtns();
        } /// end startGameBtn_Click()

        /// <summary>
        /// Sets each button to the player's mark
        /// and color, depending on which player
        /// clicked it, and updating game status
        /// after each player's move
        /// </summary>
        private void turnTaken(bool player, Button button)
        {
            /// <summary>
            /// If player 1 clicked the button
            /// set to X and OrangeRed and update
            /// game status to player 2's turn
            /// </summary>
            if (whichPlayer)
            {
                button.Text = "X";
                button.BackColor = Color.OrangeRed;
                gameStatusLbl.Text = "Player 2's turn";
            }

            /// <summary>
            /// If player 2 clicked the button
            /// set to O and RoyalBlue and update
            /// game status to player 1's turn
            /// </summary>
            else
            {
                button.Text = "O";
                button.BackColor = Color.RoyalBlue;
                gameStatusLbl.Text = "Player 1's turn";
            }

            /// <summary>
            /// Update moveCount after move was made
            /// </summary>
            moveCount++;

            /// <summary>
            /// Disable button after
            /// being clicked
            /// </summary>
            button.Enabled = false;
        } /// end turnTaken()

        /// <summary>
        /// Checks to see if the game has been
        /// won or, if not, if a tie has occured
        /// </summary>
        private void gameWon(bool winningMove)
        {
            /// <summary>
            /// If a winning move was made initialize
            /// a string for game status, disable all
            /// buttons and signify which player won,
            /// thus updating that player's wins count
            /// </summary>
            if (winningMove)
            {
                /// <summary>
                /// String to store which
                /// player won the game
                /// </summary>
                String winner;

                /// <summary>
                /// Disable all buttons after
                /// a game has been won so that
                /// no more buttons can be clicked
                /// </summary>
                disableBtns();

                /// <summary>
                /// If player 1 won then save to
                /// winner string and update their
                /// score
                /// </summary>
                if (whichPlayer)
                {
                    winner = "Player 1";
                    player1Wins++;
                }

                /// <summary>
                /// If player 2 won then save to
                /// winner string and update their
                /// score
                /// </summary>
                else
                {
                    winner = "Player 2";
                    player2Wins++;
                }

                /// <summary>
                /// Update player 1's stats with
                /// player 1's win count
                /// </summary>
                player1StatsLbl.Text = "Player 1 Wins: " + player1Wins;

                /// <summary>
                /// Update player 2's stats with
                /// player 2's win count
                /// </summary>
                player2StatsLbl.Text = "Player 2 Wins: " + player2Wins;

                /// <summary>
                /// Show which player won
                /// in game status section
                /// </summary>
                gameStatusLbl.Text = winner + " wins!";
            }

            /// <summary>
            /// If a game was not won then
            /// check if it was a tie instead,
            /// therefore update ties count, and
            /// signify that there was a tie in
            /// the game status
            /// </summary>
            else
            {
                /// <summary>
                /// If it was a tie update ties
                /// count and game status
                /// </summary>
                if (moveCount == 9)
                {
                    playerTies++;
                    tiesLbl.Text = "Ties: " + playerTies;
                    gameStatusLbl.Text = "Tie!";
                }

                /// <summary>
                /// If there wasn't a win or
                /// a tie then the game is still
                /// going and switch which player's
                /// turn it is next
                /// </summary>
                else
                {
                    whichPlayer = (!whichPlayer);
                }
            }
        } /// end gameWon()

        /// <summary>
        /// Resets all TicTacToe button
        /// color and text to default
        /// </summary>
        private void resetBtns()
        {
            button1.BackColor = default(Color);
            button1.Text = " ";
            button2.BackColor = default(Color);
            button2.Text = " ";
            button3.BackColor = default(Color);
            button3.Text = " ";
            button4.BackColor = default(Color);
            button4.Text = " ";
            button5.BackColor = default(Color);
            button5.Text = " ";
            button6.BackColor = default(Color);
            button6.Text = " ";
            button7.BackColor = default(Color);
            button7.Text = " ";
            button8.BackColor = default(Color);
            button8.Text = " ";
            button9.BackColor = default(Color);
            button9.Text = " ";
        } /// end resetBtns()

        /// <summary>
        /// Enables all TicTacToe buttons,
        /// not including the "Start" button
        /// </summary>
        private void enableBtns()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        } /// end resetBtns()

        /// <summary>
        /// Disables all TacTocToe buttons,
        /// not including the "Start" button
        /// </summary>
        private void disableBtns()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        } /// end disableBtns()
        #endregion
    } /// end Form1
} /// end Assignment4