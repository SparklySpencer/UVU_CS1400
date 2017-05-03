#region ProjectProlog
// Project Prolog
// Name: Spencer Carter
// CS 1400 Section 003
// Project: Lab_05
// Date: 1/28/2015
// 
// I declare that the following code was written by me, provided 
// by the instructor, or provided in the textbook for this project.
// I also declair understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
#endregion ProjectProlog
#region Psudocode
// Create a menu strip with about, clear, and exit options
// Create two text boxes
// Create two lables to tell the user which text box is which
// Create a buton to process the input and have it display in the output text box
// Objective:
// Have the user enter an int value in the first text box
// Have the user press the button, and it will display that value in the second text box
// Process:
// 0) user enters data and presses button
// 1) read text from frist text box
// 2) try to convert to string
// 3) convert int back into string
// 4) display the string in second text box
#endregion Psudocode
#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion Using
namespace Lab_05
{
    public partial class FrmInOut : Form
    {
        #region Const
        private const int INC_VAL = 42;
        #endregion Const
        /// <summary>
        /// Purpose: the entry point into the program.
        /// </summary>
        public FrmInOut()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: to display information about who made the program
        /// </summary>
        /// <param name="sender">aboutToolStripMenuItem</param>
        /// <param name="e">EventArgs e</param>
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            // when clicked, it will have a popup window that displays the creator's name and class
            // it will close when either a yes or a no is clicked.
            string aboutMsg = "Spencer Carter\nCS1400\nLab 05";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: to have a way to clear the information should the user want to
        /// </summary>
        /// <param name="sender">clearToolStripMenuItem</param>
        /// <param name="e">not used</param>
        private void MnuClear_Click(object sender, EventArgs e)
        {
            TxtBxIn.Text = ""; // returns the text box to a default value
            TxtBxOut.Text = ""; // returns the text box to a default value
        }
        /// <summary>
        /// Purpose: to close the program
        /// </summary>
        /// <param name="sender">exitToolStripMenuItem</param>
        /// <param name="e">not used</param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close(); // ends the program
        }
        /// <summary>
        /// Purpose: to process the input information and output it in the out textbox.
        /// I have modified the porgram to add 42 to the value of the input. (a joke the answer to life, universe and everything).
        /// </summary>
        /// <param name="sender">BtnProcess Event</param>
        /// <param name="e">Not Used</param>
        private void BtnProcess_Click(object sender, EventArgs e)
        {
            int iValue = 1;
            string sValue = TxtBxIn.Text; // initualize the string and make it equal to the text box input
            int.TryParse(sValue, out iValue); // tries to parse and puts it into intvalue, if not returns 1
            iValue = iValue + INC_VAL; // adds 7 to the int processed
            TxtBxOut.Text = string.Format("{0:D4}", iValue); // formats the display to show 4 or more digits in the out
        }
    }//End FrmInOut
}//End namespace Lab_05
