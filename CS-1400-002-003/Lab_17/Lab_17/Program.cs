/* Project Prologue
Name: Spencer Carter
Class: CS 1400 Section 003
Lab #16 Dice Game Implementation
Date: 04/08/15
 
I declare that the following code was written by me, provided
by the instrustor, assisted via the lovely people in the drop
in lab, or provided in the textbook for this project. I also
understand that copying source code from any other sourece 
constitutes cheating, and that I will recieve a zero on this
project if I am found in violation of this policy.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Psudocode Stuff
Have a menu system that checks if they want to play or not
    Have the menu system check for int cases, because that is the easiest to error proof
Call a method to ask for a year to test
    error check the input
    make sure it is above the first leap year
    pass the valid year to a method
The method will check if the passed year value is a year
Then it will pass it back to the method to a console write which will tell the user if it is or is not a leap year
*/

namespace Lab_17
{
    /// <summary>
    /// Default class for console apps.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Default method for console apps.
        /// </summary>
        static void Main()
        {
            //to hold the console open to make people happy.
            Console.ReadKey();
        }//End static void Main()
    }//End class Program
}//End namespace Lab_17
