// Project Prolog
// Name: Spencer Carter
// CS 1400 Section 003
// Project: Lab_04
// Date: 1/21/2015
// 
// I declare that the following code was written by me, provided 
// by the instructor, or provided in the textbook for this project.
// I also declair understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    public partial class FrmLearnMnuStrip : Form
    {
        /// <summary>
        /// Purpose: Entry point into the application.
        /// </summary>
        public FrmLearnMnuStrip()
        {
            InitializeComponent();
        }//End FrmLearnMnuStrip()
        /// <summary>
        /// Purpose: To respond to the Exit menu event and close the program
        /// </summary>
        /// <param name="sender">Exit Menue</param>
        /// <param name="e">Not Used</param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            // close program when the exit menu button is clicked
            Close();
        }//End MnuExit_Click()
        /// <summary>
        /// Purpose: To respond to the About menu click event and display a message box
        /// </summary>
        /// <param name="sender">About Menu Click Event</param>
        /// <param name="e">EventArgs Object</param>
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            // display a message about who wrote the program in a popup, and have it exit by clicking either yes or no
            string aboutMsg = "Spencer Carter\nCS1400\nLab #04";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg,headerMsg,MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }//End MnuAbout_Click()
    }//end of CS1400_Lab_04 : Form
}//end of namespace
