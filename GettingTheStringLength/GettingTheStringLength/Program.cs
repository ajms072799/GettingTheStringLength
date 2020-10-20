using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingTheStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
           // Getting the string length
            string inputedString = GettingTheInputedString();

            string displayingTheStringLength = GettingTheLengthOfString(inputedString);

            DisplayingTheStringLength(inputedString, displayingTheStringLength);

           // <~ End of the program
           Console.ReadLine();
        }
        #region GettingTheStringLength Method
        static string GettingTheInputedString()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t\tGetting The Length of String");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Enter a word that you want to know the length: ");
            string inputString = Console.ReadLine();

            return inputString;
        }
        static string GettingTheLengthOfString(string inputedString)
        {
            string getTheLengthOfString = Convert.ToString(inputedString.Length);

            return getTheLengthOfString;
        }
        static void DisplayingTheStringLength(string displayingTheStringLength, string inputedString)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("The length of the word " + "\"" + displayingTheStringLength + "\"" + " is " + inputedString);
            Console.WriteLine("------------------------------------------------------------");
        }
        #endregion
    }
}
