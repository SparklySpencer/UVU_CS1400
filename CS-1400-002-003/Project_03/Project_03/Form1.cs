/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Project: Wagon Wheel Odometer (Project_03)
 * Date: 02/16/2015
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 * 
 * I also declare that the image used for this project, was used
 * as a stock image. The content owner "wintersmagicstock" published
 * their work on DeviantART under "Resources & Stock Images" and 
 * declared in their description "Unrestricted Stock". The following URL
 * is where the image can be located: http://fav.me/d6jrtgl
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

namespace Project_03
{
    public partial class FrmTravelDistance : Form
    {
        /* --- Information Stuffs ---
         * Goal:
         * Design a GUI App that allows the user to enter in a sheel diameter in inches
         * into a textbox. Then display the number of turns reguired for the wheel to
         * travel one mile in a second textbox (no user entry allowed).
         * 
         * Interface:
         * 1 Menu Strip with: About, Instructions Clear, Exit
         * 2 Textboxes: Wheel Diameter (in inches), and Turns per Mile
         * 2 Lables for each text box
         * 1 Picture Box with the image mentioned above
         * 2 Buttons: Clear, Exit
         * 
         * Things I will need:
         * Circumfrance = Pi * Diameter
         * double wagonDia in inches
         * double wagonCir in inches
         * int mile = 63360 inches
         * mile / circumfrance = turns
         * 
         // Psudocode:
         // 1) on enter stroke read data entered, store in _diameter
         // 2) circumfrance = pi * diameter
         // 3) wheelTurns = mile / circumfrance
         // 4) display wheel turns in txtBxTurns
         // 5) On clear, put focus back on txtBxDiameter
        */
        #region Const
        private const int MILE_INCHES = 63360;
        #endregion Const
        /// <summary>
        /// Purpose: the entry point into the program
        /// </summary>
        public FrmTravelDistance()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: To display information about the author.
        /// </summary>
        /// <param name="sender">aboutMnu_Click</param>
        /// <param name="e">EventArgs</param>
        private void AboutMnu_Click(object sender, EventArgs e)
        {
            // when clicked, it will have a popup window that displays the creator's name and class
            // it will close when either a yes or a no is clicked.
            string aboutMsg = "Spencer Carter\nCS1400\nProject 03";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: To exit the program when clicked
        /// </summary>
        /// <param name="sender">exitMnu_Click</param>
        /// <param name="e">not used</param>
        private void ExitMnu_Click(object sender, EventArgs e)
        {
            Close(); // ends the program
        }
        /// <summary>
        /// Purpose: To display how the program works to the user.
        /// Also to display the limitations or restrictions of the program.
        /// </summary>
        /// <param name="sender">instructionsMnu_Click</param>
        /// <param name="e">EventArgs</param>
        private void InstructionsMnu_Click(object sender, EventArgs e)
        {
            // when clicked, it will have a popup window that displays the instructions
            // it will close when either a yes or a no is clicked.
            string aboutMsg = "Instructions:\nPlease enter the diameter of the wheel in inches.\nPlease note, that letters, zero, or negative numbers will not work.\nThen press enter on the keyboard.\nThe number of revolutions for a mile will be displayed below.";
            string headerMsg = "Instructions Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: on key press enter, it will find out how many turns of the wheel it takes to make a mile
        /// </summary>
        /// <param name="sender">txtBdDiameter_KeyPress</param>
        /// <param name="e">not used</param>
        private void TxtBoxDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Variables
            double _circumfrance = 0.0;
            double _diameter = 0.0;
            double _wheelTurns = 0.0;
            #endregion Variables
            if (e.KeyChar==(char)Keys.Enter)
            {
                // 1) on enter stroke read data entered, store in _diameter
                double.TryParse(TxtDiameter.Text, out _diameter);
                if (_diameter <= 0) // some simple error correction
                {
                    MessageBox.Show("That is an invalad entry, try again.");
                    TxtDiameter.Clear();
                    TxtTurns.Clear();
                    TxtDiameter.Focus();
                    return;
                }
                // 2) circumfrance = pi * diameter
                _circumfrance = Math.PI * _diameter;
                // 3) wheelTurns = mile / circumfrance
                _wheelTurns = MILE_INCHES / _circumfrance;
                // 4) display wheel turns in txtBxTurns
                TxtTurns.Text = string.Format("{0:f3}", _wheelTurns);
            }
        }
        /// <summary>
        /// Purpose: to end the program
        /// </summary>
        /// <param name="sender">btnExit_Click</param>
        /// <param name="e">not used</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close(); // ends the program
        }
        /// <summary>
        /// Purpose: to clear the values in both text boxes and return the focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearMnu_Click(object sender, EventArgs e)
        {
            TxtDiameter.Clear();
            TxtTurns.Clear();
            TxtDiameter.Focus();
            return;
        }
        /// <summary>
        /// Purpose: to clear the values in both text boxes and return the focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtDiameter.Clear();
            TxtTurns.Clear();
            TxtDiameter.Focus();
            return;
        }
    } // end FrmTravelDistance : Form
} // end namespace Project_03
