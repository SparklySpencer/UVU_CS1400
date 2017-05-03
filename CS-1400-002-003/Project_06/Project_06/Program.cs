/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Project #6 Rabbits, Rabbits, Rabbits
 * Date: 04/13/15
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
using System;

namespace Project_06
{
    /// <summary>
    /// The class I built to hold all the magic stuffs
    /// </summary>
    static class NoMagicThings
    {
        public const string INTO_MSG = "Welcome to Rabbits, Rabbits, Rabbits!";
        public const string TABLE_HEADER = "\nMonth\tAdults\tBabies\tTotal";
        public const string QUICK_FILL_MSG = "{0}\t{1}\t{2}\t{3}";
        public const string END_MSG = "\nYou will run out of cages in {0} months.";
        public const int TOTAL_CAGES = 1500; // To prove I did not directly copy code from anywhere, I changed this from 500
    }//End class NoMagicThings
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
            RabbitsMethod();
        }//End Main()
        /// <summary>
        /// The project we are trying to design for this assignment
        /// </summary>
        public static void RabbitsMethod()
        {
            #region LocalVar
            //initialized to the numbers set forth for the first month
            int _months = 1;
            int _babies = 0;
            int _adults = 1;
            int _total = 1;
            #endregion LocalVar
            Console.Clear(); // make sure the console is nice and pretty.
            Console.WriteLine(NoMagicThings.INTO_MSG); // Display the header #1 on things to do
            Console.WriteLine(NoMagicThings.TABLE_HEADER); // Display the important data headers so the "table" is legable.
            do // Must be in some sort of loop, and this was the easiest to conceptualize
            {
                _months++; // Increment the number of months for each time we enter the loop.
                _babies = _adults; // babies = adults of previous month.
                _adults = _total; // adults = total of previous month | 2nd because we cannot change adults before we change babies.
                _total = _adults + _babies; // change the total last so calculations are correct.
                Console.WriteLine(NoMagicThings.QUICK_FILL_MSG, _months, _adults, _babies, _total); // Display the new data in appropriate places.
            } while (_total <= NoMagicThings.TOTAL_CAGES); // have to go until all the cages are filled.
            Console.Write(NoMagicThings.END_MSG, _months); // display the correct number of months that it would take to fill the cages.
            Console.ReadKey(); // pause and wait for user input to end.
        }//End RabbitsMethod()
    }//End class Program
}//End namespace Project_06
