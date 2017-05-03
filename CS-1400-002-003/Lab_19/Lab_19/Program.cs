/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Lab #16 Dice Game Implementation
 * Date: 04/08/15
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 *
 * Jordan Woodhouse and I worked together on this project.
 */

using System;

static class Program
{
    /// <summary>
    /// Purpose: Entry point to your C# program
    /// </summary>
    static void Main()
    {
        BS_Code_Found_In_Assignment();
    }//End Main()
    /// <summary>
    /// The shit the assignment gave us to work with.
    /// </summary>
    private static void BS_Code_Found_In_Assignment()
    {
        int iVal1 = 5;
        int iVal2 = 7;
        //Call the Swap method with two arguments
        Console.WriteLine("Your starter values {0:D}, and {1:D}", iVal1, iVal2);
        SwapRef(ref iVal1, ref iVal2);
        Console.WriteLine("Swapped via REF values {0:D}, and {1:D}", iVal1, iVal2);
        SwapOut(iVal1, iVal2, out iVal1, out iVal2);
        Console.WriteLine("Swapped via OUT values {0:D}, and {1:D}", iVal1, iVal2);
        Console.WriteLine("Press Enter to continue ...");
        Console.ReadLine();
    }
    /// <summary>
    /// Purpose: To swap the two parameters passed to this method
    /// </summary>
    /// <param name="num1">num1 int, first number</param>
    /// <param name="num2">num2 int, second number</param>
    static public void SwapRef(ref int num1, ref int num2)
    {
        int tempInt = num1;
        num1 = num2;
        num2 = tempInt;
    }
    /// <summary>
    /// Brings in coppies and then puts them in the out
    /// </summary>
    /// <param name="num1">the i value to swap</param>
    /// <param name="num2">the second i value to swap</param>
    /// <param name="num3">the out for the second i value</param>
    /// <param name="num4">the out for the first i value</param>
    static public void SwapOut(int num1, int num2, out int num3, out int num4)
    {
        num4 = num1;
        num3 = num2;
    }

    /*How it works -- aka the stupidest part of this whole damn assignment
    REF
    "Data can also be passed to a method by ref (reference).
    When an argument is passed by ref (reference), the compiler puts a handle to the address for the argument passed to the method,
    on it’s run-time Stack, not a copy of its value.
    Now, when the method uses the argument, it uses the actual variable whose handle (address) to the parameter that was passed on the Stack, not a copy of the value of the variable. "
    
    OUT
    "Data can also be passed back from a method via the out parameter.
    When an argument is passed by out the method must pass a value out through this parameter,
    the compiler puts a handle to the address to the out argument passed to the method on it’s run-time Stack,
    not a copy of its value. Now, when the method uses the argument,
    it uses the actual variable whose handle to it’s out parameter passed on the Stack,
    not a copy of the value of the variable."
    */

}//End class Program
