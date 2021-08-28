using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "10";

            // Converting strings into ints.
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int result = num1 + num2;

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
