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

            Console.WriteLine("String Length is " + displayingTheStringLength);

           // <~ End of the program
           Console.ReadLine();
        }
        static string GettingTheInputedString()
        {
            Console.Write("Enter your string: ");
            string inputString = Console.ReadLine();

            return inputString;
        }
        static string GettingTheLengthOfString(string inputedString)
        {
            string getTheLengthOfString = Convert.ToString(inputedString.Length);

            return getTheLengthOfString;
        }
    }
}
