/* Project Prologue
Name: Spencer Carter
Class: CS 1400 Section 003
Project 08 Bowling Team Scores
Date: 04/20/15

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

namespace Project_08
{
    /// <summary>
    /// Default class for console apps
    /// </summary>
    class Program
    {
        static BowlingLogic bl; //A class level reference to the logic class.
        static int _count;
        /// <summary>
        /// Default method built for console apps
        /// </summary>
        static void Main()
        {
            RainbowCake();
        }
        /// <summary>
        /// This method will get names and scores from the user, by calling on a class method.
        /// </summary>
        /// <returns>true if there are more places to fill, false if the array is full.</returns>
        public static void GetInput()
        {
            bool _go = true;
            _count = 0;
            do
            {
                Console.Write(NoMagicThings.NEW_PLAYER_TO_ADD);
                string input = Console.ReadLine();
                if (input == "")
                {
                    _go = false;
                }
                else
                {
                    try
                    {
                        bl.AddNewPlayer(input);
                    }
                    catch (IndexOutOfRangeException a)
                    {
                        Console.WriteLine(a.Message);
                        Console.ReadKey();
                        _go = false;
                        _count--;
                    }
                    catch (Exception b)
                    {
                        Console.WriteLine(b.Message);
                        Console.ReadKey();
                        _count--;
                    }
                }
                _count++;
            } while (_go == true && _count < 10);
        }//End GetInput()
        public static void RainbowCake()
        {
            bl = new BowlingLogic();
            GetInput();
            Console.Clear();
            Console.WriteLine(bl.PrintGame());
            Console.ReadKey();
        }
    }//End class Program
}//End namespace Project_08
