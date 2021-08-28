using System;

namespace ImplicitAndExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            // Implicit conversion. You can assign a value from a smaller data type to a larger one:
            int num = 123444;
            long bignum = num;

            float myFloat = 13.353f;
            double myNewDouble = myFloat;


            // Cast double to int. Explicit conversion:
            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;


            // Type conversion. Convert double type to string type:
            string myString = myDouble.ToString();

            // Convert a float to string:
            string mySecondString = myFloat.ToString();

            // Convert a bool to string:
            bool sunIsShining = false;
            string myThirdString = sunIsShining.ToString();



            Console.WriteLine(myInt);
            Console.WriteLine(mySecondString);
            Console.WriteLine(myThirdString);
            Console.ReadLine();
            


        }
    }
}
