/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Project #5 Shipping Rates
 * Date: 03/31/15
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_05
{
    /// <summary>
    /// The default class built for programs
    /// </summary>
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
            Application.Run(new Frm_ShipRate());
        }
    }//End class Program
}//End namespace Project_05
