/* Project Prologue
Name: Spencer Carter
Class: CS 1400 Section 003
Lab 24: Reading from a File
Date: 04/22/15

I declare that the following code was written by me, provided
by the instrustor, assisted via the lovely people in the drop
in lab, or provided in the textbook for this project. I also
understand that copying source code from any other sourece 
constitutes cheating, and that I will recieve a zero on this
project if I am found in violation of this policy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_24
{
    /// <summary>
    /// The default class built for console apps
    /// </summary>
    class Program
    {
        /// <summary>
        /// A region for all my class level references and/or fields.
        /// </summary>
        #region Class Level Stuff
        static StreamReader sr; //A referenct to a StreamReader object
        static int[] _scores; //A reference to an array
        static int _count; //A count var to determine where in the array values are stored
        #endregion Class Level Stuff
        /// <summary>
        /// The default method built for console apps
        /// </summary>
        static void Main()
        {
            OpenFile();
        }//End Main()
        static void OpenFile()
        {
            _scores = new int[NoMagicThings.ASIZE]; //Creating the array
            sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + NoMagicThings.FILE_NAME); //Creating the StreamReader object
            string fileInput = "";
            do
            {
                fileInput = sr.ReadLine();
                if (!(int.TryParse(fileInput, out _scores[_count])))
                {
                    break;
                }
                Console.WriteLine(NoMagicThings.CW_PLACEHOLD, _scores[_count]);
                _count++;
            } while (fileInput != null);
            Console.Write(NoMagicThings.CW_AVERAGE, CalcAverage());
            Console.ReadLine();
        }//End OpenFile()
        /// <summary>
        /// To calculate the aveage score of the file located in my documents
        /// </summary>
        /// <returns>a double so we can display the average</returns>
        static double CalcAverage()
        {
            double j = 0.0;
            int i;
            for (i = 0; i < _count; i++)
            {
                i += _scores[i];
            }
            j = i / (double)_count;
            return j;
        }//End CalcAverage
    }//End class Program
}//End namesapace Lab_24
