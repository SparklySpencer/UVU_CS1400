/* Project Prolog
 * Name: Spencer Carter
 * CS 1400 Section 3
 * Lab_08 ~ Farmer John Pseudo-Code
 * Date: 02/20/2015
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
using System;
namespace Lab_08
{
    static class Program
    {
        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
            ConsoleMakeReady();
        }//End Main()
        #region Psudocode
        /* The following psudocode is for a method that will work in this program
         * Note: all units will be in acres!
         * 01) set up a do while loop / post test loop. Put everything inside
         * 02) Ask the user to input the radius of a single circle
         * 03) store that input as a double _radius
         * 04) calculate area for a single circle
         * _areaCircle = PI * (_radius * _radius)
         * 05) Calculate the area of the square
         * _areaSquare = 4 * _radius // 4 is a magic number and will need to be a const
         * 06) calculate the unwaterd middle section by - 4 45degree sectiions = 1 360 degree = 1 circle
         * _areaNoWater = _areaSquare - _areaCicle
         * 07) calculate the watered sections
         * _areaWater = _areaCircle * 4
         * 08) Display the totals to the user, be sure to include what measure we are using
         * 09) reach the post test, see if the user wants to try again
         * 10) Catch any errors in the yes or no with another post test loop and prompt again if needed
         * 11) if not ask the user to press a key to exit
         * 12) read key press to close
         */
        /// <summary>
        /// Purpose: to clean up the console and to either move to the next method or close the console.
        /// </summary>
        static void ConsoleMakeReady()
        {
            Console.Clear();
            Console.Write("Press Any Key to Continue... ");
            Console.ReadKey(true);
        }//End ConsoleMakeReady()
        #endregion Psudocode
    }//End class Program
}//End namespace Lab_08

