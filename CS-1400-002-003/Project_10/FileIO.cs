using System;
using System.IO;

namespace Project_10
{
    /// <summary>
    /// The class I made to handle all the file IO stuffs
    /// </summary>
    class FileIO
    {
        #region Fields
        private StreamReader sr;
        private StreamWriter sw;
        private WindChillCalc wc;
        string[] stringArray;
        #endregion Fields

        #region Properties
        public string FilePath { set; get; }
        #endregion Properties

        #region Expressions
        public string AskForFilename { get { return "Please enter a valid file name, with a valid file extension: "; } }
        #endregion Expressions

        #region Constructor

        /// <summary>
        /// The constructor for this class
        /// </summary>
        public FileIO()
        {
            wc = new WindChillCalc();
            stringArray = new string[2];
            FilePath = null;
            TestFileName();
        }//End FileIO()
        #endregion Constructor

        #region Methods
        /// <summary>
        /// A method to test for valid input
        /// </summary>
        private void TestFileName()
        {
            Console.Write(AskForFilename);
            FilePath = Console.ReadLine();
            if (FilePath == null || FilePath == "")
            {
                throw new FileNotFoundException("You did not enter a valid file.");
            }
            else if (File.Exists(FilePath))
            {
                OpenFile();
            }
            else if (!(File.Exists(FilePath)))
            {
                Console.WriteLine("No such file exists, we added one to your documents");
                sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + FilePath);
                sw.WriteLine("-90, 50\r"); //Test Data
                sw.Close();
                sw.Dispose();
                OpenFile();
            }
        }//End TestFileName()
        /// <summary>
        /// A method to split the document into usable bits.
        /// </summary>
        public void OpenFile()
        {
            sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + FilePath);
            string toBeSplit;
            do
            {
                toBeSplit = sr.ReadLine();
                stringArray = toBeSplit.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < 1; i++)
                {
                    WindChillTry(stringArray[i], stringArray[i + 1]);
                }
            } while (sr.EndOfStream != false);
            sr.Close();
            Console.ReadKey();
        }//End OpenFile()
        /// <summary>
        /// A method that will be feed information from a file, which will validate the data and display the correct wind chill.
        /// </summary>
        public void WindChillTry(string temp, string speed)
        {
            Console.WriteLine(wc.IntroMessage);
            Console.Write(wc.AskTemperature);
            wc.GrabTemperature = temp;
            if (wc.GrabTemperature == "")
            {
                Console.WriteLine("\nGoodbye!");
                Console.ReadKey();
                return;
            }
            try
            {
                Console.Write(wc.AskWindSpeed);
                wc.GrabWindSpeed = speed;
                wc.ValidateDAta();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                if (wc.MASTER == true)
                    Console.WriteLine("\n\tThe wind chill index is {0:f3} F\n", wc.CalcWindChillIndex);
            }
        }//End WindChillTry()
        #endregion Methods
    }//End class FileIO
}//End namespace Project 10
