using System;

namespace Project_10
{
    /// <summary>
    /// The class I created to calculate the wind chill based off user input.
    /// </summary>
    class WindChillCalc
    {
        #region Fields
        private double _temperature;
        private double _windSpeed;
        public const double BASE_1 = 35.74;
        public const double BASE_2 = 35.75;
        public const double MULTI_1 = 0.6215;
        public const double MULTI_2 = 0.4275;
        public const double POWER = 0.16;
        public bool MASTER;
        #endregion Fields

        #region Properties
        /// <summary>
        /// Pulls the temperature from a readline event in the console
        /// </summary>
        public string GrabTemperature { set; get; }
        /// <summary>
        /// Pulls the wind speed from a readline event in the console
        /// </summary>
        public string GrabWindSpeed { set; get; }
        #endregion Properties

        #region Expressions
        /// <summary>
        /// Makes an intro message available to the console
        /// </summary>
        public string IntroMessage { get { return "Welcome to the Wind Chill Calculator!\n\n\tPress enter to exit.\n"; } }
        /// <summary>
        /// Makes a request available to the console
        /// </summary>
        public string AskTemperature { get { return "Please enter a valid double value for a temperature in F: "; } }
        /// <summary>
        /// Makes a request available to the console
        /// </summary>
        public string AskWindSpeed { get { return "Please enter a valid wind speed value, which is greater than 0, in MPH: "; } }
        /// <summary>
        /// Makes the Wind Chill Index available to the console
        /// </summary>
        public double CalcWindChillIndex { get { return (BASE_1 + MULTI_1 * _temperature - BASE_2 * Math.Pow(_windSpeed, POWER) + MULTI_2 * _temperature * Math.Pow(_windSpeed, POWER)); } }
        #endregion Expressions

        #region Constructor
        /// <summary>
        /// The default constructor for this class, which will initialize the fields for first time use.
        /// </summary>
        public WindChillCalc()
        {
            _temperature = 0.0;
            _windSpeed = 0.0;
        }
        #endregion Constructor

        #region Methods
        /// <summary>
        /// A method to validate the user input
        /// </summary>
        public void ValidateDAta()
        {
            if (!(double.TryParse(GrabTemperature, out _temperature)))
            {
                MASTER = false;
                throw new Exception(String.Format("Your temperature value was not a number: {0}", GrabTemperature));
            }
            else if (!(double.TryParse(GrabWindSpeed, out _windSpeed)))
            {
                MASTER = false;
                throw new Exception(String.Format("Your wind-speed value was not a number: {0}", GrabWindSpeed));
            }
            else if (_windSpeed < 0)
            {
                MASTER = false;
                throw new Exception(String.Format("The wind speed cannot be a negative number: {0}", _windSpeed));
            }
            MASTER = true;
        }
        #endregion Methods
    }//End class WindChillCalc
}//End namespace Project_10
