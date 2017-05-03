/* Project Prologue
Name: Spencer Carter
Class: CS 1400 Section 003
Lab #16 Dice Game Implementation
Date: 04/08/15

I declare that the following code was written by me, provided
by the instrustor, assisted via the lovely people in the drop
in lab, or provided in the textbook for this project. I also
understand that copying source code from any other sourece 
constitutes cheating, and that I will recieve a zero on this
project if I am found in violation of this policy.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* The Problem:
The program, as written, sorts an array of integers in ascending order (the smallest number is first).
For this exercise, all you need to do is to change the program so that it sorts the array in descending order as well (the biggest number is first).
*/

namespace Lab_23
{
    /// <summary>
    /// The default class for console apps
    /// </summary>
    class Program
    {
        /// <summary>
        /// The default method for console apps
        /// </summary>
        static void Main()
        {
            // this is the date to be sorted
            int[] theData = { 45, 12, 23, 34 };

            // sort the array in ascending order
            // print out lots of messages so we can see the sort work
            for (int j = 0; j < theData.Length - 1; j++)  // index for outer loop is j
            {
                Console.WriteLine("Iteration {0} for the outer loop", j);
                for (int i = 0; i < theData.Length - 1; i++)  // index for inner loop is i
                {
                    Console.WriteLine("\nIteration {0} for the inner loop", i);
                    if (theData[i] < theData[i + 1])
                        Swap(ref theData[i], ref theData[i + 1]);
                }
            }

            // print out the sorted array
            Console.WriteLine("\n\n*****  The sorted array is: *****");
            for (int i = 0; i < theData.Length; i++)
            {
                Console.Write("{0} ", theData[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        // method prototype for the swap routine
        // parameters: two integers, passed by reference
        // routines: none
        // The two integer values are swapped
        // ---------------------------------------------------
        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine("Swapping {0} and {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
        }
    }//End class Program
}//End namespace Lab_23
