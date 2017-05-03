/* Class Prologue:
 * Name: Spencer Carter
 * CS 1400 Section 3
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab, and/or provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class SalesInvoice
    {
        #region Fields
        private int _salesTicket;
        private string _unitDescription;
        private int _unitQuantity;
        private double _unitPrice;
        private double _netCost;
        private double _taxState;
        public const double TAX_STATE = 0.067256;
        private double _taxLocal;
        public const double TAX_LOCAL = 0.025666;
        private double _totalCost;
        #endregion Fields

        #region Properties
        public int Quantity
        {
            set
            {
                _unitQuantity = value;
            }
            get
            {
                return _unitQuantity;
            }
        }
        public double Price
        {
            set
            {
                _unitPrice = value;
            }
            get
            {
                return _unitPrice;
            }
        }
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
        }
        public int TicketNumber
        {
            set
            {
                _salesTicket = value;
            }
            get
            {
                return _salesTicket;
            }
        }
        #endregion Properties

        #region Expressions
        //Expressions can be represented as Get Properties
        public double CalcTotalCost
        {
            get
            {
                _totalCost = _netCost + _taxState + _taxLocal;
                return _totalCost;
            }
        }
        public double CalcNetCost
        {
            get
            {
                _netCost = _unitQuantity * _unitPrice;
                return _netCost;
            }
        }
        public double CalcStateTax
        {
            get
            {
                _taxState = _netCost * TAX_STATE;
                return _taxState;
            }
        }
        public double CalcLocalTax
        {
            get
            {
                _taxLocal = _netCost * TAX_LOCAL;
                return _taxLocal;
            }
        }
        #endregion Expressions

        #region Methods
        //Default constructor
        SalesInvoice();
        #endregion Methods
    }//End class
}//End namespace
