// Project Prolog
// Name: Spencer Carter
// CS 1400 Section 003
// Project: Lab_02
// Date: 1/13/2015
// 
// I declare that the following code was written by me, provided 
// by the instructor, or provided in the textbook for this project.
// I also declair understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
//
// Image resources obtained for this file include:
// Ryoku Tensigan (c) Spencer Carter (aka Theos-Kengen) all rights reserved.
// The image was provided by the copyright owner (aka me) for educational purposes.
// The image is not to be distributed to third parties,
// and may not be shared other than for its intended purpose (this particular assignment).
// ---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    //--------------------- pseudo-code -----------------------
    //place LblInfo "Programming in C# can be fun" Font Blackadder ITC Size 18  
    //PBoxImage to display the image selected
    //BtnClose to close the program
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Purpose: Creates the FrmMain and initializes all of the controls
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: On event BtnClose, it will close the program and exit
        /// </summary>
        /// <param name="sender">BtnClose event</param>
        /// <param name="e">Not used</param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        } // this closes the program when the button is clicked
    } // end of FrmMain
} // end of namespace
