/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Lab #13 - Boolean Expressions
 * Date: 03/30/15
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    /// <summary>
    /// The default class built for Console applications.
    /// </summary>
    class Program
    {
        #region No Magic Things!
        const string KEY_BLANK = "";
        const string SUN = "sun";
        const string MON = "mon";
        const string TUE = "tue";
        const string WED = "wed";
        const string THU = "thu";
        const string FRI = "fri";
        const string SAT = "sat";
        const string CHOOSE_DAY = "Please enter a day of the week, e.g. tue: ";
        const string DAY_WORK = "You have to go to work today... ";
        const string DAY_PLAY = "Ahh... the weekend. No work!";
        const string CHOOSE_TEMP = "\nWhat temperature in Farenheit is it? ";
        const string TEMP_COLD = "Go to work, and dress warmly -- also consider grabbing a coffee or something.";
        const string TEMP_WARM = "Go to work -- also consider grabbing a newspaper or something";
        const string KEY_GOODBYE = "\nGoodbye\n";
        const string MENU_DISPLAY = "Select which expression you would like:\n" +
                                    "\t1) DeMorgan's Law\n" +
                                    "\t2) If-Else Construct\n" +
                                    "\t3) Switch Construct\n" +
                                    "\t4) Conditional Construct\n" +
                                    "\t9) Quit\n" +
                                    "\t\tEnter selection:  ";
        const string MENU_WRONG = "Invalid menu selection!";
        const string INVALID_DATA = "You have entered invalid data, please try again.";
        const string INVALID_TEMP = "{0} is an invalid temperature, try again :(";
        const int ITEM_0 = 0;
        const int ITEM_1 = 1;
        const int ITEM_2 = 2;
        const int ITEM_3 = 3;
        const int ITEM_4 = 4;
        const int ITEM_5 = 5;
        const int ITEM_QUIT = 9;
        const double FREEZE_TEMP = 32.00;
        private static string _today;
        #endregion No Magic Things!

        /// <summary>
        /// The default method built Console applications.
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            P5_MenuSystem();
        }

        #region Assignment Parts
        /// <summary>
        /// Use DeMorgan's Law to change the Boolean expression so that it uses an AND condition instead of an OR condition.
        /// </summary>
        private static void P1_DeMorganAND()
        {
            StartNewDay();
            if (_today != SAT && _today != SUN)
            {
                Console.WriteLine(DAY_WORK);
                Console.ReadKey(true);
            }
            else
            {
                QuickPlayFill();
            }
        }
        /// <summary>
        /// Add the following to the code:
        /// 1) If it is neither Saturday nor Sunday, and it is above freezing, print the message "go to work".
        /// 2) If it is neither Saturday nor Sunday, but it is not above freezing, print the message "go to work and dress warmly".
        /// 3) If it is a Saturday or a Sunday, no matter what the temperature is, print the message "yeah! No work today!".
        /// HINT: arrange your program so that it does not ask for the temperature if you enter Saturday or Sunday.
        /// </summary>
        private static void P2_AddTempCondition()
        {
            StartNewDay();
            if (_today != SAT && _today != SUN)
            {
                QuickWorkFill();
            }
            else
            {
                QuickPlayFill();
            }
        }
        /// <summary>
        /// Now modify you program to use a switch instead of the if-else construct you used above.
        /// </summary>
        private static void P3_Switch()
        {
            StartNewDay();
            switch (_today)
            {
                case MON:
                case TUE:
                case WED:
                case THU:
                case FRI:
                    QuickWorkFill();
                    break;
                case SAT:
                case SUN:
                    QuickPlayFill();
                    break;
            }
        }
        /// <summary>
        /// Now modify your program to use the conditional operator (?:) instead of the switch construct.
        /// </summary>
        private static void P4_ConditionalOperator()
        {
            //method with loop and checks for bad data
            StartNewDay();
            //either shows day off or goes straight to weather.
            string test = ((_today == SAT) || (_today == SUN) ? QuickPlayFill() : QuickWorkFill());
        }
        /// <summary>
        /// Use a menu to allow the user to decide which type of decision expression they would like to test
        /// </summary>
        private static void P5_MenuSystem()
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
                        P1_DeMorganAND();
                        break;
                    case ITEM_2:
                        Console.Clear();
                        P2_AddTempCondition();
                        break;
                    case ITEM_3:
                        Console.Clear();
                        P3_Switch();
                        break;
                    case ITEM_4:
                        Console.Clear();
                        P4_ConditionalOperator();
                        break;
                    case ITEM_QUIT:
                        Console.Write(KEY_GOODBYE);
                        Console.ReadKey(true);
                        return;
                    default:
                        Console.WriteLine(MENU_WRONG);
                        Console.ReadKey(true);
                        break;
                }
            } while (true);
        }
        #endregion Assignment Parts

        #region Methods for Elegant Code
        /// <summary>
        /// For elegant and efficiant code, I made a quick method to fill the switch.
        /// </summary>
        private static string QuickWorkFill()
        {
            Console.Write(DAY_WORK);
            Console.ReadKey(true);
            Console.WriteLine(CheckTemp());
            Console.ReadKey(true);
            return KEY_BLANK;
        }
        /// <summary>
        /// For elegant and efficiant code, I decided that this was nesicarry, especiall after the previous.
        /// </summary>
        private static string QuickPlayFill()
        {
            Console.WriteLine(DAY_PLAY);
            Console.ReadKey(true);
            return KEY_BLANK;
        }
        /// <summary>
        /// This is a small method to simplify the temperature checking, and provide error correction.
        /// </summary>
        /// <returns>A string that either tells the user to dress warm or get a newspaper</returns>
        private static string CheckTemp()
        {
            bool tempTest;
            double tempTemp;
            string tempString;
            do
            {
                Console.Write(CHOOSE_TEMP);
                if (double.TryParse(tempString = Console.ReadLine(), out tempTemp) == false)
                {
                    Console.WriteLine(INVALID_TEMP, tempString);
                    Console.ReadKey(true);
                    tempTest = false;
                }
                else
                {
                    tempTest = true;
                }
            } while (tempTest == false);
            return (tempTemp <= FREEZE_TEMP) ? TEMP_COLD : TEMP_WARM;
        }
        /// <summary>
        /// A method thought out by Professor F. and implemented by myself.
        /// This method takes a string can converts it to lower and keeps only the first 3 chars
        /// Also checks against the days of the week I have set up.
        /// </summary>
        /// <param name="day"></param>
        private static bool ErrorCheckInput(string day)
        {
            string test = null;
            _today = day.ToLower();
            test = ((_today.Length >= ITEM_3) ? _today : KEY_BLANK);

            if (_today == KEY_BLANK)
            {
                Console.WriteLine(INVALID_DATA);
                return false;
            }
            _today = ("" + _today[ITEM_0] + _today[ITEM_1] + _today[ITEM_2]);
            if (!(_today == SUN || _today == MON || _today == TUE || _today == WED || _today == THU || _today == FRI || _today == SAT))
            {
                Console.WriteLine(INVALID_DATA);
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Setting up a loop to test for bad data, and calling it in places.
        /// </summary>
        private static void StartNewDay()
        {
            do
            {
                // prompt the user to enter a day and get the input
                Console.Write(CHOOSE_DAY);
                _today = Console.ReadLine();
                //error check input
                ErrorCheckInput(_today);
            } while (ErrorCheckInput(_today) == false);
        }
        #endregion  Methods for ...
    }//End class Program
}//End namespace
