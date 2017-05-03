/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
 * Project #5 Shipping Rates
 * Date: 03/31/15
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

namespace Project_05
{
    /// <summary>
    /// Things to pass to the class to figure out what the hell is going on (I think).
    /// </summary>
    enum SHIP_TYPES {STND, EXPR, SAME}
    /// <summary>
    /// Things to pass to the class to figure out what the hell is going on (I think).
    /// </summary>
    enum SHIP_PLACE {USA, AK, HI}
    /// <summary>
    /// Things to pass to the class to figure out what the hell is going on (I think).
    /// </summary>
    enum SHIP_COST {A, B}

    /// <summary>
    /// The default class built for forms
    /// </summary>
    public partial class Frm_ShipRate : Form
    {
        private ShippingLogic sl;

        /// <summary>
        /// A region containing all the class level vars --> No magic strings, chars, ints, double, etc.
        /// </summary>
        #region No Magic Things
        public const string STND_SUR = "+ $2.50";
        public const string STND_CAT_A = "$3.00 per Item";
        public const string STND_CAT_B = "$1.45 per Pound";
        public const string EXPR_SUR = "+ $5.00";
        public const string EXPR_CAT_A = "$4.00 per Item";
        public const string EXPR_CAT_B = "$2.50 per Pound";
        public const string SAME_SUR = "+ $8.00";
        public const string SAME_CAT_A = "$5.50 per Item";
        public const string SAME_CAT_B = "$3.00 per Pound";
        public const string DIALOG_ABOUT = "About Dialog Box";
        public const string DIALOG_ABOUT_MSG = "Author: Spencer Carter\nClass: CS 1400 Section 03\nProject #5 Shipping Rates\nDate: March 31, 2015";
        public const string ERR_ITEMS = "Invalid Entry: the number of items must be a positive INT, which has a value greater than zero";
        public const string ERR_LBS = "Invalid Entry: the weight in pounds must be a positive DOUBLE, which has a value greater than zero";
        public const string PAY_GOOD = "Please pay {0:C}";
        public const string PAY_BAD = "Try Again :(";
        private int _testPerItem = 0;
        private double _testPerPound = 0;
        public const string ITEM_START = "Enter the number of items.";
        public const string POUND_START = "Enter the number of pounds.";
        #endregion No Magic Things

        /// <summary>
        /// The default construcotr for forms
        /// </summary>
        public Frm_ShipRate()
        {
            InitializeComponent();
        }

