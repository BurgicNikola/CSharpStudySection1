using System;

namespace Constants
{
    // Constants are immutable values which are known at
    // compile timeand do not change for the life of the program.

    class Program
    {
        // Constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string dateOfBirth = "29.01.1991.";

        static void Main(string[] args)
        {
            Console.WriteLine($"My date of birth is {dateOfBirth}");
            Console.Read();
        }
    }
}
