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
    public partial class GameForm : Form
    {
        GameClass Game = new GameClass();   /// Intializing GameClass to be used in GameForm
        
        public GameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show Game Select controls and hides specific game controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameSelectForm_Load(object sender, EventArgs e)
        {
            gameSelectPnl.Visible = true;

            gamePnl.Visible = false;
        }

        /// <summary>
        /// Shows game specific controls and intializes addition game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addGameBtn_Click(object sender, EventArgs e)
        {
            Button gameType = (Button)sender;

            Game.setGameType(gameType.Text);

            gameSelectPnl.Visible = false;

            gamePnl.Visible = true;
        }

        /// <summary>
        /// Shows game specific controls and intializes subtraction game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtractGameBtn_Click(object sender, EventArgs e)
        {
            Button gameType = (Button)sender;

            Game.setGameType(gameType.Text);

            gameSelectPnl.Visible = false;

            gamePnl.Visible = true;
        }

        /// <summary>
        /// Shows game specific controls and intializes multiplication game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multiplyGameBtn_Click(object sender, EventArgs e)
        {
            Button gameType = (Button)sender;

            Game.setGameType(gameType.Text);

            gameSelectPnl.Visible = false;

            gamePnl.Visible = true;
        }

        /// <summary>
        /// Shows game specific controls and intializes division game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void divisionGameBtn_Click(object sender, EventArgs e)
        {
            Button gameType = (Button)sender;

            Game.setGameType(gameType.Text);

            gameSelectPnl.Visible = false;

            gamePnl.Visible = true;
        }

        /// <summary>
        /// Initiates user specified game mode and generates first question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBtn_Click(object sender, EventArgs e)
        {
            Game.initiateGame();

            questionLbl.Text = Game.generateQuestion();
        }

        /// <summary>
        /// Saves user answer as right or wrong and tells user if they were right or wrong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool rightWrong = Game.rightOrWrong();

            if(rightWrong)
            {
                correctLbl.Text = "You are correct";
            }

            else
            {
                correctLbl.Text = "You are not correct";
            }

            questionLbl.Text = Game.generateQuestion();
        }

        /// <summary>
        /// Switches game specific controls back to game select controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            gameSelectPnl.Visible = true;

            gamePnl.Visible = false;
        }
    }
}
