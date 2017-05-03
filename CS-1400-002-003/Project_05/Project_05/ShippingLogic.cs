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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_05
{
    class ShippingLogic
    {
        #region Fields
        public const double PRICE_ST_SUR = 2.50;
        public const double PRICE_ST_A = 3.00;
        public const double PRICE_ST_B = 1.45;
        public const double PRICE_EX_SUR = 5.00;
        public const double PRICE_EX_A = 4.00;
        public const double PRICE_EX_B = PRICE_EX_SUR;
        public const double PRICE_SA_SUR = 8.00;
        public const double PRICE_SA_A = 5.50;
        public const double PRICE_SA_B = PRICE_ST_A;
        private double _where;
        private double _packageCost;
        #endregion Fields

        #region Properties
        /// <summary>
        /// I am hoping that this property will store the enum type so I can use it in a method.
        /// </summary>
        public SHIP_TYPES SetShipMethod { get; set; }
        /// <summary>
        /// I am hoping that this property will store the enum type so I can use it in a method.
        /// </summary>
        public SHIP_PLACE SetSurcharge { get; set; }
        /// <summary>
        /// I am hoping that this property will store the enum type so I can use it in a method.
        /// </summary>
        public SHIP_COST SetCategory { get; set; }
        /// <summary>
        /// It will get the int value of the num of items to be shipped to help calculate the cost.
        /// </summary>
        public int NumItems { get; set; }
        /// <summary>
        /// It will get the double value of the num of pounds to be shipped to help calculate the cost.
        /// </summary>
        public double NumPounds { get; set; }
        #endregion Properties

        //Expressions can be represented as get properties
        #region Expressions
        /// <summary>
        /// This will store the value of the money and make it accessible to the GUI.
        /// </summary>
        public double TotalShippingCost
        {
            get
            {
                return (_where + _packageCost);
            }
        }
        #endregion Expressions

        #region Methods
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ShippingLogic()
        {
            //initialize vars
            _where = 0.0;
            _packageCost = 0.0;
        }
        /// <summary>
        /// This will use conditionals to test the state of the checkboxes, and briefly set up some vars to return to the user in a get property later.
        /// </summary>
        public void ConditionalCheckEtype()
        {
            //Test for delivery speed
            if (SetShipMethod == SHIP_TYPES.SAME)
            {
                //Test for surcharge
                if (SetSurcharge == SHIP_PLACE.AK || SetSurcharge == SHIP_PLACE.HI)
                {
                    _where = PRICE_SA_SUR;
                }
                else //(where == SHIP_PLACE.USA)
                {
                    _where = 0.0;
                }
                //Test for category
                if (SetCategory == SHIP_COST.A)
                {
                    _packageCost = (double)NumItems * PRICE_SA_A;
                }
                else //(SetCategory == SHIP_COST.B)
                {
                    _packageCost = NumPounds * PRICE_SA_B;
                }
            }
            //Test for delivery speed
            else if (SetShipMethod == SHIP_TYPES.EXPR)
            {
                //Test for surcharge
                if (SetSurcharge == SHIP_PLACE.AK || SetSurcharge == SHIP_PLACE.HI)
                {
                    _where = PRICE_EX_SUR;
                }
                else //(where == SHIP_PLACE.USA)
                {
                    _where = 0.0;
                }
                //Test for category
                if (SetCategory == SHIP_COST.A)
                {
                    _packageCost = (double)NumItems * PRICE_EX_A;
                }
                else //(SetCategory == SHIP_COST.B)
                {
                    _packageCost = NumPounds * PRICE_EX_B;
                }
            }
            //default to standard shipping
            else //(SetShipMethod == SHIP_TYPES.STND)
            {
                //Test for surcharge
                if (SetSurcharge == SHIP_PLACE.AK || SetSurcharge == SHIP_PLACE.HI)
                {
                    _where = PRICE_ST_SUR;
                }
                else //(where == SHIP_PLACE.USA)
                {
                    _where = 0.0;
                }
                //Test for category
                if (SetCategory == SHIP_COST.A)
                {
                    _packageCost = (double)NumItems * PRICE_ST_A;
                }
                else //(SetCategory == SHIP_COST.B)
                {
                    _packageCost = NumPounds * PRICE_ST_B;
                }
            }
        }
        #endregion Methods
    }//End class ShippingLogic
}//End namespace Project_05
