using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class GameClass
    {
        Random rngNum = new Random();   // random number generator for math questions
        private string gameType;        // string specifying game type user chose
        private string question;        // string storing randomly generated math question
        //private int answer;           // the correct answer for each math question
        public bool rightWrongAns;      // boolean set according to each question answered correctly
        //private int correctNum;       // correct question count
        //private int wrongNum;         // incorrect question count

        /// <summary>
        /// Sets game type string
        /// </summary>
        /// <param name="userGameType"></param>
        public void setGameType(string userGameType)
        {
            gameType = userGameType;
        }
        
        /// <summary>
        /// Initiates user specified game type
        /// </summary>
        public void initiateGame()
        {
            switch(gameType)
            {
                case "Addition":
                    additionGame();
                    break;

                case "Subtraction":
                    subtractionGame();
                    break;

                case "Multiplication":
                    multiplicationGame();
                    break;

                case "Division":
                    divisionGame();
                    break;
            }
        }

        /// <summary>
        /// Addition game, questions generated and returned to GameForm
        /// </summary>
        private void additionGame()
        {
            int num1 = rngNum.Next(1, 10);
            int num2 = rngNum.Next(1, 10);

            question = Convert.ToString(num1) + " + " + Convert.ToString(num2) + " =";
        }

        /// <summary>
        /// Subtraction game, questions generated and returned to GameForm
        /// </summary>
        private void subtractionGame()
        {
            int num1 = rngNum.Next(1, 10);
            int num2 = rngNum.Next(1, 10);

            question = Convert.ToString(num1) + " - " + Convert.ToString(num2) + " =";
        }

        /// <summary>
        /// Multiplication game, questions generated and returned to GameForm
        /// </summary>
        private void multiplicationGame()
        {
            int num1 = rngNum.Next(1, 10);
            int num2 = rngNum.Next(1, 10);

            question = Convert.ToString(num1) + " x " + Convert.ToString(num2) + " =";
        }

        /// <summary>
        /// Division game, questions generated and returned to GameForm
        /// </summary>
        private void divisionGame()
        {

        }

        /// <summary>
        /// Returns randomly generated math question to GameForm
        /// </summary>
        /// <returns></returns>
        public string generateQuestion()
        {
            return question;
        }

        /// <summary>
        /// Checks user's answer to the correct answer setting a boolean
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="answer"></param>
        private void checkAnswer(int guess, int answer)
        {
            if (guess == answer)
            {
                rightWrongAns = true;
            }

            else
            {
                rightWrongAns = false;
            }
        }

        /// <summary>
        /// Returns boolean on whether or not user was correct
        /// </summary>
        /// <returns></returns>
        public bool rightOrWrong()
        {
            return rightWrongAns;
        }
    }
}
