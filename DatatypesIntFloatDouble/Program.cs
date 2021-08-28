using System;

namespace DatatypesIntFloatDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring multiple variables of the same type at once.
            int num3, num4, num5;

            // Declaring a variable.
            int num1;
            // Initializing the variable - assigning a value to a variable.
            num1 = 2;

            // Declaring and initializing the variable.
            int num2 = 5;
            int sum = num1 + num2;

            Console.WriteLine(num1);
            Console.WriteLine(sum);

            // Using concatination.
            Console.WriteLine("num1:" + num1 + " + num2:" + num2 + " is " + sum);
        }
    }
}
