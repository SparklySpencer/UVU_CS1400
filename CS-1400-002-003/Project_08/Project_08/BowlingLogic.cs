using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_08
{
    class BowlingLogic
    {
        private string[] _arrayNames;
        private int[] _arrayFinalScores;
        public int _count;
        private string[] _arrayUserInput;

        /// <summary>
        /// The default constructor to initialize the data
        /// </summary>
        public BowlingLogic()
        {
            _arrayUserInput = new string[NoMagicThings.ASIZE_INPUT];
            _arrayNames = new string[NoMagicThings.ASIZE_MAX_PLAYERS];
            _arrayFinalScores = new int[NoMagicThings.ASIZE_MAX_PLAYERS];
            _count = 0;
        }//End BowlingLogic()

        /// <summary>
        /// The method to add names and scores into the arrays
        /// </summary>
        /// <param name="userInput">a string input from the console</param>
        public void AddNewPlayer(string userInput)
        {
            int _testInt;
            _arrayUserInput = userInput.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (_count >= NoMagicThings.ASIZE_MAX_PLAYERS)
            {
                throw new IndexOutOfRangeException(NoMagicThings.ARR_FULL);
            }
            else if (_arrayUserInput.Length < 2)
            {
                throw new Exception("Invalid Entry: You did not enter a score, try again.");
            }
            else if (!(int.TryParse(_arrayUserInput[NoMagicThings.POINTER_SCORES], out _testInt)))
            {
                throw new Exception(String.Format(NoMagicThings.ARR_BAD_SCORE, _arrayUserInput[1]));
            }
            else if (_testInt < 0)
            {
                throw new Exception(String.Format(NoMagicThings.ARR_TOO_LOW, _arrayFinalScores[_count]));
            }
            else if (_testInt > NoMagicThings.BOWL_MAX_SCORE)
            {
                throw new Exception(String.Format(NoMagicThings.ARR_TOO_HIGH, _arrayFinalScores[_count]));
            }
            else
            {
                _arrayNames[_count] = _arrayUserInput[0];
                _arrayFinalScores[_count] = _testInt;
                _count++;
            }
        }//End AddNewPlayer()
        /// <summary>
        /// A method to figure out which score is the highest
        /// </summary>
        /// <returns>The index location of the highest score</returns>
        private int HighestScore()
        {
            int biggest = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_arrayFinalScores[i] > _arrayFinalScores[biggest])
                    biggest = i;
            }
            return biggest;
        }//End HighestScores()
        /// <summary>
        /// A method to figure out which score is the lowest
        /// </summary>
        /// <returns>the index location of the lowest score</returns>
        private int LowestScore()
        {
            int lowest = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_arrayFinalScores[i] < _arrayFinalScores[lowest])
                    lowest = i;
            }
            return lowest;
        }//End LowestScores()
        /// <summary>
        /// A method to figure out the average score
        /// </summary>
        /// <returns>The value of the average score</returns>
        private double AverageScore()
        {
            double avg = 0;
            for (int i = 0; i < _count; i++)
            {
                avg += _arrayFinalScores[i];
            }
            return (avg / _count);
        }//End AverageScore()
        /// <summary>
        /// A method to hold the information to display to console window
        /// </summary>
        /// <returns>A formated display of all the bs Professor F wanted.</returns>
        public string PrintGame()
        {
            string _penStuff = "";
            _penStuff += NoMagicThings.HIGHEST + _arrayNames[HighestScore()] + NoMagicThings.TAB + _arrayFinalScores[HighestScore()] + NoMagicThings.NEWLINE;
            _penStuff += NoMagicThings.LOWEST + _arrayNames[LowestScore()] + NoMagicThings.TAB + _arrayFinalScores[LowestScore()] + NoMagicThings.NEWLINE;
            _penStuff += NoMagicThings.AVG + AverageScore();
            return _penStuff;
        }//End PrintGame()
    }//End class BowlingLogic
}//End namespace Project_08
