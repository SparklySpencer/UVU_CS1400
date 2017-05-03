#region Project Prolog
// Name: Spencer Carter
// CS 1400 03
// Project: Lab_06
// Date: 02/07/15
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
#endregion Project Prolog
#region Psudocode
/*
 * Objective:
 // 00) Change the Console window: Background white, Foreground red, width of 1/2 LargestWindowWidth, height 1/2 LargestWindowHeight
 // 01)  Ask how much gold the pirate ship came into port with. (TEST Value of 9000)
 // 03) convert the string input to an int and store in _totalGold
 // 04) Ask how many pirates are on the ship, including the Captain and First mate. (TEST Value of 40)
 // 05) convert the string input to an int and store in _crew
 // 06) Take out the Captain's share of 12% (1056 Gold = 8800 Gold * 0.12)
 // 07) Take out the First mate's share of 8% (619 Gold = 7744 Gold * 0.08)
 // 08) Distribute 3 coins to every crew member (120 Gold = 40 crew members * 3 3 Gold) 
 // 09) Divy out the gold to all the crew (178 Gold = 7125 Gold / 40 Grew)
 // 10) If there is a remainder, it goes to the Pirate's Benevolent Association (5 Gold = 9000 Gold - 8995 Gold)
 // 11) Have the auditor check that the Cap'nsGold + FirstMateGold + crewGold * crew = totalGold.
 // 12) Display how much gold the Captain, First Mate, Crew, and PBA gets
 // 13) Display a "Press Enter to exit"
 // 14) Read the enter press and close
 */
#endregion Psudocode
using System;

namespace Lab_06
{
    static class Program
    {
        #region Const
        const int DIV = 2; // the div factor for the max window.
        #endregion Const
        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
            // 00) Change the Console window: Background white, Foreground red, width of 1/2 LargestWindowWidth, height 1/2 LargestWindowHeight
            Console.SetWindowSize(Console.LargestWindowWidth / DIV, Console.LargestWindowHeight / DIV);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            // 01)  Ask how much gold the pirate ship came into port with. (TEST Value of 9000)
            // 03) convert the string input to an int and store in _totalGold
            // 04) Ask how many pirates are on the ship, including the Captain and First mate. (TEST Value of 40)
            // 05) convert the string input to an int and store in _crew
            // 06) Take out the Captain's share of 12% (1056 Gold = 8800 Gold * 0.12)
            // 07) Take out the First mate's share of 8% (619 Gold = 7744 Gold * 0.08)
            // 08) Distribute 3 coins to every crew member (120 Gold = 40 crew members * 3 3 Gold) 
            // 09) Divy out the gold to all the crew (178 Gold = 7125 Gold / 40 Grew)
            // 10) If there is a remainder, it goes to the Pirate's Benevolent Association (5 Gold = 9000 Gold - 8995 Gold)
            // 11) Have the auditor check that the Cap'nsGold + FirstMateGold + crewGold * crew = totalGold.
            // 12) Display how much gold the Captain, First Mate, Crew, and PBA gets
            // 13) Display a "Press Enter to exit"
            // 14) Read the enter press and close
            Console.Write("Press Enter to continue ... ");
            Console.ReadLine();
        }//End Main()
    }//End class Program
}//End namespace Lab_06