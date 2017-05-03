using System;


namespace Lab_20
{
    class NoMagicThings
    {
        enum ECOINS { HALVES = 50, QUARTERS = 25, DIMES = 10, NICKELS = 5, PENNIES = 1 }
        public const int MAX = 99;
        public const string MSG_HEADER = "I will make change for you.";
        public const string MSG_ENTER = "Enter in an amount between 1 and 99: ";
        public const string MSG_GBYE = "Goodbye ... ";
        public const string MSG_INVALID = "Invalid int value for money!";
        public const string MSG_MNY = "For your money {0} cents you get:";
        public const string MSG_COIN = "{0} ";
        public const string TOO_BIG = "The value you entered is too big, please enter a value between 0 and 99.";
        public const string TOO_SMALL = "The value you entered is too small, please enter a value between 0 and 99.";
        public static string[] SCOINS = { "Halves", "Quarters", "Dimes", "Nickels", "Pennies" };
        public static int[] COINS = { (int)ECOINS.HALVES, (int)ECOINS.QUARTERS, (int)ECOINS.DIMES, (int)ECOINS.NICKELS, (int)ECOINS.PENNIES };
    }
}
