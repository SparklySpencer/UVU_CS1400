/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Lab #14 - Shipping Rates
 * Date: 03/25/15
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Psudo Stuff
/* The Problem
 1) Have user select which method of shippment they would like.
 The ship methods are: Standard, Express, or Same Day
 2) Both, RadioButtons and a ComboBox on GUI
 3) When selected, have a message box display with their choice.
 */
#endregion Psudo Stuff

namespace Lab_14
{
    /// <summary>
    /// The default class built when you create a new form application
    /// </summary>
    public partial class Frm_ShippingRates : Form
    {
        //All magic things go here
        #region No Magic Things
        private const string SAME_DAY = "You have selected Same-Day shipping @ $12.50";
        private const string EXPRESS = "You have selected Express shipping @ $10.25";
        private const string STANDARD = "You have selected Standard shipping @ $5.15";
        public const string DIALOG_ABOUT = "About Dialog Box";
        public const string DIALOG_ABOUT_MSG = "Author: Spencer Carter\nClass: CS 1400 Section 03\nLab #14 - Shipping Rates\nDate: March 25, 2015";
        private const int ZERO = 0;
        private const int ONE = 1;
        private const int TWO = 2;
        #endregion No Magic Things
        /// <summary>
        /// The default constructor built when you create a new form
        /// </summary>
        public Frm_ShippingRates()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event Handler that has a message box show when checked.
        /// </summary>
        /// <param name="sender">RadBtn_SameDay_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RadBtn_SameDay_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBtn_SameDay.Checked)
            {
                MessageBox.Show(SAME_DAY);
            }
        }
        /// <summary>
        /// Event Handler that has a message box show when checked.
        /// </summary>
        /// <param name="sender">RadBtn_Express_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RadBtn_Express_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBtn_Express.Checked)
            {
                MessageBox.Show(EXPRESS);
            }
        }
        /// <summary>
        /// Event Handler that has a message box show when checked.
        /// </summary>
        /// <param name="sender">RadBtn_Standard_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RadBtn_Standard_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBtn_Standard.Checked)
            {
                MessageBox.Show(STANDARD);
            }
        }
        /// <summary>
        /// An event for the combo box. Displays message box when ship method is chosen.
        /// </summary>
        /// <param name="sender">ComBx_Rates_SelectedIndexChanged</param>
        /// <param name="e">Not Used</param>
        private void ComBx_Rates_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _selectedItem = ComBx_Rates.SelectedIndex;
            switch (_selectedItem)
            {
                case ZERO:
                    MessageBox.Show(SAME_DAY);
                    break;
                case ONE:
                    MessageBox.Show(EXPRESS);
                    break;
                case TWO:
                    MessageBox.Show(STANDARD);
                    break;
            }
        }
        /// <summary>
        /// An event to close the app
        /// </summary>
        /// <param name="sender">Mnu_Exit_Click</param>
        /// <param name="e">Not Used</param>
        private void Mnu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// An event to display information about the author.
        /// </summary>
        /// <param name="sender">Mnu_About_Click</param>
        /// <param name="e">Not Used</param>
        private void Mnu_About_Click(object sender, EventArgs e)
        {
            string headerMsg = DIALOG_ABOUT;
            string bodyMsg = DIALOG_ABOUT_MSG;
            MessageBox.Show(bodyMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }//End partial class Form1 : Form
}//End namespace Lab_14
