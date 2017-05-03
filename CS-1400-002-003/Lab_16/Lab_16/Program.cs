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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    /// <summary>
    /// The default class for console apps
    /// </summary>
    class Program
    {
        //Reference to the Random class
        static Random _diceGen;
        //Regions for no magic things.
        #region NoMagicThings -- MenuSystem() Vars
        const string MENU_DISPLAY = "Please make a selection:\n" +
                                    "\t1) Dice Game\n" +
                                    "\t666) Quit\n" +
                                    "\t\tEnter selection:  ";
        const int ITEM_1 = 1;
        const int ITEM_QUIT = 666;
        const string KEY_GOODBYE = "\nThanks for playing!\n";
        const string MENU_WRONG = "Invalid menu selection!";
        #endregion
        #region NoMagicThings -- DiceGame() Vars
        const int ITEM_2 = 2;
        const int ITEM_6 = 6;
        const int ITEM_7 = 7;
        const string ROLL_1 = "You rolled Aces! {0}, and {1}"; //Crabs term
        const string ROLL_2 = "You rolled Little Joe! {0}, and {1}"; //Crabs term
        const string ROLL_6 = "You rolled Midnight! {0}, and {1}."; //Crabs term
        const string ROLL_REG = "You rolled {0} and {1}.";
        const string PROMPT = "Welcome to the Dice Game!\n\n" +
            "Press Q to return to the Menu or press Enter to Continue.\n";
        const string ESC_CHAR = "q";
        #endregion
        /// <summary>
        /// The default method for console apps
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            MenuSystem();
        }//End method Main()
        #region The Problem is all this stupid psudocode
        /*
        Ask the user if they want to roll the dice (loop 1)
        get the user's responce and validate that it is either 'y' or 'n'
        if it is not y or n, tell the user that it is invalid
        
        if no:
        close
        
        if y:
        generate two random numbers in the range 1-6
        if 6 & 6, "you rolled boxcars"
        if 1 & 1, "you rolled snake-eyes"
        else show values
        read line to pause
        write enter or Q
        on enter loop to start
        on q quit (exit loop 2) do while
        double check for q (return to top loop 1)
        print goodbye message and quit
         */
        #endregion The Problem
        /// <summary>
        /// The Method to play the damn dice game
        /// </summary>
        static void DiceGame()
        {
            //Console.Clear();
            //Console.WriteLine(TEST_MSG);
            //return;
            string _checkInput;
            Console.WriteLine(PROMPT);
            Console.ReadKey();
            do
            {
                _diceGen = new Random();
                int _dice1 = _diceGen.Next(ITEM_1, ITEM_7);
                int _dice2 = _diceGen.Next(ITEM_1, ITEM_7);
                if (_dice1 == ITEM_1 && _dice2 == ITEM_1) //both dice are a 1
                {
                    Console.WriteLine(ROLL_1, _dice1, _dice2);
                }
                else if (_dice1 == ITEM_2 && _dice2 == ITEM_2) //both dice are a 2
                {
                    Console.WriteLine(ROLL_2, _dice1, _dice2);
                }
                else if (_dice1 == ITEM_6 && _dice2 == ITEM_6) //both dice are a 6
                {
                    Console.WriteLine(ROLL_6, _dice1, _dice2);
                }
                else //any other combination of dice.
                {
                    Console.WriteLine(ROLL_REG, _dice1, _dice2);
                }
                _checkInput = Console.ReadLine().ToLower();
            } while (_checkInput != ESC_CHAR);
        }//End method DiceGame()
        /// <summary>
        /// The Method to either choose to play or to quit.
        /// </summary>
        static void MenuSystem()
        {
            int numInput;
            do
            {
                Console.Clear();
                Console.Write(MENU_DISPLAY);
                string input = Console.ReadLine();
                int.TryParse(input, out numInput);
                switch (numInput)
                {
                    case ITEM_1:
                        Console.Clear();
                        DiceGame();
                        break;
                    case ITEM_QUIT:
                        Console.Write(KEY_GOODBYE);
                        Console.ReadKey(true);
                        return;
                    default:
                        Console.WriteLine(MENU_WRONG);
                        Console.ReadKey(true);
                        break;
                }//End switch (numInput)
            } while (true);
        }//End method MenuSystem()
    }//End class Program
}//End namespace Lab_16
