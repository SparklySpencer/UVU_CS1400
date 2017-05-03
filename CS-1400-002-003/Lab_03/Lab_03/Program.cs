#region Project Prologue
// Project Prolog
// Name: Spencer Carter
// CS 1400 02
// Project: Lab_03
// Date: 01/18/15
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
#endregion Project Prologue

using System;

namespace Lab_03
{
    static class Program
    {
        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
#region Constants
            // the following are declarations used in the program
            // I initulize them to a nutral start value
            string firstName = "n/a";
            int age = 0;
            double cash = 0.00;
#endregion Constants
            
            // write line for introduction "Hello, my name is Spock."
            Console.WriteLine("Hello, my name is JARVIS.");
            // asks user to type name "What is your name? "
            Console.WriteLine("What is your first name?");
            // stores the user input as a string "name"
            firstName = Console.ReadLine();
            // displays the name "Hello 'Sally', how old are you?"
            Console.WriteLine("Hello {0} how old are you?", firstName);
            // stores the input as an int "age"
            int.TryParse(Console.ReadLine(), out age);
            //age = int.Parse(Console.ReadLine());
            // asks another question "How much money do you have 'Sally'?"
            Console.WriteLine("How much money do you have {0}", firstName);
            // stores input as a double "cash"
            double.TryParse(Console.ReadLine(), out cash);
            //cash = double.Parse(Console.ReadLine());
            // displays all the input values in a nice message
            Console.WriteLine("Nice to meet you {0}. You are {1} years old, and have {2:C} dollars.", firstName, age, cash);
            //waits to close the program
            Console.Write("Press Enter to continue ... ");
            Console.ReadLine(); // terminates program when enter is pressed
            //Console.ReadKey(true); // terminates program when key is pressed?
            // read key did not work, I need to ask questions about it.
        }//End Main()
        
        /// <summary>
        /// Purpose: Vanity and learning new stuff.
        /// </summary>
        static public void SetUpConsole()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }// end SetUpConsole()
        // the colors did not change I need to ask questions about it.
}//End namespace Lab_03

