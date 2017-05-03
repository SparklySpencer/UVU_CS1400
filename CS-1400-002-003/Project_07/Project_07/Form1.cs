/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Project #7 Dice Game GUI
 * Date: 04/11/15
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
using System;
using System.Windows.Forms;

namespace Project_07
{
    /// <summary>
    /// The default class built for forms
    /// </summary>
    public partial class FrmDiceGameGUI : Form
    {
        DiceLogic dl;

        /// <summary>
        /// The default method built for forms
        /// </summary>
        public FrmDiceGameGUI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event to set up certain GUI elements for the first use.
        /// </summary>
        /// <param name="sender">FrmDiceGameGUI_Load</param>
        /// <param name="e">Not Used</param>
        private void FrmDiceGameGUI_Load(object sender, EventArgs e)
        {
            Lbl_DisplayResults.Text = null;
            Lbl_OneDice.Text = null;
            Lbl_TwoDice.Text = null;
        }//End Load
        /// <summary>
        /// Event to display information about the author
        /// </summary>
        /// <param name="sender">Mnu_About_Click</param>
        /// <param name="e">Not Used</param>
        private void Mnu_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NoMagicThings.DIALOG_ABOUT_MSG, NoMagicThings.DIALOG_ABOUT, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//End About
        /// <summary>
        /// Event to close the form app
        /// </summary>
        /// <param name="sender">Mnu_Exit_Click</param>
        /// <param name="e">Not Used</param>
        private void Mnu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//End Exit
        /// <summary>
        /// Event that calls class to do some logical magic and display the approperitate data.
        /// </summary>
        /// <param name="sender">Btn_RollDice_Click</param>
        /// <param name="e">Not Used</param>
        private void Btn_RollDice_Click(object sender, EventArgs e)
        {
            dl = new DiceLogic();
            Lbl_OneDice.Text = dl.UpdateDie1;
            Lbl_TwoDice.Text = dl.UpdateDie2;
            Lbl_DisplayResults.Text = dl.UpdateMSG;
        }//End Button
    }//End class Form
}//End namespace Project_07
