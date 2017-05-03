using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_21
{
    class NoMagicThings
    {
        //The max size of the array will be 25.
        public const int ARRAY_SIZE = 10;

        //The sentinel value that will allow the user to stop adding values to the array.
        public const string ARRAY_SENT = "-1";

        //The instructions say to add two to each of the values.
        public const int ARRAY_ADD = 5;

        //GetData() string prompts.
        public const string MSG_INSTRUCTION = "Please enter int values, which are:\n\n\tgreater than 0\n\tentered one value at a time\n\tand up to 10 values\n\tEnter a -1 at anytime to stop";
        public const string MSG_ENTER_VAL = "\nPlease enter your int Value: ";
        public const string MSG_SHOW_NEW = "\nThe following are the results from your new array.";
        public const string MSG_PLACEHOLD = "{0}";
        public const string MSG_SUM = "\nThe sum of your new array is {0}. ";
        public const string MSG_INVALID = "Invalid Input: \"{0}\" is a string, try again.";
    }
}
