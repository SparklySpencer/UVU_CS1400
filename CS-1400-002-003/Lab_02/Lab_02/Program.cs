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
    static class Program
    {
        ///{summary}
        ///The main entry point for the application
        ///{/summary}
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        } // end of Main
    } // end of Program
} // end of namespace