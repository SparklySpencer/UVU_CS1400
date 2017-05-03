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

I worked with the following people:
Brad Woodward
Jordan Woodhouse
Tess Stoddard
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Psudo Stuffs
Create an array of 25 ints
Ask user to enter 5 ints (commas and / or spaces to seperate)

    1) static void GetData(){}
        a) creates the array of ints and fills it with ints entered via the user
        b) the string entered via the user is split (removeing the commas and spaces)
        c) then parsed into ints and stored into a new array of ints
    2) static void ProductData(int[] oArray, out int[] pArray, out int _product){}
        d) called from GetData
        e) adds 2 to each element of the array passed
        f) produces the product of all the values in the second array
        g) returns both the product and the second array (via out)
    3) make sure that the methods will handle a partially filled and full array
        by passing the number of values stored in the array as a parameter.
        when filling the array allow the user to stop (on 0) at any point
*/

namespace Lab_22
{
    /// <summary>
    /// The default class built for console apps
    /// </summary>
    class Program
    {
        /// <summary>
        /// The default method built for console apps
        /// </summary>
        static void Main()
        {
            StartThisShit();
        }//End Main()
        /// <summary>
        /// A method so that there is only one thing inside of main.
        /// </summary>
        private static void StartThisShit()
        {
            ArrayBullshit aBS = new ArrayBullshit();
            do
            {
                aBS.GetData();
            } while (true);
        }//End StartThisShit()
    }//End class Program
}//End namspace Lab_22
