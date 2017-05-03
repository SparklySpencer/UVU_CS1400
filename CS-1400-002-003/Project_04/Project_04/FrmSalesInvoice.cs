/* Project Prolog
 * Name: Spencer Carter
 * CS 1400 Section 3
 * Project 04 - Sales Invoice Windows Form Application
 * Date: 
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 *
 * Bob helped with error correction.
 * 
 * Image Declaration:
 * "Signature" by "Theos-Kengen" submitted to DeviantArt on October 22, 2013 @ Link: http://fav.me/d6rfjzy
 * Fair Use: The image above (with permission from the content owner)
 * is only to be used for educational, non-commercial purposes. There
 * is to be no redistribution outside the bounds of this assignment.
 * All other purposes will be for example only.
 */
/*Information Stuffs:
 * Program Requirments:
 * 1) the user will enter in the number of items sold and a unit price
 * _quantity will be an int, and _unitPrice will be double
 * 2) store the values entered by the user in your SalesInvoice class
 * 3) using properties and methods of your SalesInvoice class, calculate the netSales value
 * , the amount of stateTax and localTax due, and the grossSales value
 * _saleNet double, taxState double, taxLocal double, saleGross double
 * 4) display an invoice for the user. Must use a MessageBox to show the invoice.
 * 5) also must include a clear button
 * 
 * Interface:
 * 3 text boxes (name of item, quantity of that item, and price of that item)
 * 3 labels to describe the text boxes
 * 1 menu strip (about, check chart, clear, exit)
 * 1 picture box for a logo maybe
 * 4 buttons (add item, purchase, clear, exit)
 * (on purchase) one message box with an ok button.
 * 
 * Mesage Box Specifics:
 * Sales Ticket #
 * Name of item, quantiry of item, price of item (as many times as needed)
 * Net price
 * Horizontal line
 * local tax
 * state tax
 * Please Pay
 * ok
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
namespace Project_04
{
    /// <summary>
    /// Purpose: the default class for the form.
    /// </summary>
    public partial class FrmSalesInvoice : Form
    {
        /// <summary>
        /// Purpose: a class level reference to the SalesInvoice class, which will provide the business logic.
        /// </summary>
        private SalesInvoice si;

        /// <summary>
        /// Purpose: a region that holds all the class level variables, which prevent magic things in my assignment.
        /// </summary>
        #region No Magic Things
        public const string DIALOG_ABOUT = "About Dialog Box";
        public const string DIALOG_ABOUT_MSG = "Author: Spencer Carter\nClass: CS 1400 Section 03\nProject 04 - Sales Invoice Windows Form Application\nDate: March 16, 2015";
        public const string SALES_TOTALS = "Sales Invoice";
        public const string SALES_TOTALS_MSG = "\nSales Ticket: {0}\n" +
                                                "Description: {1}\n" +
                                                "Quantity: {2}\n" +
                                                "Unit Price: {3:C}\n" +
                                                "---------------\n" +
                                                "Net Price: {4:C}\n" +
                                                "State Tax: {5:C}\n" +
                                                "Sales Tax: {6:C}\n" +
                                                "Please Pay: {7:C}";
        public const string PLACE_FORMAT_D = "{0:D}";
        public const string PLACE_FORMAT_C = "{0:C}";
        public const string INV_QNTY = "Invalid Entry: The quantity must be a positive, integer, which has a value greater than zero.";
        public const string INV_PRC = "Invalid Entry: The price must be a positive, double, which has a value greater than zero -- lastly, do not inclue the $ symbol.";
        public const int SALES_TICKET = 7736237;
        #endregion No Magic Things

        /// <summary>
        /// Purpose: Entry point into the Form
        /// </summary>
        public FrmSalesInvoice()
        {
            InitializeComponent();
        }//End FrmSalesInvoice()

        /// <summary>
        /// Purpose: a region that holds all the events that are called from the GUI
        /// </summary>
        #region Events
        /// <summary>
        /// Purpose: An event that creates a SalesInvoice object called "si" to be used in this app.
        /// </summary>
        private void FrmSalesInvoice_Load(object sender, EventArgs e)
        {
            si = new SalesInvoice();
            UpdateDisplay();
        }//End FrmSalesInvoice_Load()
        /// <summary>
        /// Purpose: to display information about the author.
        /// </summary>
        /// <param name="sender">MnuAbout_Click</param>
        /// <param name="e">Not Used</param>
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            string headerMsg = DIALOG_ABOUT;
            string bodyMsg = DIALOG_ABOUT_MSG;
            MessageBox.Show(bodyMsg, headerMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//End MnuAbout_Click()
        /// <summary>
        /// Purpose: an event that empties the textboxes, resets the variables to their default value, and reestablishes the focus.
        /// </summary>
        /// <param name="sender">MnuReset_Click</param>
        /// <param name="e">Not Used</param>
        private void MnuReset_Click(object sender, EventArgs e)
        {
            ResetUpdate();
        }//End MnuReset_Click()
        /// <summary>
        /// Purpose: an event that empties the textboxes, resets the variables to their default value, and reestablishes the focus.
        /// </summary>
        /// <param name="sender">Btn_Reset_Click</param>
        /// <param name="e">Not Used</param>
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            ResetUpdate();
        }//End BTN_Reset_Click()
        /// <summary>
        /// Purpose to close the application.
        /// </summary>
        /// <param name="sender">MnuExit_Click(</param>
        /// <param name="e">Not Used</param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//End MnuExit_Click
        /// <summary>
        /// Purpose: to close the application
        /// </summary>
        /// <param name="sender">Btn_Exit_Click</param>
        /// <param name="e">Not Used</param>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//End Btn_Exit_Click()
        /// <summary>
        /// Purpose: to advance the cursor to the next textbox on the enter key stroke.
        /// </summary>
        /// <param name="sender">TxtBx_ItemDescription_KeyPress</param>
        /// <param name="e">Not Used</param>
        private void TxtBx_ItemDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtBx_Quantity.Focus();
                TxtBx_Quantity.SelectAll();
            }
        }//End TxtBx_ItemDescription_KeyPress()
        /// <summary>
        /// Purpose: to advance the cursor to the next textbox on the enter key stroke.
        /// </summary>
        /// <param name="sender">TxtBx_Quantity_KeyPress</param>
        /// <param name="e">Not Used</param>
        private void TxtBx_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtBx_UnitPrice.Focus();
                TxtBx_UnitPrice.SelectAll();
            }
        }//End TxtBx_Quantity_KeyPress()        
        /// <summary>
        /// Purpose: on enter key stroke, it will call the method that will do all the business logic with the data.
        /// </summary>
        /// <param name="sender">TxtBx_UnitPrice_KeyPress</param>
        /// <param name="e">Not USed</param>
        private void TxtBx_UnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuyItNow();
            }
        }//End TxtBx_UnitPrice_KeyPress()
        /// <summary>
        /// Purpose: on click, it will call the method that will do all the business logic with the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            BuyItNow();
        }//End Btn_Buy_Click()
        #endregion Events

        /// <summary>
        /// Purpose: a region that holds all the methods that are replicated in the events.
        /// </summary>
        #region Methods
        /// <summary>
        /// Purpose: to design elegant and efficient code, I am using this method to reset the vars to their default and updating the display.
        /// </summary>
        private void ResetUpdate()
        {
            si.Reset();
            UpdateDisplay();
            ErrProvider.Clear();
        }//End ResetUpdate()
        /// <summary>
        /// Purpose a method that resets what is displaying in the text boxes
        /// </summary>
        private void UpdateDisplay()
        {
            TxtBx_ItemDescription.Text = si.Description;
            TxtBx_Quantity.Text = string.Format(PLACE_FORMAT_D, si.SQuantity);
            TxtBx_UnitPrice.Text = string.Format(PLACE_FORMAT_C, si.SPrice);
            TxtBx_ItemDescription.Focus();
            TxtBx_ItemDescription.SelectAll();
        }//End UpdateDisplay()
        /// <summary>
        /// Purpose: to make the magical Sales Invoice appear in a message box.
        /// </summary>
        private void BuyItNow()
        {
            //A test to see if the values in update object passed my error correction, before showing the message box
            if (UpdateObject() == true)
            {
                string msgHead = SALES_TOTALS;
                string msgBody = string.Format(SALES_TOTALS_MSG, SALES_TICKET, si.Description, si.SQuantity, si.SPrice, si.CalcNetCost, si.CalcStateTax, si.CalcLocalTax, si.CalcTotalCost);
                MessageBox.Show(msgBody, msgHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDisplay();
            }
            else
            {
                return;
            }
        }//End ButItNow()
        /// <summary>
        /// Purpose: have the textboxes intereact with the Class.
        /// </summary>
        private bool UpdateObject()
        {
            ///<summary>
            /// A region for local variables
            /// </summary>
            #region Local Var
            int _intTestValue = 0;
            double _doubleTestValue = 0.0;
            #endregion Local Var
            ErrProvider.Clear();
            si.Description = TxtBx_ItemDescription.Text;
            si.SQuantity = TxtBx_Quantity.Text;
            //Condition will test bool if it can prase or not, as well as, if the value is too low
            if (!(int.TryParse(si.SQuantity, out _intTestValue)) || _intTestValue <= 0)
            {
                ErrProvider.SetError(TxtBx_Quantity, INV_QNTY);
                TxtBx_Quantity.Focus();
                TxtBx_Quantity.SelectAll();
                return false;
            }
            //Condition will test bool if it can prase or not, as well as, if the value is too low
            si.SPrice = TxtBx_UnitPrice.Text;
            if (!(double.TryParse(si.SPrice, out _doubleTestValue)) || _doubleTestValue <= 0)
            {
                ErrProvider.SetError(TxtBx_UnitPrice, INV_PRC);
                TxtBx_UnitPrice.Focus();
                TxtBx_UnitPrice.SelectAll();
                return false;
            }
            //If everything checks out, it will return true and allow the code to show the message box salesInvoice
            else
            {
                return true;
            }
        }//End UpdateObject()
        #endregion Methods
    }//End public partial class FrmSlaesInvoide : Form
}//End namespace Project_04
