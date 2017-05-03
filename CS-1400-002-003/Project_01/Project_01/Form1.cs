#region Project Prologue
// Project Prolog
// Name: Spencer Carter
// CS 1400 Section 003
// Project: Simple Calculator
// Date: 1/23/2015
// 
// I declare that the following code was written by me, provided 
// by the instructor, or provided in the textbook for this project.
// I had some help from the drop in lab.
// I also declair understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.using System;
#endregion Project Prologue
#region Psudocode Plan
//0.1) add 3 text boxws
//0.2) add 3 lables
//0.3) add 7 buttons (+,-,*,/,about,clear,exit
//0.4) declare variables (_data1, _data2, _solution)
// >---1) capture the input from TxtBxData1 and put it into _data1
//1.1) parse string into double
//2) capture the input from TxtBxData2 and put it into _data2
//2.1) parse string into double
//3) have user press a button
//4) have that button do some math (I already assigned what the buttons do)
//5) have the solution display in the TxtBxSolution ---<
//6) change the answer if another button is clicked
// 7) Add menu bar with about and exit options
// 8) about bar will display the about section
// 9) exit bar will close the program
#endregion Psudocode Plan
#region Prebuilt Using Stuffs
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion Prebuilt Using Stuffs
namespace Project_01
{
    public partial class FrmCalc : Form
    {
#region Variable Declarations      
        /// <summary>
        /// Purpose: to initialize the varables before the program starts
        /// </summary>
        private double _data1 = 0.0;
        private double _data2 = 0.0;
        private double _solution = 0.0;
#endregion Variable Declarations
        /// <summary>
        /// Purpose: FrmCalc() is the program which uses two text boxes,
        /// does a math operation (indicated below {+, -, *, /})
        /// and displays the answer in a third text box.
        /// </summary>
        public FrmCalc()
        {
            
            InitializeComponent();
        }// end of FrmCalc
        /// <summary>
        /// Purpose: this will select the + operand for the math problem
        /// </summary>
        /// <param name="sender">BtnAdd_Click</param>
        /// <param name="e">Not Used</param>
        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            //on click it selects the addition operand for the equation
            double.TryParse(TxtBxData1.Text, out _data1); // gets the text from the first text box
            double.TryParse(TxtBxData2.Text, out _data2); // gets the text from the second text box
            _solution = _data1 + _data2; // does the math operation
            TxtBxSolution.Text = string.Format("{0:f2}", _solution); // displays the answer in the last text box
        }
        /// <summary>
        /// Purpose: This will select the subtract math function
        /// </summary>
        /// <param name="sender">BtnSubtract_Click</param>
        /// <param name="e">Not Used</param>
        private void BtnSubtract_Click(object sender, System.EventArgs e)
        {
            //on click it selects the - operand for the math problem
            double.TryParse(TxtBxData1.Text, out _data1); // gets the text from the first text box
            double.TryParse(TxtBxData2.Text, out _data2); // gets the text from the second text box
            _solution = _data1 - _data2; // does the math operation
            TxtBxSolution.Text = string.Format("{0:f2}", _solution); // displays the answer in the last text box
        }
        /// <summary>
        /// Purpose: This will select the * operand for the math problem
        /// </summary>
        /// <param name="sender">BtnMultiply_Click</param>
        /// <param name="e">Not Used</param>
        private void BtnMultiply_Click(object sender, System.EventArgs e)
        {
            // on click it selects the multiply operand for the equation
            double.TryParse(TxtBxData1.Text, out _data1); // gets the text from the first text box
            double.TryParse(TxtBxData2.Text, out _data2); // gets the text from the second text box
            _solution = _data1 * _data2; // does the math operation
            TxtBxSolution.Text = string.Format("{0:f2}", _solution); // displays the answer in the last text box
        }
        /// <summary>
        /// Purpose: this will select the / operand for the math problem
        /// </summary>
        /// <param name="sender">BtnDivide_Click</param>
        /// <param name="e">Not Used</param>
        private void BtnDivide_Click(object sender, System.EventArgs e)
        {
            //on click it selects the division operand for the equation
            double.TryParse(TxtBxData1.Text, out _data1); // gets the text from the first text box
            double.TryParse(TxtBxData2.Text, out _data2); // gets the text from the second text box
            _solution = _data1 / _data2; // does the math operation
            TxtBxSolution.Text = string.Format("{0:f2}", _solution); // displays the answer in the last text box
        }
        /// <summary>
        /// Purpose: To respond to the About button click event and display a message
        /// </summary>
        /// <param name="sender">BtnAbout_Click</param>
        /// <param name="e">EventArgs Object</param>
        private void BtnAbout_Click(object sender, System.EventArgs e)
        {
            // when clicked, it will have a popup window that displays the creator's name and class
            // it will close when either a yes or a no is clicked.
            string aboutMsg = "Spencer Carter\nCS1400\nProject 01";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: To restore the default settings
        /// </summary>
        /// <param name="sender">BtnClear_Click</param>
        /// <param name="e">Not Used</param>
        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            //on click it removes all text from the text boxes, basicall a restart or refresh.
            _data1 = 0.00; // resets to default
            _data2 = 0.00; // resets to default
            _solution = 0.00; // resets to default
            TxtBxData1.Text = "0.00"; // reset first text box
            TxtBxData2.Text = "0.00"; // resets second text box
            TxtBxSolution.Text = "0.00"; // resets the answer text box
        }
        /// <summary>
        /// Purpose: To respond to the Exit button click ebent and close the program
        /// </summary>
        /// <param name="sender">BtnExit_Click</param>
        /// <param name="e">Not Used</param>
        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            // closes the program when clicked
            Close();
        }
        /// <summary>
        /// Purpose: to display information about who made the program
        /// </summary>
        /// <param name="sender">aboutToolStripMenuItem</param>
        /// <param name="e">EventArgs</param>
        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // when clicked, it will have a popup window that displays the creator's name and class
            // it will close when either a yes or a no is clicked.
            string aboutMsg = "Spencer Carter\nCS1400\nProject 01";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: resets the text boxes to 0.00
        /// </summary>
        /// <param name="sender">clearToolStripMenuItem</param>
        /// <param name="e">not used</param>
        private void clearToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            //on click it removes all text from the text boxes, basicall a restart or refresh.
            _data1 = 0.00; // resets to default
            _data2 = 0.00; // resets to default
            _solution = 0.00; // resets to default
            TxtBxData1.Text = "0.00"; // reset first text box
            TxtBxData2.Text = "0.00"; // resets second text box
            TxtBxSolution.Text = "0.00"; // resets the answer text box
        }
        /// <summary>
        /// Purpose: ends the program
        /// </summary>
        /// <param name="sender">exitToolStripMenuItem</param>
        /// <param name="e">not used</param>
        private void exitToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            Close(); // ends the program
        }
    }// end of FrmCalc
}// end of Project_01
