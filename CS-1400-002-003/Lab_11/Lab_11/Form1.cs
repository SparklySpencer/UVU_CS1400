/* Project Prolog
 * Name: Spencer Carter
 * CS 1400 Section 3
 * Lab #11 Implementing the Token Machine Class
 * Date: 03/12/15
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab, and/or provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 * 
 * Bob is amazing, so is Taylor
 */
/* PsudoCode:
 * Interface:
 * 1 Menu Strip (About, Instructions Reset, Exit)
 * 4 Labels (bills, quarters, tokens out, change(if any), tokens left, money in machine)
 * 4 text boxes (same)
 * 3 buttons (get tokens, reset, exit)
 * 
 * Make a class that does the buisness logic and have the event handlers dispalay information to the user
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

namespace Lab_11
{
    public partial class Frm_TokenGiver : Form
    {
        //A class level reference to a token machine
        private TokenMachine tm;

        /// <summary>
        /// Purpose: Entry point into the Form
        /// </summary>
        public Frm_TokenGiver()
        {
            InitializeComponent();
        }
        #region Events
        /// <summary>
        /// Purpose: to create a new TokenMachine object and call its reset method
        /// and display the number of quarters and tokens in the textboxes
        /// </summary>
        /// <param name="sender">Frm_TokenGiver_Load</param>
        /// <param name="e">Not Used</param>
        private void Frm_TokenGiver_Load(object sender, EventArgs e)
        {
            //Create a token machine object
            tm = new TokenMachine();
            Reuse_Reset();
        }
        /// <summary>
        /// Purpose: to end the app
        /// </summary>
        /// <param name="sender">MnuExit_Click</param>
        /// <param name="e">Not used</param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Purpose: to end the app
        /// </summary>
        /// <param name="sender">Btn_Exit_Click</param>
        /// <param name="e">Not Used</param>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Purpose: call the Reset method in your token machine class and update
        /// the TextBoxes to show the current values.
        /// </summary>
        /// <param name="sender">MnuReset_Click</param>
        /// <param name="e">Not Used</param>
        private void MnuReset_Click(object sender, EventArgs e)
        {
            Reuse_Reset();
        }
        /// <summary>
        /// Purpose: call the Reset method in your token machine class and update
        /// the TextBoxes to show the current values.
        /// </summary>
        /// <param name="sender">Btn_Reset_Click_1</param>
        /// <param name="e">Not Used</param>
        private void Btn_Reset_Click_1(object sender, EventArgs e)
        {
            Reuse_Reset();
        }
        /// <summary>
        /// Purpose: This calls get token, which will do the math for the token machine, then it updates the display with the correct values.
        /// </summary>
        /// <param name="sender">Btn_GetTokens_Click</param>
        /// <param name="e">Not Used</param>
        private void Btn_GetTokens_Click(object sender, EventArgs e)
        {
            tm.GetToken();
            UpdateDisplay();
        }
        /// <summary>
        /// Purpose: to display instructions to the user
        /// </summary>
        /// <param name="sender">MnuInstructions_Click</param>
        /// <param name="e">Not Used</param>
        private void MnuInstructions_Click(object sender, EventArgs e)
        {
            string aboutMsg = "Instructions:\nFor now, just keep clicking get tokens, enjoy!";
            string headerMsg = "Instructions Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Purpose: to display information about the author
        /// </summary>
        /// <param name="sender">MnuAbout_Click</param>
        /// <param name="e">Not used</param>
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            string aboutMsg = "Author: Spencer Carter\nClass: CS1400 Section 03\nProject: Lab #11 Implementing the Token Machine Class\nDate: March 12, 2015";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion Events
        #region Methods
        /// <summary>
        /// Purpose: empty all the text boxes and reset the values.
        /// </summary>
        private void Reuse_Reset()
        {
            tm.Reset();
            UpdateDisplay();
        }
        /// <summary>
        /// Purpose: to update the display
        /// </summary>
        private void UpdateDisplay()
        {
            TxtBx_Remainder.Text = string.Format("{0}", tm.NumTokens);
            TxtBx_Dispense.Text = string.Format("{0}", tm.NumQuarters);
            TxtBx_MoneyStored.Text = string.Format("{0:c}", tm.ValMoney);
        }
        #endregion Methods
    }//End Form
}//End namespace
