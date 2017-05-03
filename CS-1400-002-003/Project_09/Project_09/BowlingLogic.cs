using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_09
{
    /// <summary>
    /// The class I built for all the logical operations and mathy stuffs
    /// </summary>
    class BowlingLogic
    {
        private string[] _arrayNames;
        private int[] _arrayFinalScores;
        private int _count;
        private int _intScore;
        private string _splitNames;
        private int _splitScore;
        private string[] _stupidSplt;

        /// <summary>
        /// The default constructor to initialize the data
        /// </summary>
        public BowlingLogic()
        {
            _arrayNames = new string[NoMagicThings.ASIZE_MAX_PLAYERS];
            _arrayFinalScores = new int[NoMagicThings.ASIZE_MAX_PLAYERS];
            _stupidSplt = new string[NoMagicThings.ASIZE_INPUT];
            _count = 0;
        }//End BowlingLogic()
        #region Properties
        public string GrabName { set; get; }
        public string GrabScore { set; get; }
        public string Grab4Split { set; get; }
        #endregion Properties
        #region Expressions
        //Expressions can be represented as a get property.
        public double AverageScore
        {
            get
            {
                double avg = 0;
                for (int i = 0; i < _count; i++)
                {
                    avg += _arrayFinalScores[i];
                }
                return (avg / _count);
            }
        }//End AverageScores
        #endregion Expressions
        /// <summary>
        /// The method to add names and scores into the arrays
        /// </summary>
        /// <param name="userInput">a string input from the console</param>
        public void AddNewPlayer()
        {
            if (_count >= NoMagicThings.ASIZE_MAX_PLAYERS)
            {
                throw new IndexOutOfRangeException(NoMagicThings.ARR_FULL);
            }
            else if (!(int.TryParse(GrabScore, out _intScore)))
            {
                throw new Exception(String.Format(NoMagicThings.ARR_BAD_SCORE, GrabScore));
            }
            else if (_intScore < 0)
            {
                throw new Exception(String.Format(NoMagicThings.ARR_TOO_LOW, GrabScore));
            }
            else if (_intScore > NoMagicThings.BOWL_MAX_SCORE)
            {
                throw new Exception(String.Format(NoMagicThings.ARR_TOO_HIGH, GrabScore));
            }
            else
            {
                _arrayNames[_count] = GrabName;
                _arrayFinalScores[_count] = _intScore;
                _count++;
            }
        }//End AddNewPlayer()
        /// <summary>
        /// A method to swap names and scores in a parallel fashion.
        /// </summary>
        /// <param name="score1">The index of the array which is smaller</param>
        /// <param name="score2">The index of the array which is greater</param>
        /// <param name="name1">The name tied to the smaller index</param>
        /// <param name="name2">The name tied to the greater index</param>
        public void SwapRef(ref int score1, ref int score2, ref string name1, ref string name2)
        {
            int holdScore = score1;
            string holdName = name1;
            score1 = score2;
            score2 = holdScore;
            name1 = name2;
            name2 = holdName;
        }//End SwapREf()
        /// <summary>
        /// A method to compare scores to swap, and to pass the correct information to the swap method.
        /// </summary>
        /// <param name="scoreArray">The array filled with scores.</param>
        /// <param name="nameArray">The array filled with names.</param>
        public void SortScores(int[] scoreArray, string[] nameArray)
        {
            for (int j = 0; j < scoreArray.Length + NoMagicThings.OFF_ONE_PREVENT; j++)
            {
                for (int k = 0; k < scoreArray.Length + NoMagicThings.OFF_ONE_PREVENT; k++)
                {
                    if (scoreArray[k] < scoreArray[k - NoMagicThings.OFF_ONE_PREVENT])
                    {
                        SwapRef(ref scoreArray[k], ref scoreArray[k - NoMagicThings.OFF_ONE_PREVENT], ref nameArray[k], ref nameArray[k - NoMagicThings.OFF_ONE_PREVENT]);
                    }
                }
            }
        }//End SortScores()
        /// <summary>
        /// A method that will hold the diplay to fill the richtextbox with
        /// </summary>
        public string DisplayResults()
        {
            SortScores(_arrayFinalScores, _arrayNames);
            string epicString = String.Format(NoMagicThings.RDISPLAY_TITLE);
            for (int l = 0; l < _arrayFinalScores.Length; l++)
            {
                if (_arrayNames[l] != null)
                {
                    if (_arrayFinalScores[l] == 300)
                    {
                        epicString += String.Format(NoMagicThings.RDISPLAY_BODY_PSCORE, _arrayNames[l], _arrayFinalScores[l]);
                    }
                    else
                    {
                        epicString += String.Format(NoMagicThings.RDISPLAY_BODY, _arrayNames[l], _arrayFinalScores[l]);
                    }
                }
            }
            epicString += String.Format(NoMagicThings.RDISPLAY_FOOT, AverageScore);
            return epicString;
        }//End DisplayResults()
        /// <summary>
        /// A stupid method to pointlessly split a perfectly valid way of solving the problem (ie. two textboxes). AND SHOULD BE DELETED AS SOON AS A GRADE IS ENTERED!
        /// </summary>
        public string SplitIsStupidInGui()
        {
            int i;
            _stupidSplt = Grab4Split.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (i = 0; i < _stupidSplt.Length + NoMagicThings.OFF_ONE_PREVENT; i++)
            {
                _splitNames = _stupidSplt[i];
                int.TryParse(_stupidSplt[i - NoMagicThings.OFF_ONE_PREVENT], out _splitScore);
            }
            return "This was a huge waste of time!";
        }

    }//End class BowlingLogic
}//End namespace Project_09