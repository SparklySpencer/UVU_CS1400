using System;

namespace Project_07
{
    /// <summary>
    /// The class which will do all the logical stuffs for the GUI
    /// </summary>
    class DiceLogic
    {
        /// <summary>
        /// A class level reference that builds a new random class.
        /// </summary>
        Random _dieGen = new Random();
        
        #region Fields
        private int _dice1;
        private int _dice2;
        #endregion Fields

        #region Properties
        /// <summary>
        /// A get property will allow an easier interface between the class and the GUI
        /// </summary>
        public string UpdateDie1 { get { return _dice1.ToString(); } }
        /// <summary>
        /// A get property will allow an easier interface between the class and the GUI
        /// </summary>
        public string UpdateDie2 { get { return _dice2.ToString(); } }
        /// <summary>
        /// A get property will display the return string of the method and will interface with the GUI easier.
        /// </summary>
        public string UpdateMSG { get { return DetermineScore(_dice1, _dice2); } }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The default constructor for this class.
        /// </summary>
        public DiceLogic()
        {
            _dice1 = _dieGen.Next(NoMagicThings.DIE_MIN, NoMagicThings.DIE_MAX);
            _dice2 = _dieGen.Next(NoMagicThings.DIE_MIN, NoMagicThings.DIE_MAX);
            DetermineScore(_dice1, _dice2);
        }//End Constructor
        /// <summary>
        /// The method which sorts out what was rolled.
        /// </summary>
        /// <param name="die1">This is a reference to the randomly generated number</param>
        /// <param name="die2">This is a reference to the randomly generated number</param>
        /// <returns>A string to update the label with</returns>
        public string DetermineScore(int die1, int die2)
        {
            if (die1 == NoMagicThings.DIE_MIN && die2 == NoMagicThings.DIE_MIN) //both dice are a 1
            {
                return NoMagicThings.ROLL_1;
            }
            else if (die1 == NoMagicThings.DIE_TWO && die2 == NoMagicThings.DIE_TWO) //both dice are a 2
            {
                return NoMagicThings.ROLL_2;
            }
            else if (die1 == NoMagicThings.DIE_THREE && die2 == NoMagicThings.DIE_THREE) //both dice are a 3
            {
                return NoMagicThings.ROLL_3;
            }
            else if (die1 == NoMagicThings.DIE_FOUR && die2 == NoMagicThings.DIE_FOUR) //both dice are a 4
            {
                return NoMagicThings.ROLL_4;
            }
            else if (die1 == NoMagicThings.DIE_FIVE && die2 == NoMagicThings.DIE_FIVE) //both dice are a 5
            {
                return NoMagicThings.ROLL_5;
            }
            else if (die1 == NoMagicThings.DIE_SIX && die2 == NoMagicThings.DIE_SIX) //both dice are a 6
            {
                return NoMagicThings.ROLL_6;
            }
            else //any other combination of dice.
            {
                return NoMagicThings.ROLL_REG;
            }
        }//End Sort
        #endregion Methods
    }//End class DiceLogic
}//End namespace Project_07
