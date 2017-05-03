/* Class Prologue:
 * Name: Spencer Carter
 * CS 1400 Section 3
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab, and/or provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 * 
 * I also declare that Bob & Taylor are amazing people who also helped me
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class TokenMachine
    {
        #region Fields
        private int _numTokens;
        private int _numQuarters;
        private double _totalMoney;
        public const int START_TOKENS = 100;
        public const double VALUE_QUARTER = 0.25;
        #endregion Fields
        #region Automatic Properties
        public int NumQuarters
        {
            get
            {
                return _numQuarters;
            }
            set
            {
                _numQuarters = value;
            }
        }
        #endregion Automatic Properties
        #region Expressions
        //Expressions can be written as get properties
        /// <summary>
        /// Purpose: to get NumTokens to the event handlers
        /// </summary>
        public int NumTokens
        {
            get
            {
                return _numTokens;
            }
        }
        /// <summary>
        /// Purpose: to get the monetary value for the event handlers
        /// </summary>
        public double ValMoney
        {
            get
            {
                return _totalMoney;
            }
        }
        #endregion Expresions
        #region Methods
        /// <summary>
        /// Purpose: The constructor that is used to initialize the data members of a TokenMachine object.
        /// </summary>
        public TokenMachine()
        {
            _numTokens = START_TOKENS;
            _numQuarters = 0;
            _totalMoney = _numQuarters * VALUE_QUARTER;
        }
        /// <summary>
        /// Purpose: The reset operation removes (returns) all of the quarters,
        /// and fills the machine with tokens. For this class we will assume 
        /// that the machine holds 100 tokens.
        /// </summary>
        public void Reset()
        {
            _numTokens = START_TOKENS;
            _numQuarters = 0;
            _totalMoney = _numQuarters * VALUE_QUARTER;
        }
        /// <summary>
        /// Purpose: You get a token by putting a quarter in the machine.
        /// The number of tokens in the machine is reduced by the appropriate value,
        /// and the number of quarters in the machine is increased by one.
        /// One token is returned by the method.
        /// </summary>
        /// <returns></returns>
        public bool GetToken()
        {
            if (_numQuarters == START_TOKENS)
            {
                return false;
            }
            else
            {
                _numQuarters++;
                _numTokens--;
                _totalMoney = _numQuarters * VALUE_QUARTER;
                return true;
            }
        }
        #endregion Methods
    }//End class
}//End namespace
