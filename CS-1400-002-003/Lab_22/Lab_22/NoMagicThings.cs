using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_22
{
    /// <summary>
    /// The class I built to hold literals for all other parts of the program.
    /// </summary>
    class NoMagicThings
    {
        //The max size of the array will be 25.
        public const int ARRAY_SIZE = 25;
        public const int ARRAY_ADD = 2;
        public const int GET_MIN = 1;
        public const int GET_MAX = 5;

        //string prompts.
        public const string MSG_INST = "Enter up to a total of 25 (count will be 0-24) ints,\n\twhich are seperated by commas and/or spaces.\n\tTo quit: enter a zero (at any time) and press enter.";
        public const string MSG_ENTER_VAL = "\nTotal int values so far {0}: ";
        public const string MSG_SHOW_NEW = "\nThe following are the results from your array.";
        public const string MSG_PLACEHOLD = "{0}";
        public const string MSG_SUM = "\nThe product of all the elements in your new array is: {0:#.###e+00}. ";
        public const string MSG_INVALID_STRING = "Invalid Input: \"{0}\" is a string, try again.";
        public const string MSG_INVALID_INT = "Invalid Input: \"{0}\" is not greater than 0, try again.";
        public const string MENU_WRONG = "Invalid menu selection!";
        public const string STOP_CHECK = "0";
        public const string MSG_TOO_MANY = "You added too many elements for us to calculate, the first 25 will be used.";
        //Menu() string prompts.
    }//End class MoMagicThings
}//End namespace Lab_22
