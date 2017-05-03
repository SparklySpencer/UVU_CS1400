// File Prolog
// Name: Spencer Carter
// CS 1400 Section 03
// Project: CS1400_Lab_18
// Date: 04/01/2014
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

static class Program
{
    /// <summary>
    /// Purpose: Entry point to your C# program
    /// </summary>
    static void Main()
    {
        new LeapYear().LeapMenu();
    }//End Main()
}//End class Program

/// <summary>
/// The prebuilt class that was found in our assignment.
/// </summary>
class LeapYear
{
    #region No Magic Things
    private string inputStg = null;
    private int year = 0;
    public const int FIRST_LEAP_YEAR = 1582;
    public const int LEAP_MAGIC = 4;
    public const int LEAP_SPECIAL = 400;
    public const int LEAP_NOT = 100;
    public const string BadInput = "\n\tInvalid input -> {0}, try again!";
    #endregion No Magic Things

    /// <summary>
    /// The terrible menu system that was prebuilt for us.
    /// </summary>
    public void LeapMenu()
    {
        // main program loop
        // get and validate response
        do
        {
            Console.Clear();
            Console.WriteLine("----------------- Leap Year Tester -----------------\n\n");
            Console.Write("\tTest for leap year Y)es or N)o: ");
            switch (((inputStg = Console.ReadLine()) != "") ?
                    (char.ToLower(inputStg[0])) : 'X')
            {
                case 'y':
                    TestLeapYear();
                    continue;
                case 'n':
                    Console.WriteLine("\n\t..... Goodbye! .....");
                    Console.ReadLine();
                    return;
                case 'X':
                    inputStg = "<empty>";
                    Console.WriteLine(BadInput, inputStg);
                    Console.ReadLine();
                    continue;
                default:
                    Console.WriteLine(BadInput, inputStg);
                    Console.ReadLine();
                    continue;
            }
        } while (true);
    }//End LeapMenu( )
    /// <summary>
    /// This method tests for valid input to pass to the IsLeapYear method.
    /// </summary>
    public void TestLeapYear()
    {
        do
        {
            // declare some variables
            Console.Clear();
            // get a year from the user
            Console.Write("\n\tEnter in a year, or press Enter to exit: ");
            if (int.TryParse(((inputStg = Console.ReadLine()) == "") ? inputStg = "X" : inputStg, out year) == false)
            {
                if (inputStg == "X")
                    return;
                Console.WriteLine("\tInvalid year value -> {0}", inputStg);
                Console.ReadLine();
                continue;
            }
            else if (year < FIRST_LEAP_YEAR)
            {
                Console.WriteLine("\tLeaps Years started in {0}, pick a year after that.", FIRST_LEAP_YEAR);
                Console.ReadKey(true);
                continue;
            }
            else
                // test it with method and output result
                Console.WriteLine(((IsLeapYear(year)) ? "\n\t{0:d} --> IS a Leap Year." : "\n\t{0:d} --> NOT a Leap Year."), year);
                Console.ReadLine();
            continue;
        } while (true);

    }//End TestLeapYear( )

    /// <summary>
    /// Purpose:  Determines if the year passed as a parameter is a leap year
    /// it is a leap year, if the year is divisible by 4,
    /// but not divisible by 100 unless it is divisible by 400
    /// </summary>
    /// <param name="year">the year to test as an int</param>
    /// <returns>true if its a leap year otherwise false</returns>
    public bool IsLeapYear(int year)
    {
        if (year % LEAP_SPECIAL == 0)
        {
            return true;

        }
        else if (year % LEAP_MAGIC == 0 && (year % LEAP_NOT != 0 ))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}//End class LeapYear