        ///<summary>
        /// A region containing all the event handlers created for this project
        /// </summary>
        #region Events
        /// <summary>
        /// On load, cleans up display.
        /// </summary>
        /// <param name="sender">Frm_ShipRate_Load</param>
        /// <param name="e">Not Used</param>
        private void Frm_ShipRate_Load(object sender, EventArgs e)
        {
            sl = new ShippingLogic();
            RBtn_Standard.Checked = true;
            Lbl_Alaska.Visible = false;
            Lbl_Hawaii.Visible = false;
            TxtBx_PerItem.Visible = false;
            TxtBx_PerPound.Visible = false;
        }
        /// <summary>
        /// To update the labels to show the accurate pricing information to the user/
        /// </summary>
        /// <param name="sender">RBtn_Standard_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RBtn_Standard_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Alaska.Text = STND_SUR;
            Lbl_Hawaii.Text = STND_SUR;
            Lbl_PerItem.Text = STND_CAT_A;
            Lbl_PerPound.Text = STND_CAT_B;
            sl.SetShipMethod = SHIP_TYPES.STND;
        }
        /// <summary>
        /// To update the labels to show accuracte pricing information to the user.
        /// </summary>
        /// <param name="sender">RBtn_Express_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RBtn_Express_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Alaska.Text = EXPR_SUR;
            Lbl_Hawaii.Text = EXPR_SUR;
            Lbl_PerItem.Text = EXPR_CAT_A;
            Lbl_PerPound.Text = EXPR_CAT_B;
            sl.SetShipMethod = SHIP_TYPES.EXPR;
        }
        /// <summary>
        /// To update the labels to show accurate pricing information to the user.
        /// </summary>
        /// <param name="sender">RBtn_SameDay_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RBtn_SameDay_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Alaska.Text = SAME_SUR;
            Lbl_Hawaii.Text = SAME_SUR;
            Lbl_PerItem.Text = SAME_CAT_A;
            Lbl_PerPound.Text = SAME_CAT_B;
            sl.SetShipMethod = SHIP_TYPES.SAME;
        }
        /// <summary>
        /// To show only accuarte data to the user based on their choice.
        /// </summary>
        /// <param name="sender">RBtn_Continental_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RBtn_Continental_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Alaska.Visible = false;
            Lbl_Hawaii.Visible = false;
            sl.SetSurcharge = SHIP_PLACE.USA;
        }
        /// <summary>
        /// To show only accurate data to the user based on their choice
        /// </summary>
        /// <param name="sender">RBtn_Alaska_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RBtn_Alaska_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Alaska.Visible = true;
            Lbl_Hawaii.Visible = false;
            sl.SetSurcharge = SHIP_PLACE.AK;
        }
        /// <summary>
        /// To show only accurate data to the user based on their choice.
        /// </summary>
        /// <param name="sender">RBtn_Hawaii_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RBtn_Hawaii_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Alaska.Visible = false;
            Lbl_Hawaii.Visible = true;
            sl.SetSurcharge = SHIP_PLACE.HI;
        }
        /// <summary>
        /// To either show or hide the approperiate textboxes for entry to the user.
        /// </summary>
        /// <param name="sender">RBtn_PerItem_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RBtn_PerItem_CheckedChanged(object sender, EventArgs e)
        {
            TxtBx_PerPound.Visible = false;
            Lbl_PerPound.Visible = false;
            TxtBx_PerPound.Clear();
            TxtBx_PerItem.Visible = true;
            Lbl_PerItem.Visible = true;
            TxtBx_PerItem.Text = ITEM_START;
            TxtBx_PerItem.Focus();
            TxtBx_PerItem.SelectAll();
            sl.SetCategory = SHIP_COST.A;
        }
        /// <summary>
        /// To either show or hide the approperiate textboxes for entry to the user.
        /// </summary>
        /// <param name="sender">RBtn_PerPound_CheckedChanged</param>
        /// <param name="e">Not Used</param>
        private void RBtn_PerPound_CheckedChanged(object sender, EventArgs e)
        {
            TxtBx_PerItem.Visible = false;
            Lbl_PerItem.Visible = false;
            TxtBx_PerItem.Clear();
            TxtBx_PerPound.Visible = true;
            Lbl_PerPound.Visible = true;
            TxtBx_PerPound.Text = POUND_START;
            TxtBx_PerPound.Focus();
            TxtBx_PerPound.SelectAll();
            sl.SetCategory = SHIP_COST.B;
        }
        /// <summary>
        /// To display information about the author
        /// </summary>
        /// <param name="sender">Mnu_About_Click</param>
        /// <param name="e">Not Used</param>
        private void Mnu_About_Click(object sender, EventArgs e)
        {
            string headerMsg = DIALOG_ABOUT;
            string bodyMsg = DIALOG_ABOUT_MSG;
            MessageBox.Show(bodyMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// To end the application
        /// </summary>
        /// <param name="sender">Mnu_Exit_Click</param>
        /// <param name="e">Not Used</param>
        private void Mnu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// To display the price the user needs to pay.
        /// </summary>
        /// <param name="sender">Btn_Process_Click</param>
        /// <param name="e">Not Used</param>
        private void Btn_Process_Click(object sender, EventArgs e)
        {
            if (TestForInvalid() == true)
            {
                sl.ConditionalCheckEtype();
                //Call class method or property to get the right information
                //Change this to reflect accurate information provided by the class
                Lbl_PleasePay.Text = string.Format(PAY_GOOD, sl.TotalShippingCost);
            }
            else
            {
                Lbl_PleasePay.Text = PAY_BAD;
                return;
            }
        }
        /// <summary>
        /// On enter in the text box, it calls an event that will process the data, and display the please pay cost.
        /// </summary>
        /// <param name="sender">The enter keystroke</param>
        /// <param name="e">Btn_Process_Click</param>
        private void TxtBx_PerItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_Process_Click(sender, e);
            }
        }
        /// <summary>
        /// On enter in the text box, it calls an event that will process the data, and display the please pay cost.
        /// </summary>
        /// <param name="sender">The enter keystroke</param>
        /// <param name="e">Btn_Process_Click</param>
        private void TxtBx_PerPound_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_Process_Click(sender, e);
            }
        }
        #endregion Events

        /// <summary>
        /// To test for bad input
        /// </summary>
        /// <returns>Upon bad input, it returns false so the process can stop until good data is entered</returns>
        private bool TestForInvalid()
        {
            Err_Provider.Clear();
            //Condition will test bool if it can prase or not, as well as, if the value is too low
            if (RBtn_PerItem.Checked == true)
            {
                if (!(int.TryParse(TxtBx_PerItem.Text, out _testPerItem)) || _testPerItem <= 0)
                {
                    Err_Provider.SetError(TxtBx_PerItem, ERR_ITEMS);
                    TxtBx_PerItem.Focus();
                    TxtBx_PerItem.SelectAll();
                    return false;
                }
                else
                {
                    sl.NumItems = _testPerItem;
                    return true;
                }
            }
            //Condition will test bool if it can prase or not, as well as, if the value is too low
            else if (RBtn_PerPound.Checked == true)
            {
                if (!(double.TryParse(TxtBx_PerPound.Text, out _testPerPound)) || _testPerPound <= 0)
                {
                    Err_Provider.SetError(TxtBx_PerPound, ERR_LBS);
                    TxtBx_PerPound.Focus();
                    TxtBx_PerPound.SelectAll();
                    return false;
                }
                else
                {
                    sl.NumPounds = _testPerPound;
                    return true;
                }
            }
            //If everything checks out, it will return true and allow the code to show the message box salesInvoice
            else
            {
                return true;
            }
        }


    }//End class Frm_ShipRate()
}//End namespace Project_05
