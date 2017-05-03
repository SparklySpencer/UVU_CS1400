/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Project: Captain Jack GUI (Lab_07)
 * Start Date: 02/17/2015
 * Submit Date: 02/18/2015
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 * 
 * I also declare that the image "Pirate Queen Render" used for this project,
 * was used as a stock image. The content owner "Alpine-GFX" published
 * their work on DeviantART under "Resources & Stock Images".
 * The following URL is where the image can be located: http://fav.me/d3kr47t
 * Fair Use: The image above is only to be used for educational, non-
 * commercial purposes. There is to be no redistribution outside the
 * bounds of this assignment. All other purposes will be for example only.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab_07
{
    public partial class FrmCaptinJack : Form
    {
        /* Information Stuffs
         * 
         * Problem:
         * User input gold
         * User input Crew
         * Everyone gets 3 gold
         * Captain gets 12% of total gold
         * First gets 8% of total gold
         * Divy out rest evenly to everyone
         * any remainder goes to PBA
         * Auditor needs to get the same result as user input gold
         * 
         * Interface:
         * 1 Menu Strip: About, Instructions, Story, Clear, Exit
         * 2 Buttons: split gold, exit
         * 7 text boxes: crew members, total goald, capShare, firstShare, crewShare, PBA, Auditor check
         * 7 labels for each text box
         * 1 picture box
         * 
         * Remember:
         * This work with int
         * double percentages need to be const and downcast to be worked with
         * Try working with methods
         * 
         // Psudocode:
         // 1) on button press, read data from crewMembers and totalGold
         // 2) tryParse on both and store them in _crewMembers and _totalGold as int
         // 3) divy out 3 gold to each crew member (3 will be a const)
         //    _partyGold = _crewMembers * 3
         // 4) give pirate captain 12% (will be const double 0.12)
         //    _captainShare = _totalGold * 0.12
         // 5) give first mate 8% (will be const double 0.08)
         //    _firstShare = _totalGold * 0.08
         // 6) subtract the shares before dividing spliting the gold
         //    _totalGold = TotalGold - _partyGo8ld - _captainShare - _firstShare
         // 7) divide the gold evenly between the crew members
         //    _crewShare = _totalGold / _crewMembers +3
         // 8) find PBA remainder by %
         //    _pbaShare = _totalGold % _crewmembers
         // 9) Auditor Check
         //    _auditorCheck = _captainShare + _firstShare + (_crewShare * _crewMembers) + _pbaShare
         // 10) add up all the totals
         //     _captainShare = _captainShare + _crewShare
         //     _firstShare = _firstShare + _crewShare
         //     _crewShare = _crewShare
         // 11) Display the totals in the appropriate textboxes
         */
        #region Const
        private const int FACTOR_PEOPLE = 2; // for too few crew members (Red for too few hands to work)
        private const int FACTOR_PARTY = 3; // for party share
        private const double FACTOR_CAPTAIN = 0.12; // captain share
        private const double FACTOR_FIRST = 0.08; // first mate share
        #endregion Const
        /// <summary>
        /// Purpose: The entry point into the application.
        /// </summary>
        public FrmCaptinJack()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: on load it will put the focus in the crew members textbox.
        /// </summary>
        /// <param name="sender">FrmCaptinJack_Load</param>
        /// <param name="e">not used</param>
        private void FrmCaptinJack_Load(object sender, EventArgs e)
        {
            TxtBxCrewMembers.Select();
        }
        #region Methods
        /// <summary>
        /// Purpose: Clear everything.
        /// </summary>
        private void ClearTxtBxs()
        {
            TxtBxCrewMembers.Clear();
            TxtBxTotalGold.Clear();
            TxtBxJackShare.Clear();
            TxtBxMateShare.Clear();
            TxtBxCrewShare.Clear();
            TxtBxPbaShare.Clear();
            TxtBxAuditorShare.Clear();
            TxtBxCrewMembers.Focus();
        }
        /// <summary>
        /// Purpose: Do all the math calculations.
        /// </summary>
        private void CalcGold()
        {
            #region Var
            string _userMembers = ""; // capture text for error correction
            string _userGold = ""; // capture text for error correction
            int _crewMembers = 0; // user entered crew members
            int _totalGold = 0; // user entered total gold
            int _partyGold = 0; // the amount given to everyone initually
            int _captainShare = 0; // the total the captain will recieve
            int _firstShare = 0; // the total the first mate will recieve
            int _crewShare = 0; // the total each crew member will recieve
            int _pbaShare = 0; // the remainder
            int _auditorCheck = 0; // to check the accounting
            #endregion Var
            // 1) on button press, read data from crewMembers and totalGold
            // 2) tryParse on both and store them in _crewMembers and _totalGold as int
            _userMembers = TxtBxCrewMembers.Text;
            int.TryParse(TxtBxCrewMembers.Text, out _crewMembers);
            if (_crewMembers <= 0) // any character or -# will go here automatically
            {
                MessageBox.Show(string.Format("{0} is an invalad Crew entry, try again.", _userMembers));
                TxtBxCrewMembers.Focus();
                TxtBxCrewMembers.SelectAll();
                return;
            }
            if (_crewMembers <= FACTOR_PEOPLE)
            {
                MessageBox.Show("You do not have enough Crew Members, hire some more so we can be off.");
                TxtBxCrewMembers.Focus();
                TxtBxCrewMembers.SelectAll();
                return;
            }
            _userGold = TxtBxTotalGold.Text;
            int.TryParse(TxtBxTotalGold.Text, out _totalGold);
            if (_totalGold <= 0) // any character or -# will go here automatically
            {
                MessageBox.Show(string.Format("{0} is an invalad Gold entry, try again.", _userGold));
                TxtBxTotalGold.Focus();
                TxtBxTotalGold.SelectAll();
                return;
            }
            else if (_totalGold <= (_crewMembers * FACTOR_PARTY))
            {
                MessageBox.Show("You did not earn enough gold for partying, return when you have more plunder.");
                TxtBxTotalGold.Focus();
                TxtBxTotalGold.SelectAll();
                return;
            }
            // 3) divy out 3 gold to each crew member (3 will be a const)
            _partyGold = _crewMembers * FACTOR_PARTY;
            // 4) give pirate captain 12% (will be const double 0.12)
            _captainShare = (int)(_totalGold * FACTOR_CAPTAIN);
            _totalGold = _totalGold - _captainShare;
            // 5) give first mate 8% (will be const double 0.08)
            _firstShare = (int)(_totalGold * FACTOR_FIRST);
            _totalGold = _totalGold - _firstShare;
            // 6) subtract the shares before dividing spliting the gold
            _totalGold = _totalGold - _partyGold;
            // 7) divide the gold evenly between the crew members
            _crewShare = _totalGold / _crewMembers + FACTOR_PARTY; // adding the 3 gold to simplify the process later
            // 8) find PBA remainder by %
            _pbaShare = _totalGold % _crewMembers;
            if (_pbaShare < 0) // had some instances where the PBA was a negative number, this will prevent that.
            {
                MessageBox.Show("The Pirate Benavolant Association will not loan you money, YOU GIVE US MONEY, return when you have more plunder");
                TxtBxTotalGold.Focus();
                TxtBxTotalGold.SelectAll();
                return;
            }
            // 9) Auditor Check
            _auditorCheck = _captainShare + _firstShare + (_crewShare * _crewMembers) + _pbaShare;
            if (_auditorCheck < _totalGold) // because of all the error correction prior this will never happen
            {
                MessageBox.Show("The Auditor found descrepancies in your accounting, jail time for you.");
                ClearTxtBxs();
                TxtBxCrewMembers.Focus();
                return;
            }
            // 10) add up all the totals
            _captainShare = _captainShare + _crewShare; // because she also gets a share of the loot
            _firstShare = _firstShare + _crewShare; // because he also gets a share of the loot
            _crewMembers = _crewMembers - FACTOR_PEOPLE; // subtract 2 so we can display the right amount of crew members
            // 11) Display the totals in the appropriate textboxes
            TxtBxJackShare.Text = string.Format("{0} Gold", _captainShare);
            TxtBxMateShare.Text = string.Format("{0} Gold", _firstShare);
            TxtBxCrewShare.Text = string.Format("({0} Gold x {1} Crew)", _crewShare, _crewMembers);
            TxtBxPbaShare.Text = string.Format("{0} Gold", _pbaShare);
            TxtBxAuditorShare.Text = string.Format("{0} Gold", _auditorCheck);
            TxtBxCrewMembers.SelectAll();
            TxtBxCrewMembers.Focus();
        }
        #endregion Methods
        /// <summary>
        /// Purpose: to display information aobut the author and assignment
        /// </summary>
        /// <param name="sender">AboutMnu_Click</param>
        /// <param name="e">EventArgs</param>
        private void AboutMnu_Click(object sender, EventArgs e)
        {
            // when clicked, it will have a popup window that displays the creator's name and class
            // it will close when either an okay is clicked.
            string aboutMsg = "Spencer Carter\nCS1400\nLab 07";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: to display instructions to the user
        /// </summary>
        /// <param name="sender">InstructionsMnu_Click</param>
        /// <param name="e">EventArgs</param>
        private void InstructionsMnu_Click(object sender, EventArgs e)
        {
            // when clicked, it will have a popup window that displays the instructions.
            // it will close when either an ok is clicked.
            string aboutMsg = "Instructions:\nEnter the number of Crew Members in the text box -- be sure to include the captain and first mate. Then enter Total Gold in the text box below -- remember that there needs to be enough to party. Either click Split Gold Button or press Enter. The program will calculate the values, and let you know if there are any errors along the way. Either click Clear to start over fresh or click Exit to close the program.";
            string headerMsg = "Instructions Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: To display background information to the user about the program.
        /// </summary>
        /// <param name="sender">StoryMnu_Click</param>
        /// <param name="e">EventArgs</param>
        private void StoryMnu_Click(object sender, EventArgs e)
        {
            // when clicked, it will have a popup window that displays the story behind the program.
            // it will close when either an ok is clicked.
            string aboutMsg = "The Story:\nCaptain Jack and her crew of pirates arrive in Tortuga after several weeks of plundering the high seas. Since the crew has been at sea for nearly a month, they are ready for a night of celebration. Captain Jack doesn't want to divvy up the treasure just yet; however, she does note the total pieces of gold. She gives everyone 3 pieces of gold and sends the crew into town to celebrate. After the crew has gone, she and the first mate decide how to split the gold among themselves and the crew. Captain Jack decides that she'll take 12% of the total gold. She counts out his gold and hides it in her cabin. The Captain agrees to give the first mate 8% of the remaining total gold. The first mate counts out his coins and hides it in his cabin. The next morning, the gold that is left is divided evenly among all the members of the crew. Little does the crew know that Cap'n Jack and the First Mate have already taken a cut! If the remaining treasure can't be split evenly, the coins that are left-over are given to the Pirate's Benevolent Association or PBA.";
            string headerMsg = "Story Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: To clear the text boxes for a new session.
        /// </summary>
        /// <param name="sender">ClearMnu_Click</param>
        /// <param name="e">ClearTxtBxs()</param>
        private void ClearMnu_Click(object sender, EventArgs e)
        {
            ClearTxtBxs();
        }
        /// <summary>
        /// Purpose: to close the program.
        /// </summary>
        /// <param name="sender">ExitMnu_Click</param>
        /// <param name="e">not used</param>
        private void ExitMnu_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Purpose: to close the program.
        /// </summary>
        /// <param name="sender">BtnExit_Click</param>
        /// <param name="e">not used</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Purpose: to move the the cursor to the next text box.
        /// </summary>
        /// <param name="sender">TxtBxCrewMembers_KeyPress</param>
        /// <param name="e">TxtBxTotalGold.Focus</param>
        private void TxtBxCrewMembers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtBxTotalGold.Focus();
                TxtBxTotalGold.SelectAll();
            }
        }
        /// <summary>
        /// Purpose: to call the method that does the math stuffs for the program.
        /// </summary>
        /// <param name="sender">TxtBxTotalGold_KeyPress</param>
        /// <param name="e">CalcGold()</param>
        private void TxtBxTotalGold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CalcGold();
            }
        }
        /// <summary>
        /// Purpose: to call the method that does the math stuffs for the program.
        /// </summary>
        /// <param name="sender">BtnSplitGold_Click</param>
        /// <param name="e">CalcGold()</param>
        private void BtnSplitGold_Click(object sender, EventArgs e)
        {
            CalcGold();
        }
    } // end of FrmCaptainJack : Form
} // end of namespace Lab_07
