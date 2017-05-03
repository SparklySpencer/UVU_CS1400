using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_09
{
    /// <summary>
    /// The class I built to store all the magical bullshit
    /// </summary>
    class NoMagicThings
    {
        //Stuff for the logic class
        public const int ASIZE_MAX_PLAYERS = 10;
        public const int ASIZE_INPUT = 2;
        public const int BOWL_MAX_SCORE = 300;
        public const int OFF_ONE_PREVENT = -1;
        public const string ARR_FULL = "The array is full, no more players can be added at this time.\n";
        public const string ARR_BAD_SCORE = "{0} is an invalid score\n";
        public const string ARR_TOO_LOW = "Your score {0}, is lower than the lowest possible bowling score\n";
        public const string ARR_TOO_HIGH = "Your score {0}, is higher than the absolute best bowling score\n";
        public const int POINTER_SCORES = 1;
        public const string TAB = "\t";
        public const string NEWLINE = "\n";
        public const string HIGHEST = "High Score:\t";
        public const string LOWEST = "Low Score:\t";
        public const string AVG = "Average Score:\t";
        //Stuff for events
        public const string DIALOG_ABOUT = "About Dialog Box:";
        public const string DIALOG_ABOUT_MSG = "\nAuthor: Spencer Carter\nClass: CS 1400 Section 03\nProject #09 A Better Bowling Team Scores Program\nDate: April, 21, 2015";
        public const string INSTRUCTIONS_MSG = "Enter a player name, then press \"Enter\" to advance to the next textbox.\n" +
                                                "Enter a player score, then press \"Enter\" or click the \"Add Player\" button.\n" +
                                                "There may be prompts for invalid input, please correct them and continue on.\n" +
                                                "To display the current results, press \"Clear\", then click the \"Add Player\" button.\n" +
                                                "To start a new game, click \"Reset\" and enjoy! Cheers!";
        public const string GOOD_JOB = "\nNew Player added sucessfully.";
        public const string RDISPLAY_TITLE = "Name:\t\t\t\tScore:\n";
        public const string RDISPLAY_BODY = "{0}\t\t\t\t{1}\n";
        public const string RDISPLAY_BODY_PSCORE = "{0}\t\t\t\t{1} * Perfect Score!\n";
        public const string RDISPLAY_FOOT = "Average Score: {0:f2}";
    }//End class NoMagicThings
}//End namespace Project_09