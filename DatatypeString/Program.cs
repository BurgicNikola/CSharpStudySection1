using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeString
{
    class Program
    {
        /// <summary>
        ///  Testing the summary.
        /// </summary>
        static void Main(string[] args)
        {
            // String is a Class and not a primitive Datatype.
            // The following 2 are the ways to declare a string. both are the same, coding standard is to use string with a small s.
            string name = "Nikola";
            String name1 = "Nikola";

            string message = "My name is " + name;
            string message2 = $"My name is {name1}";

            // using a method ToUpper() from a String class on our message variable of type string
            string capsMessage = message.ToUpper(); 
            
            Console.WriteLine(capsMessage);
            Console.WriteLine(message2);
            Console.ReadLine();

        }
    }
}
