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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project_01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            #region Prebuilt Application stuff
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCalc());
            #endregion Prebuilt Application stuff
        }// end of Main
    }// end of Program
}// end of Project_01
