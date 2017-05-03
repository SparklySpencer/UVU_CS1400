/* Project Prolog
 * Name: Spencer Carter
 * CS 1400 Section 3
 * Lab #11 Implementing the Token Machine Class
 * Date: 03/12/15
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab, and/or provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
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
            Application.Run(new Frm_TokenGiver());
        }
    }
}
