/* Project Prolog
 * Name: Spencer Carter
 * CS 1400 Section 3
 * Lab #9 - Coding Farmer John's Pseudo-Code
 * Date: 02/26/2015
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */

using System;

namespace Lab_09
{
    static class Program
    {
        #region Const
        private const int FOUR = 4;
        private const int TWO = 2;
        private const char CHAR_FALSE = 'F';
        private const char CHAR_YES = 'Y';
        private const double ACRE_SQ_METERS = 4046.85642;
        #endregion Const
        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
            FieldSprinklerSystem();
        }//End Main()
        /// <summary>
        /// Purpose: This will be the method that calculates the watered and non watered areas of the field in Lab_08
        /// </summary>
        static void FieldSprinklerSystem()
        {
            SizeWindow();
            #region Psudocode
        /* The following psudocode is for a method that will work in this program
         * Switched unit of measure to meters. (will convert to acres easyer).
         * 01) set up a do while loop / post test loop. Put everything inside
         * 02) Ask the user to input the radius of a single circle
         * 03) store that input as a double _radius
         * 04) calculate area for a single circle
         * _areaCircle = PI * (_radius * _radius)
         * 05) Calculate the area of the square
         * _areaSquare = 4 * _radius // 4 is a magic number and will need to be a const
         * 06) calculate the unwaterd middle section by - 4 90~degree sectiions = 1 360 degree = 1 circle
         * _areaNoWater = _areaSquare - _areaCicle
         * 07) calculate the watered sections
         * _areaWater = _areaCircle * 4
         * 08) Display the totals to the user, be sure to include what measure we are using
         * 09) reach the post test, see if the user wants to try again
         * 10) Catch any errors in the yes or no with another post test loop and prompt again if needed
         * 11) if not ask the user to press a key to exit
         * 12) read key press to close
         */
        #endregion Psudocode
            #region Initialized Var
            string _userInput = ""; // for error correction
            char _userChoice = '\n'; // will be used to determine if the user wants to try again.
            double _radius = 0.0; // user input
            #endregion Initialized Var
            do
            {
                do
                {
                    Console.Clear(); // clearing the garbage to keep things looking clean when we loop back
                    _userChoice = '\n'; // reset to null character so we can escape the if loop
                    Console.WriteLine("Coding Farmer John's Pseudo-Code\n"); // the title of the project
                    Console.Write("Enter the Sprinkler Radius in Meters: ");
                    
                    _userInput = Console.ReadLine();
                    double.TryParse(_userInput, out _radius);
                    if (_radius <= 0)
                    {
                        Console.WriteLine("{0} is an invalad input, please try again.", _userInput);
                        MakeReady();
                        _userChoice = CHAR_FALSE;
                    }
                    else
                    {
                        continue;
                    }
                }while(_userChoice == CHAR_FALSE);
                double _areaCircle = Math.PI * (_radius * _radius);
                _areaCircle = _areaCircle / ACRE_SQ_METERS;
                double _areaSquare = (TWO * _radius) * (TWO * _radius); // L = r + r, W = r + r, A = L * W
                _areaSquare = _areaSquare / ACRE_SQ_METERS;
                double _areaDrought = _areaSquare - _areaCircle;
                double _areaWetness = FOUR * _areaCircle;
                Console.WriteLine("\nBased off your input, we will display the area of your field in Acres.");
                Console.WriteLine("Press Any Key to Continue... ");
                Console.ReadKey(true);
                Console.WriteLine("\nYour sprinkler system waters {0} conjoined circular fields, with an area of {1:f3} acres each." +
                    "\nThe total watered section is {2:f3} acres, and the unwatered section is {3:f3} acres.", FOUR, _areaCircle, _areaWetness, _areaDrought);
                Console.Write("\nDo you want to try again? Enter Yes or No: ");
                _userChoice = ((_userInput = Console.ReadLine()) == "" ? CHAR_FALSE : char.ToUpper(_userInput[0]));
            }while(_userChoice == CHAR_YES);
            MakeReady();
        }//End FieldSprinklerSystem()
        /// <summary>
        /// Purpose: to clean up the console and to either move to the next method or close the console.
        /// </summary>
        static void MakeReady()
        {
            Console.Write("Press Any Key to Continue... ");
            Console.ReadKey(true);
            Console.Clear();
        }//End ConsoleMakeReady()
        /// <summary>
        /// Purpose: to make the window a proper size
        /// </summary>
        private static void SizeWindow()
        {
            Console.SetWindowSize(Console.LargestWindowWidth / TWO, Console.LargestWindowHeight / TWO);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }//End SizeWindow()
    }//End class Program
}//End namespace Lab_09

