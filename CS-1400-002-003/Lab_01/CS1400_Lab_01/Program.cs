// Project Prolog
// Name: Spencer Carter
// CS-1400-002-003-SPRING 2015-XLIST
// Project: CS1400_Lab_01
// Date: 12/29/2014 7:25:06 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

namespace Lab_01
{
    static class Program
    {
        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
            // The following code stores information in string variables
            string name = "Spencer Carter";
            string course = "CS 1400";
            string section = "002/003";
            string project = "Lab One";
            string stuff = "Unique Stuff";
            string drink = "Pepsi Cola";
            // The following code will display the strings, found above, on the console
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Course: {0}", course);
            Console.WriteLine("Section: {0}", section);
            Console.WriteLine("Project: {0}", project);
            Console.WriteLine("Stuff: {0}", stuff);
            Console.WriteLine("Drink Preference: {0}", drink);
            // The following code freezes the Console until the enter key is pressed
            Console.Write("Press Enter to continue ... ");
            Console.ReadLine();
        }//End Main()
    }//End class Program
}//End namespace Lab_01
