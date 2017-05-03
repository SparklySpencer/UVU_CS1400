/* Project Prologue {
 * Name: Spencer Carter
 * Class: CS 1400 Section 003
  Project 04 - Sales Invoice Windows Form Application
 * Date: 03/16/15
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

namespace Project_04
{
    /// <summary>
    /// The class that I wrote to do the business logic.
    /// </summary>
    class SalesInvoice
    {
        //A region for all the class level variables.
        //Also a place to store const to prevent magic things.
        #region Fields
        // the following will be variables we get from the GUI
        private int _unitQuantity;
        private double _unitPrice;
        private string _unitDescription;
        // the following will be const
        public double TAX_STATE = 0.067256;
        public double TAX_LOCAL = 0.025666;
        public const string PLACE_FORMAT_D = "{0:D}";
        public const string PLACE_FORMAT_F = "{0:F2}";
        public const string DEFAULT_DESCRIPTION = "Item";
        #endregion Fields
        
        //A region for all the properties that pull info from the GUI
        #region Properties
        /// <summary>
        /// Purpose: to directly take the stirng input from the GUI and parse it into what we need.
        /// </summary>
        public string SQuantity
        {
            set
            {
                int.TryParse(value, out _unitQuantity);
            }
            get
            {
                return string.Format(PLACE_FORMAT_D, _unitQuantity);
            }
        }//End SQuantity
        /// <summary>
        /// Purpose: to directly take the stirng input from the GUI and parse it into what we need.
        /// </summary>
        public string SPrice
        {
            set
            {
                double.TryParse(value, out _unitPrice);
            }
            get
            {
                return string.Format(PLACE_FORMAT_F, _unitPrice);
            }
        }//End SPrice
        /// <summary>
        /// Purpose: Automatic properties for the textboxes.
        /// </summary>
        public string Description
        {
            set
            {
                _unitDescription = value;
            }
            get
            {
                return _unitDescription;
            }
        }//End Description
        #endregion Properties
        
        //A region for all the expressions, which can be represented as a get property
        #region Expressions
        /// <summary>
        /// Purpose to do some calculations and make it availabe for event handles to use.
        /// </summary>
        public double CalcTotalCost
        {
            get
            {
                return CalcNetCost + CalcStateTax + CalcLocalTax;
            }
        }//End CalcTotalCost
        /// <summary>
        /// Purpose to do some calculations and make it availabe for event handles to use.
        /// </summary>
        public double CalcNetCost
        {
            get
            {
                return _unitQuantity * _unitPrice;
            }
        }//End CalcNetCost
        /// <summary>
        /// Purpose to do some calculations and make it availabe for event handles to use.
        /// </summary>
        public double CalcStateTax
        {
            get
            {
                return CalcNetCost * TAX_STATE;
            }
        }//End CalcStateTax
        /// <summary>
        /// Purpose to do some calculations and make it availabe for event handles to use.
        /// </summary>
        public double CalcLocalTax
        {
            get
            {
                return CalcNetCost * TAX_LOCAL;
            }
        }//End CalcLocalTax
        #endregion Expressions
        
        //A region for all the methods and constructors.
        #region Methods
        /// <summary>
        /// Purpose: The default constructor for the class.
        /// </summary>
        public SalesInvoice()
        {
            Reset();
        }//End SalesInvoive
        /// <summary>
        /// Purpose: to reset the variables to their default value.
        /// </summary>
        public void Reset()
        {
            _unitQuantity = 0;
            _unitPrice = 0.0;
            _unitDescription = DEFAULT_DESCRIPTION;
        }//End Reset()
        #endregion Methods
    }//End class SalesInvoice
}//End namespace Project_04
