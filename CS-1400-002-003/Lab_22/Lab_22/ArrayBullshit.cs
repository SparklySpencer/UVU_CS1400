using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_22
{
    class ArrayBullshit
    {
        #region Class Level Var
        //The vars found in the assignment description
        private string[] stngArray; // The string array to be parsed into the orginal array.
        private int[] origArray; // the original array
        private int[] prodArray; // the product array
        private string _input; // will be the user input to parse into an array.
        private int _testInt; // try parse error check value
        private int _count;// will be the index of the array for each time it goes through.
        private double _product; // the product.
        #endregion Class Level Var
        
        #region Constructor
        /// <summary>
        /// The default constructor for this class, which will initialize the variables.
        /// </summary>
        public ArrayBullshit()
        {
            stngArray = new string[NoMagicThings.ARRAY_SIZE]; // The string array to be parsed into the orginal array. WILL BE SIZE 5
            origArray = new int[NoMagicThings.ARRAY_SIZE]; //The origninal array will be 25.
        }
        #endregion Constructor

        #region Methods
        /// <summary>
        /// The method that will fill the array from the user input.
        /// </summary>
        public void GetData()
        {
            //a) creates the array of ints and fills it with ints entered via the user
            //b) the string entered via the user is split (removeing the commas and spaces)
            //c) then parsed into ints and stored into a new array of ints
            _count = 0;
            Console.Clear();
            Console.WriteLine(NoMagicThings.MSG_INST); //Instructions how to enter values
            do //Uses a loop to fill the array by:
            {
                Console.Write(NoMagicThings.MSG_ENTER_VAL, _count);
                _input = Console.ReadLine();
                stngArray = _input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int a = 0; a < stngArray.Length; a++)
                {
                    if (!(int.TryParse(stngArray[a], out _testInt))) // meaning the user entered a string
                    {
                        Console.WriteLine(NoMagicThings.MSG_INVALID_STRING, stngArray[a]);
                        Console.ReadKey();
                        break;
                    }
                    else if (_testInt <= 0) // meaning the user entered a negative number or 0
                    {
                        #region Extra Conditions
                        if (_testInt < 0)
                        {
                            Console.WriteLine(NoMagicThings.MSG_INVALID_INT, _testInt);
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            _input = NoMagicThings.STOP_CHECK;
                            break;
                        }
                        #endregion Extra Condistions
                    }
                    else // meaning the value is an int and it is above 0.
                    {
                        #region Extra Conditions
                        if (_count < origArray.Length)
                        {
                            origArray[_count] = _testInt;
                            _count++;
                        }
                        else
                        {
                            Console.WriteLine(NoMagicThings.MSG_TOO_MANY);
                            Console.ReadKey();
                            _input = NoMagicThings.STOP_CHECK;
                            break;
                        }
                        #endregion Extra Conditions
                    }
                }
            } while (_count < origArray.Length && _input != NoMagicThings.STOP_CHECK);
            ProductData(origArray, out prodArray, out _product); //This calls the product data method which will make a new array and find the sum
            DisplayResults(origArray); // this calls a method to display the results of the origninal array
            DisplayResults(prodArray); // this calls a method to display the results of the new array
            Console.Write(NoMagicThings.MSG_SUM, _product);
            Console.ReadKey();
        }//End GetData()
        /// <summary>
        /// Creates a second int array with altered values (from the oArray)
        /// </summary>
        /// <param name="oArray">The original int array that is passed in</param>
        /// <param name="pArray">The product int array that has altered values</param>
        /// <param name="_product">The sum or product of the pArray</param>
        public void ProductData(int[] oArray, out int[] pArray, out double product)
        {
            product = NoMagicThings.GET_MIN; //Initialize product so we can modify it and the method will be happy.
            pArray = new int[_count]; //Blows the array up into existance in memory to be used.
            for (int i = 0; i < pArray.Length; i++) //This loop will add the increment value and place the product in the new array.
            {
                pArray[i] = origArray[i] + NoMagicThings.ARRAY_ADD;
                product *= pArray[i];
            }
        }//End ProductData()
        /// <summary>
        /// A method to display the results any array
        /// </summary>
        private void DisplayResults(int[] test)
        {
            Console.WriteLine(NoMagicThings.MSG_SHOW_NEW);
            for (int b = 0; b < test.Length; b++)
            {
                Console.WriteLine(NoMagicThings.MSG_PLACEHOLD, test[b]);
            }
        }//End DisplayResults()
        #endregion Methods
    }//End class ArrayBullshit
}//End namespace Lab_22
