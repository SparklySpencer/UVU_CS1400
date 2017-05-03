#region Project Prologue
// Project Prolog
// Name: Spencer Carter
// CS 1400 Section 003
// Project: Project 02 Good Guy's Delivery Service
// Date: 02/04/2015
// 
// I declare that the following code was written by me, provided 
// by the instructor, or provided in the textbook for this project.
//Some very nice people from the drop in lab helped me take baby steps.
// I also declair understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.using System;
//
// I also declare that the image used for this project was provided as a stock image
// The content owner "joneswift7" published their work on DeviantArt under Stock Images
// The URL: http://fav.me/d45to50 Is where the image was obtained
// Fair Use: This is only to be used for educational, non comercial purposes.
// There will be no redistrabution outside the bounds of this assignment
// Any other purposes are for example only.
#endregion Project Prologue
#region Psudocode
//Objective:
// Get user input from text boxes, do some math, and output to the interface
//Description:
// Good guys has an existing time table, and wants us to make instant calculations for construction delays
//Program should do the following:
// 1) Prompt the user to enter a statting time in 24 hr format
// 2) Get the input as single int
// 3) Promt to enter the ending time in 24 (based off the old time table)
// 4) Get input as single int
// 5) Calculate the new time (+25% for construction)
// 6) Display the new end time in 24 hr format
//Interface:
// Menu Strip with Instructions, About, and Exit options
// 4 Prompts
// 3 text boxes (2 for input, 1 for new time)
// 2 Buttons (calculate, and exit)
#endregion Psudocode
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project_02
{
    /// <summary>
    /// Purpose: to calculate estimated travel times based off their book, while calculating for roadwork.
    /// </summary>
    public partial class FrmGoodGuys : Form
    {
        #region Constants
        private const double DELAY_FACTOR = 1.25; // time delay specified by teacher
        private const int VALUE_HUNDRED = 100; // helpful for breaking apart 24 hour time
        private const int VALUE_SIXTY = 60; // helpful for breaking hours into min
        #endregion Constants
        /// <summary>
        /// Purpose: Entry Point into the Program
        /// </summary>
        public FrmGoodGuys()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: To display information about the author.
        /// </summary>
        /// <param name="sender">aboutMnu_Click</param>
        /// <param name="e">EventArgs</param>
        private void aboutMnu_Click(object sender, EventArgs e)
        {
            // when clicked, it will have a popup window that displays the creator's name and class
            // it will close when either a yes or a no is clicked.
            string aboutMsg = "Spencer Carter\nCS1400\nProject 02";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: To end / exit the program when clicked
        /// </summary>
        /// <param name="sender">exitMnu_Click</param>
        /// <param name="e">Not used</param>
        private void exitMnu_Click(object sender, EventArgs e)
        {
            Close(); //ends the program
        }
        /// <summary>
        /// Purpose: To display instructions to the user, so they will know how to use the program
        /// </summary>
        /// <param name="sender">instructionsMnu_Click</param>
        /// <param name="e">EventArgs</param>
        private void instructionsMnu_Click(object sender, EventArgs e)
        {
            // when clicked, it will have a popup window that displays the instructions
            // it will close when either a yes or a no is clicked.
            string aboutMsg = "Instructions: \n Please enter all times in 24 hour format. \n Press the truck to calculate for the new time. \n\n Notice: \n The start time MUST be before the end time \n This program cannot compute distances over 19 hrs away \n\n Press exit to end your session.";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: to close the program
        /// </summary>
        /// <param name="sender">BtnExit_Click</param>
        /// <param name="e">not used</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close(); // ends the program
        }
        /// <summary>
        /// Purpose: Evaluate the data and output the new end time in the last text box (as described above in the psudocode)
        /// </summary>
        /// <param name="sender">BtnCalculate_Click</param>
        /// <param name="e">Not Used</param>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            #region Variables
            int _startTime = 0; // user entered
            int _startHours = 0; // divided and turned into min
            int _startMins = 0; // modulesed and the remainder is left
            int _stopTime = 0; // user entered
            int _stopHours = 0; // divided and turned into min
            int _stopMins = 0; // modulesed and the remainder is left
            int _newStop = 0; // the addition of all the stop minutes
            int _newStart = 0; // the addition of all start minutes
            int _newTime = 0; // the remainder of the stop - start min
            int _newDelay = 0; // the estimated minutes it would take to stop with the delay
            int _finalMins = 0; // will be the total time delay + start = new end in minutes
            int _milHours = 0; // will be how we convert the minutes back into hours
            int _milMins = 0; // will be the remaining minutes
            #endregion Var
            // 1) start time
            int.TryParse(textBxStart.Text, out _startTime); // user input
            _startHours = _startTime / VALUE_HUNDRED * VALUE_SIXTY; // taking those hours and turning it into min
            _startMins = _startTime % VALUE_HUNDRED; // getting the remainder in min
            // 2) original stop time
            int.TryParse(textBxOrigStop.Text, out _stopTime); // user input
            _stopHours = _stopTime / VALUE_HUNDRED * VALUE_SIXTY; // taking those hours and turning it into min
            _stopMins = _stopTime % VALUE_HUNDRED; // getting the remainder in min
            // 3) figureing out the new time
            _newStop = _stopHours + _stopMins; // adding up all the stop min
            _newStart = _startHours + _startMins; // adding up all the start min
            _newTime = (_newStop - _newStart); // figuring out the difference
            // 4) factoring the delay
            _newDelay = Convert.ToInt32(_newTime * DELAY_FACTOR); // taking the difference min and * by the delay factor =  delay min
            _finalMins = _newDelay + _newStart; // getting the delay min and the difference = the total time it will take
            // 5) cal military time
            _milHours = _finalMins / VALUE_SIXTY; // breaking the total time it will take and getting hours
            _milMins = _finalMins % VALUE_SIXTY; // breaking the total time it will take and getting the remaining min
            // 6) displaying the new time
            textBxFinalStop.Text = string.Format("{0:d2}:{1:d2}", _milHours, _milMins); // displaying the hours:min
        }
    }// end FrmGoodGuys : Form
}// end namespace Project 02
