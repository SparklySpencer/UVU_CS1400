/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Lab #20 Passing by Value, Passing by Reference and passing by out
 * Date: 04/16/15
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
using System;

namespace Lab_20
{
    /// <summary>
    /// The default class for console apps
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The default method for console apps
        /// </summary>
        static void Main()
        {
            CalcChange();
        }//End Main()

        /// <summary>
        /// This method will error check the user input, and if it passes, it will call another method that will make change.
        /// </summary>
        public static void CalcChange()
        {
            int money = 0;  // the value we want to count change for
            int numberCoins = 0;
            string inputStg = null;

            do
            {
                Console.Clear();
                Console.WriteLine(NoMagicThings.MSG_HEADER);
                Console.Write(NoMagicThings.MSG_ENTER);
                if (int.TryParse((inputStg = Console.ReadLine()), out money) == false)
                {
                    if (inputStg == "")
                    {
                        Console.WriteLine(NoMagicThings.MSG_GBYE);
                        Console.ReadLine();
                        return;
                    }
                    Console.WriteLine(NoMagicThings.MSG_INVALID);
                    Console.ReadLine();
                    continue;
                }
                else if (money < 0)
                {
                    Console.WriteLine(NoMagicThings.TOO_SMALL);
                    Console.ReadLine();
                    return;
                }
                else if (money > NoMagicThings.MAX)
                {
                    Console.WriteLine(NoMagicThings.TOO_BIG);
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine(NoMagicThings.MSG_MNY, money);
                //This for loop is based off the lenght of the COINS array
                for (int index = 0; index < NoMagicThings.COINS.Length; index++)
                {
                    //It will go through each time and pull out the highest denomination of coin it can before exiting
                    ComputeChange(ref money, NoMagicThings.COINS[index], out numberCoins);
                    Console.WriteLine(NoMagicThings.MSG_COIN + NoMagicThings.SCOINS[index], numberCoins);
                }
                Console.ReadLine();
            } while (true);
        }//End CalcChange( )

        /// <summary>
        /// This method is supposed to work by taking the input, remove the largest coin value from it, and pass out an int that is kinda like the count?
        /// </summary>
        /// <param name="changeValue">This value is the change remaining to be sorted into proper denominations</param>
        /// <param name="coinValue">I believe this will be the array values for the coin denominations based off their index posistion</param>
        /// <param name="nCoins">The count or number of coins to de dispensed.</param>
        static void ComputeChange(ref int changeValue, int coinValue, out int nCoins)
        {
            //  1 =        50 C    % (int)ECOINS.HALVES aka 50
            nCoins = changeValue / coinValue;
            changeValue = changeValue % coinValue;
        }//End ComputeChange( )
    }//End class Program
}