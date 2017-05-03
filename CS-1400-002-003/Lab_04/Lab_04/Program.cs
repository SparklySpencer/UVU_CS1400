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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLearnMnuStrip());
        }// end main
    }// end program
}// end namespace
