using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Assignment3
{
    public partial class StudentScoreForm : Form
    {
        #region Variables
        /// <summary>
        /// for array definition
        /// </summary>
        int numStuds;

        /// <summary>
        /// for array definition
        /// </summary>
        int numAss;

        /// <summary>
        /// multidimensional array of objects for student's name and scores
        /// </summary>
        object[,] studentScore;

        /// <summary>
        /// to reference the current student in Navigate section
        /// </summary>
        int currStudent;

        /// <summary>
        /// to reference the first student in Navigate section
        /// </summary>
        int firstStudent;

        /// <summary>
        /// to reference the last student in Navigate section
        /// </summary>
        int lastStudent;

        /// <summary>
        /// to check if textbox contains letters
        /// </summary>
        bool result;

        /// <summary>
        /// for TryParse() in checking textbox contents
        /// </summary>
        int someNum;
        #endregion Variables

        #region Events
        /// <summary>
        /// form initialization disableBtns() used to
        /// disable bottom half of form until
        /// students/assignments has been entered by the user
        /// </summary>
        public StudentScoreForm()
        {
            InitializeComponent();

            disableBtns();
        }

        /// <summary>
        /// checks if valid number of students and
        /// assignments were entered by the user,
        /// if so initializes and sets all appropriate
        /// variables
        /// </summary>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// if numOfStudsTB or numOfAssTB are empty
            /// </summary
            if (String.IsNullOrWhiteSpace(numOfStudsTB.Text) || String.IsNullOrWhiteSpace(numOfAssTB.Text))
            {
                MessageBox.Show("You cannot enter a blank number of students/assignments");

                resetTextbox();

                return;
            }

            /// <summary>
            /// if textbox contains letters
            /// </summary>
            result = int.TryParse(numOfStudsTB.Text, out someNum);

            /// <summary>
            /// if letters were entered
            /// instead of numbers
            /// </summary>
            if (!result)
            {
                MessageBox.Show("You must enter a number");

                resetTextbox();

                return;
            }

            /// <summary>
            /// if textbox contains letters
            /// </summary>
            result = int.TryParse(numOfAssTB.Text, out someNum);

            /// <summary>
            /// if letters were entered
            /// instead of numbers
            /// </summary>
            if (!result)
            {
                MessageBox.Show("You must enter a number");

                resetTextbox();

                return;
            }

            /// <summary>
            /// if number of students entered is negative
            /// </summary>
            if (Convert.ToInt32(numOfStudsTB.Text) < 0)
            {
                MessageBox.Show("You cannot have a negative number of students");

                resetTextbox();
                
                return;
            }

            /// <summary>
            /// if number of students is more than 10
            /// </summary>
            if (Convert.ToInt32(numOfStudsTB.Text) > 10)
            {
                MessageBox.Show("You cannot have more than 10 students");

                resetTextbox();

                return;
            }

            /// <summary>
            /// if number of students entered is negative
            /// </summary>
            if (Convert.ToInt32(numOfAssTB.Text) < 0)
            {
                MessageBox.Show("You cannot have a negative number of assignments");

                resetTextbox();
                
                return;
            }

            /// <summary>
            /// if number of assignments is more than 99
            /// </summary>
            if (Convert.ToInt32(numOfAssTB.Text) > 99)
            {
                MessageBox.Show("You cannot have more than 99 assignments");

                resetTextbox();

                return;
            }

            /// <summary>
            /// else intialize and set all appropriate variables
            /// </summary>
            else
            {
                /// <summary>
                /// set number of students
                /// </summary>
                numStuds = Convert.ToInt32(numOfStudsTB.Text);

                /// <summary>
                /// set number of assignments
                /// </summary>
                numAss = Convert.ToInt32(numOfAssTB.Text);

                /// <summary>
                /// set currStudent to point to the first student initially
                /// </summary>
                currStudent = 0;

                /// <summary>
                /// set firstStudent to point to the first student in the list
                /// </summary>
                firstStudent = 0;

                /// <summary>
                /// set lastStudent to point to the last student in the list (also numStuds)
                /// </summary>
                lastStudent = numStuds - 1;

                /// <summary>
                /// initialize studentScore array to number of students and assignments
                /// </summary>
                studentScore = new object[numStuds, (numAss + 1)];

                /// <summary>
                /// setting student's names and scores to default values
                /// </summary>
                for (int i = 0; i < numStuds; i++)
                {
                    /// <summary>
                    /// setting student's names to default "Student#"
                    /// </summary>
                    studentScore[i, 0] = ("Student#" + Convert.ToString(i + 1));

                    /// <summary>
                    /// setting student's assignment scores to default 0
                    /// </summary>
                    for (int j = 1; j <= numAss; j++)
                    {
                        studentScore[i, j] = 0;
                    }
                }

                /// <summary>
                /// enable bottom half of form
                /// </summary>
                enableBtns();

                /// <summary>
                /// setting student name label to default student name
                /// </summary>
                studentNumLbl.Text = (string)studentScore[firstStudent, 0];

                /// <summary>
                /// resetting textboxes to default
                /// </summary>
                resetTextbox();
            }
        } /// end submitBtn()

        /// <summary>
        /// resets all appropriate variables to default
        /// and disables bottom half of form
        /// </summary>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// resetting student's names and scores to default
            /// </summary>
            for (int i = 0; i < numStuds; i++)
            {
                /// <summary>
                /// resetting student's default name to Student#
                /// </summary>
                studentScore[i, 0] = "Student#";

                /// <summary>
                /// resetting student's assignment scores to 0
                /// </summary>
                for (int j = 1; j <= numAss; j++)
                {
                    studentScore[i, j] = 0;
                }
            }

            /// <summary>
            /// resetting currStudent
            /// </summary>
            currStudent = 0;

            /// <summary>
            /// resetting firstStudent
            /// </summary>
            firstStudent = 0;

            /// <summary>
            /// resetting lastStudent
            /// </summary>
            lastStudent = 0;

            /// <summary>
            /// resetting student name label to default
            /// </summary>
            studentNumLbl.Text = "Student#";

            /// <summary>
            /// clear the rich textbox
            /// </summary>
            scoresRTB.Clear();

            /// <summary>
            /// disable bottom half of the form
            /// </summary>
            disableBtns();
        } /// end resetBtn()

        /// <summary>
        /// directs user to the first student
        /// </summary>
        private void firstStudBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// moves currStudent to the first student in the list
            /// </summary>
            currStudent = firstStudent;

            /// <summary>
            /// populates student's name label with the student's name
            /// </summary>
            studentNumLbl.Text = (string)studentScore[firstStudent, 0];
        } /// end firstStudBtn()

        /// <summary>
        /// directs user to the previous student
        /// </summary>
        private void prevStudBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// prevents from going out of bounds
            /// </summary>
            if (currStudent == firstStudent)
            {
                return;
            }

            /// <summary>
            /// moves currStudent to the previous student in the list
            /// </summary>
            currStudent--;

            /// <summary>
            /// populates student's name label with the previous student's name
            /// </summary>
            studentNumLbl.Text = (string)studentScore[currStudent, 0];
        } /// end prevStudBtn()

        /// <summary>
        /// directs user to the next student
        /// </summary>
        private void nextStudBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// prevents from going out of bounds
            /// </summary>
            if(currStudent == (numStuds - 1))
            {
                return;
            }

            /// <summary>
            /// moves currStudent to the next student in the list
            /// </summary>
            currStudent++;

            /// <summary>
            /// populates student's name label with the next student's name
            /// </summary>
            studentNumLbl.Text = (string)studentScore[currStudent, 0];
        } /// end nextStudBtn()

        /// <summary>
        /// Directs user to the last student
        /// </summary>
        private void lastStudBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// moves currStudent to the last student in the list
            /// </summary>
            currStudent = lastStudent;

            /// <summary>
            /// populates student's name label with the last student's name
            /// </summary>
            studentNumLbl.Text = (string)studentScore[lastStudent, 0];
        } /// end lastStudBtn()

        /// <summary>
        /// sets student's name to the user's specified name
        /// </summary>
        private void saveStudBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// sets currStudent student's name to user specified name
            /// </summary>
            studentScore[currStudent, 0] = Convert.ToString(studentNameTB.Text);

            /// <summary>
            /// populates student's name label with new student's name
            /// </summary>
            studentNumLbl.Text = (string)studentScore[currStudent, 0];

            /// <summary>
            /// resetting student name textbox upon completion
            /// </summary>
            studentNameTB.Text = "";
        } /// end saveStudBtn()

        /// <summary>
        /// sets student's assignment score to user's specified score
        /// </summary>
        private void saveScoreBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// sets student assignment score to user specified score
            /// </summary>
            studentScore[currStudent, Convert.ToInt32(assNumTB.Text)] = Convert.ToInt32(assScoreTB.Text);

            /// <summary>
            /// resetting assignment number text box upon completion
            /// </summary>
            assNumTB.Text = "";

            /// <summary>
            /// resetting assignment score text box upon completion
            /// </summary>
            assScoreTB.Text = "";
        } /// end saveScoreBtn()

        /// <summary>
        /// displays all students and their grades
        /// </summary>
        private void displayScoreBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// writes column names to rich textbox
            /// </summary>
            scoresRTB.AppendText("Student" + '\t' + '\t' + "Grade" + '\t' + "Average" + '\t' + "Letter");

            /// <summary>
            /// writes new line to rich textbox
            /// </summary>
            scoresRTB.AppendText(Environment.NewLine);

            /// <summary>
            /// parses through all students to calculate grades
            /// </summary>
            for (int i = 0; i < numStuds; i++)
            {
                /// <summary>
                /// initializing student's grade to default value
                /// </summary>
                int studGrade = 0;

                /// <summary>
                /// writes student's names to rich textbox
                /// </summary>
                scoresRTB.AppendText(Convert.ToString(studentScore[i, 0]) + '\t' + '\t');

                /// <summary>
                /// summing all of student's assignment scores together
                /// </summary>
                for (int j = 1; j <= numAss; j++)
                {
                    studGrade += (int)(studentScore[i, j]);
                }

                /// <summary>
                /// calculating student's grade
                /// </summary>
                studGrade = studGrade / numAss;

                /// <summary>
                /// writes student's grades to rich textbox
                /// </summary>
                scoresRTB.AppendText(Convert.ToString(studGrade));

                /// <summary>
                /// creates new line in rich textbox
                /// </summary>
                scoresRTB.AppendText(Environment.NewLine);
            }
        } /// end displayScoreBtn()

        /// <summary>
        /// outputs student info to file
        /// </summary>
        private void outputBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// string for filename usage
            /// </summary>
            string filename;

            /// <summary>
            /// if output textbox is empty
            /// </summary
            if (String.IsNullOrWhiteSpace(outputTB.Text))
            {
                MessageBox.Show("You cannot enter a blank filename");

                outputTB.Text = "";

                return;
            }

            /// <summary>
            /// if output textbox contains numbers
            /// </summary>
            result = int.TryParse(outputTB.Text, out someNum);

            /// <summary>
            /// if numbers were entered
            /// instead of letters
            /// </summary>
            if (result)
            {
                MessageBox.Show("You must enter a valid filename");

                outputTB.Text = "";

                return;
            }

            /// <summary>
            /// else story filename for file io
            /// and clear the textbox for status
            /// </summary>
            else
            {
                /// <summary>
                /// storing filename
                /// </summary>
                filename = @"C:\" + outputTB.Text + @".txt";

                /// <summary>
                /// update textbox to writing
                /// </summary>
                outputTB.Text = "Writing to file...";

                /// <summary>
                /// disabling button while writing to file
                /// </summary>
                outputBtn.Enabled = false;
            }
            /// <summary>
            /// declare and initialize thread on writeToFile
            /// </summary>
            Thread thread = new Thread(writeToFile);

            /// <summary>
            /// start thread on filename
            /// </summary>
            thread.Start(filename);

            /// <summary>
            /// put thread to sleep for 2secs to simulate processing
            /// </summary>
            Thread.Sleep(2000);

            /// <summary>
            /// stop the thread once completed
            /// </summary>
            thread.Abort();

            /// <summary>
            /// update output textbox to finished
            /// </summary>
            outputTB.Text = "Finished";

            /// <summary>
            /// enable output button once completed
            /// </summary>
            outputBtn.Enabled = true;
        } /// end outputBtn()
        #endregion Events

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        private void writeToFile(object filename)
        {
            /// <summary>
            /// parses through all students to calculate grades
            /// </summary>
            for (int i = 0; i < numStuds; i++)
            {
                /// <summary>
                /// initializing student's grade to default value
                /// </summary>
                int studGrade = 0;

                /// <summary>
                /// summing all of student's assignment scores for grade
                /// </summary>
                for (int j = 1; j <= numAss; j++)
                {
                    studGrade += (int)(studentScore[i, j]);
                }

                /// <summary>
                /// calculating student's grade
                /// </summary>
                studGrade = studGrade / numAss;

                /// <summary>
                /// if file exists
                /// </summary>
                if (File.Exists(Convert.ToString(filename)))
                {
                    /// <summary>
                    /// create stream writer
                    /// </summary>
                    StreamWriter SW = new StreamWriter(filename.ToString());

                    /// <summary>
                    /// write student's names and grades to existing file
                    /// </summary>
                    SW.WriteLine(Convert.ToString(studentScore[i, 0]) + '\t' + Convert.ToString(studGrade) + '\n');

                    /// <summary>
                    /// close stream writer
                    /// </summary>
                    SW.Close();

                    /// <summary>
                    /// continue on with looping
                    /// </summary>
                    continue;
                }

                /// <summary>
                /// else if file does not exist
                /// </summary>
                else
                {
                    /// <summary>
                    /// create stream writer
                    /// </summary>
                    StreamWriter SW = new StreamWriter(filename.ToString());

                    /// <summary>
                    /// write student's names and grades to existing file
                    /// </summary>
                    SW.Write(Convert.ToString(studentScore[i, 0]) + '\t' + Convert.ToString(studGrade) + '\n');

                    /// <summary>
                    /// close stream writer
                    /// </summary>
                    SW.Close();

                    /// <summary>
                    /// continue on with looping
                    /// </summary>
                    continue;
                }
            }
        } /// end writeToFile()

        /// <summary>
        /// resets number of student's and assignment's textboxes
        /// </summary>
        private void resetTextbox()
        {
            numOfStudsTB.Text = "";
            numOfAssTB.Text = "";
        } /// end resetTextbox()

        /// <summary>
        /// enables bottom half of form when user
        /// enters valid number of students and
        /// assignments
        /// </summary>
        private void enableBtns()
        {
            resetBtn.Enabled = true;
            GB2.Enabled = true;
            GB3.Enabled = true;
            GB4.Enabled = true;
            displayScoreBtn.Enabled = true;
            outputBtn.Enabled = true;
            outputTB.Enabled = true;
            scoresRTB.Enabled = true;
        } /// end enableBtns()

        /// <summary>
        /// disables bottom half of form until
        /// user enters valid number of students
        /// and assignments or when Reset button
        /// is clicked
        /// </summary>
        private void disableBtns()
        {
            resetBtn.Enabled = false;
            GB2.Enabled = false;
            GB3.Enabled = false;
            GB4.Enabled = false;
            outputBtn.Enabled = false;
            outputTB.Enabled = false;
            displayScoreBtn.Enabled = false;
            scoresRTB.Enabled = false;
        } /// end disableBtns()
        #endregion Methods
    }
}
