using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadVsReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();

            Console.Write("Enter any string and press Enter: ");
            // Console.ReadLine() takes string or integer input and returns it as the Output value. 
            string stringInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", stringInput);
            Console.Write("Enter any key and press Enter: ");
            // Console.Read() takes a single input of type string and returns the ASCII value of that input.
            int asciiInput = Console.Read();
            Console.WriteLine($"You have entered {asciiInput}");
            Console.ReadKey();

        }
    }
}
