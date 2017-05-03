/* Project Prologue
Name: Spencer Carter
Class: CS 1400 Section 003
Lab #16 Dice Game Implementation
Date: 04/08/15

    I worked with Bob Mccann briefly.
 
I declare that the following code was written by me, provided
by the instrustor, assisted via the lovely people in the drop
in lab, or provided in the textbook for this project. I also
understand that copying source code from any other sourece 
constitutes cheating, and that I will recieve a zero on this
project if I am found in violation of this policy.
 */

using System;

/* Psudocode Provided in Assignment Description
Uses a loop to fill the array by:
    1) Prompting the user for a value
    2) Storing the value in the array
    3) Terminates user input when a -1 is entered by the user
Passes the array to a method that:
    1) Creates a new array and adds 5 to each element
    2) adds up all of the elements in the array passed into the method and returns the sum (via out)
    3) returns the reference to the new array in the eax Register
    *) The method should work for any size of array.
Outputs the returned sum and the returned array
*/

namespace Lab_21
{
    /// <summary>
    /// The default class built for console apps
    /// </summary>
    class Program
    {
        #region Class Level Var
        //The vars found in the assignment description
        static int[] origArray = new int[NoMagicThings.ARRAY_SIZE]; // the original array
        static int[] prodArray; // the product array
        static int _product; // the sum of the product array
        static int _count;// will be the index of the array for each time it goes through.
        #endregion Class Level VAr

        /// <summary>
        /// The default method built for console apps
        /// </summary>
        static void Main()
        {
            GetData();
        }//End Main()
        /// <summary>
        /// The method that will ask for user input, fill a string array, and parse it into an int array
        /// </summary>
        static void GetData()
        {
            int stop; //Looks for the sentinal value
            string _userInput; // will be the container for the string input from the user, will also set up the condition for the do while loop.
            _count = 0; //Reset the value of count
            Console.WriteLine(NoMagicThings.MSG_INSTRUCTION); //Instructions how to enter values
            do //Uses a loop to fill the array by:
            {
                Console.Write(NoMagicThings.MSG_ENTER_VAL); //Prompting the user for a value
                _userInput = Console.ReadLine(); //Stores each input in a local var
                if (int.TryParse(_userInput, out stop) == false) //Parses the string input into an int, while checking if the try pase was true, if not error message
                {
                    Console.WriteLine(NoMagicThings.MSG_INVALID, _userInput);
                    Console.ReadKey();
                    continue;
                }
                else if (stop > 0) //If int value is not less than our sentinal value
                {
                    origArray[_count] = stop; //Storing the value in the array
                    _count++; //Increase the index
                }
            } while (_userInput != NoMagicThings.ARRAY_SENT && _count < NoMagicThings.ARRAY_SIZE); //Terminates when array is full
            ProductData(origArray, out _product); //This calls the product data method which will make a new array and find the sum
            Console.WriteLine(NoMagicThings.MSG_SHOW_NEW); //Prompting the user we are going to display the results of the new array.
            for (int n = 0; n < ProductData(origArray, out _product).Length; n++)
            {
                Console.WriteLine(NoMagicThings.MSG_PLACEHOLD, ProductData(origArray, out _product)[n]);
            }
            Console.Write(NoMagicThings.MSG_SUM, _product);
            Console.ReadKey();
        }//End GetData()
        /// <summary>
        /// Creates a second int array with altered values (from the oArray)
        /// </summary>
        /// <param name="oArray">The original int array that is passed in</param>
        /// <param name="pArray">The product int array that has altered values</param>
        /// <param name="_product">The sum or product of the pArray</param>
        static int[] ProductData(int[] oArray, out int product)
        {
            product = 0; //Initialize product so we can modify it and the method will be happy.
            int[] pArray = new int[_count]; //Blows the array up into existance in memory to be used.
            for (int i = 0; i < pArray.Length; i++) //This loop will add the increment value and place the product in the new array.
            {
                pArray[i] = origArray[i] + NoMagicThings.ARRAY_ADD;
            }
            for (int j = 0; j < pArray.Length; j++) //This loop will get the sum of the new values from the new array
            {
                product += pArray[j];
            }
            return pArray;
        }//End ProductData()
    }//End class Program
}//End namespace Lab_21
