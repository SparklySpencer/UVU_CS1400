/* Project Prologue
Name: Spencer Carter
Class: CS 1400 Section 003
Project 08 Bowling Team Scores
Date: 04/20/15

I declare that the following code was written by me, provided
by the instrustor, assisted via the lovely people in the drop
in lab, or provided in the textbook for this project. I also
understand that copying source code from any other sourece 
constitutes cheating, and that I will recieve a zero on this
project if I am found in violation of this policy.

The image used in the background of the form is a stock image
"Pins" by "PixelSurface" (c)2011-2015
http://fav.me/d3e6dzu
Fair Use: This image is intended for educational purposes.
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

namespace Project_09
{
    /// <summary>
    /// The default class built for form apps
    /// </summary>
    public partial class FrmBowing : Form
    {
        BowlingLogic bl;
        /// <summary>
        /// The default constructor for form apps
        /// </summary>
        public FrmBowing()
        {
            InitializeComponent();
        }//End FrmBowling()
        /// <summary>
        /// An Event to creat the class object
        /// </summary>
        /// <param name="sender">FrmBowing_Load</param>
        /// <param name="e">Not Used</param>
        private void FrmBowing_Load(object sender, EventArgs e)
        {
            bl = new BowlingLogic();
        }//End FrmLoad()
        /// <summary>
        /// An event used to display information about the author in the RichTextBox
        /// </summary>
        /// <param name="sender">MnuAbout_Clic</param>
        /// <param name="e">Not Used</param>
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            RTxtDisplay.Clear();
            RTxtDisplay.AppendText(NoMagicThings.DIALOG_ABOUT);
            RTxtDisplay.AppendText(NoMagicThings.DIALOG_ABOUT_MSG);
        }//End MnuAbout()
        /// <summary>
        /// An event used to dispay instruction about the program to the user via the RichTextBox
        /// </summary>
        /// <param name="sender">MnuInstructions_Click</param>
        /// <param name="e">Not Used</param>
        private void MnuInstructions_Click(object sender, EventArgs e)
        {
            RTxtDisplay.Clear();
            RTxtDisplay.AppendText(NoMagicThings.INSTRUCTIONS_MSG);
        }//End MnuInstructions()
         /// <summary>
         /// An event to overwrite the existing class and create a brand new object
         /// </summary>
         /// <param name="sender">MnuReset_Click</param>
         /// <param name="e">Calls load then clear events.</param>
        private void MnuReset_Click(object sender, EventArgs e)
        {
            FrmBowing_Load(sender, e); //Ask what to do, and let Danielle know what is what.
            MnuClear_Click(sender, e);
        }
        /// <summary>
        /// An event to clear the display window and the textboxes, also sets the focus in the name textbox.
        /// </summary>
        /// <param name="sender">MnuClear_Click</param>
        /// <param name="e">Not Used</param>
        private void MnuClear_Click(object sender, EventArgs e)
        {
            RTxtDisplay.Clear();
            TxtName.Clear();
            TxtScore.Clear();
            TxtName.Focus();
        }//End MnuClear()
        /// <summary>
        /// An event to close the program.
        /// </summary>
        /// <param name="sender">MnuExit_Click</param>
        /// <param name="e">Not Used</param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//End MenuExit()
        /// <summary>
        /// Event to grab stuff from textboxes and ending on an empty string.
        /// </summary>
        public bool GetInput()
        {
            bl.GrabName = TxtName.Text;
            bl.GrabScore = TxtScore.Text;
            bl.Grab4Split = TxtName.Text + "," + TxtScore.Text;
            if (bl.GrabName == "")
            {
                return false;
            }
            else
            {
                try
                {
                    RTxtDisplay.Clear();
                    bl.AddNewPlayer();
                    bl.DisplayResults();
                    //RTxtDisplay.SelectionAlignment = HorizontalAlignment.Center;
                    RTxtDisplay.AppendText(bl.DisplayResults());
                    bl.SplitIsStupidInGui(); // THIS IS ONLY TO MEET SPEC, AND IS A HUGE WASTE OF TIME.
                }
                catch (IndexOutOfRangeException a)
                {
                    RTxtDisplay.Clear();
                    RTxtDisplay.AppendText(a.Message);
                    return false;
                }
                catch (Exception b)
                {
                    RTxtDisplay.Clear();
                    RTxtDisplay.AppendText(b.Message);
                }
            }
            return true;
        }//End GetInput()
        /// <summary>
        /// An Event to fill the array, and on full or empty string, display the results.
        /// </summary>
        /// <param name="sender">BtnAdd_Clic</param>
        /// <param name="e">Not Used</param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (GetInput() == false)
            {
                RTxtDisplay.AppendText(bl.DisplayResults());
            }
            TxtName.Focus();
            TxtName.SelectAll();
        }//End BtnAdd()
        /// <summary>
        /// An event to advance to the next textbox
        /// </summary>
        /// <param name="sender">TxtName_KeyPress</param>
        /// <param name="e">Not Used</param>
        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtScore.Focus();
                TxtScore.SelectAll();
            }
        }//End TxtName()
        /// <summary>
        /// An event to add a new player on an enter keystroke
        /// </summary>
        /// <param name="sender">TxtScore_KeyPress</param>
        /// <param name="e">BtnAdd_Click</param>
        private void TxtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnAdd_Click(sender, e);
            }
        }//End TxtScore()
    }//End class Form
}//End namespace Project 09