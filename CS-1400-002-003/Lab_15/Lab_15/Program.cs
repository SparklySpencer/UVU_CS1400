/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Lab #15 Dice Game Design
 * Date: 03/26/15
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
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    /// <summary>
    /// The class that is built by default for console apps
    /// </summary>
    class Program
    {
        /// <summary>
        /// the method that is built by default for the console apps
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.ReadKey(true);
        }
        #region The Problem
        /*
        Ask the user if they want to roll the dice (loop 1)
        get the user's responce and validate that it is either 'y' or 'n'
        if it is not y or n, tell the user that it is invalid
        
        if no:
        close
        
        if y:
        generate two random numbers in the range 1-6
        if 6 & 6, "you rolled boxcars"
        if 1 & 1, "you rolled snake-eyes"
        else show values
        read line to pause
        write enter or Q
        on enter loop to start
        on q quit (exit loop 2) do while
        double check for q (return to top loop 1)
        print goodbye message and quit

        ---Thoughts---
        1) basically a while with nested do while
        2) use a switch to test input convert to lower char 
        test chars and display invalid input case (3 cases and default for error)

        DO AN ACTIVITY DIAGRAM, submit 15, then work on 16.
         */
        #endregion The Problem



    }//End class Program
}//End namespace Lab_15
