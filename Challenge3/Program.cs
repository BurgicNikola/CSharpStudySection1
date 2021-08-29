using System;

/* 
 * Now that you know how to declare and initialize Variables, please go ahead and create a variable 
 * for each of the primitive datatypes 
 * (list: https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN). 
 * Leave the Object datatype out.
 * And also please initialize each variable with a working value.
 * Then create two values of type string. 
 * The first one should say "I control text"
 * The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.
 * Add each an output for each of the variables and write it onto the console. (WriteLine)
 * Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
*/

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 to 255
            byte byteVariable = 255;
            // -128 to 127
            sbyte sbyteVariable = -128;
            // -2,147,483,648 to 2,147,483,647
            int intVariable = 2147483647;
            // 0 to 4294967295
            uint uintVariable = 0;
            // -32,768 to 32,767
            short shortVariable = 32767;
            // 0 to 65535
            ushort ushortVariable = 65535;
            // -9223372036854775808 to 9223372036854775807
            long longVariable = -4544447871;
            // 0 to 18446744073709551615
            ulong ulongVariable = 0;

            // For floats use F as a suffix
            float floatVariable = 55.12345f;
            double doubleVariable = 55.32187654654;
            // For decimals use M as a suffix
            decimal decimalVariable = 441.54897651321684234M;

            char charVariable = 'g';
            bool boolVariable = true;
            string stringVariable1 = "I control text";
            string stringVariable2 = "434";

            int parsed = Int32.Parse(stringVariable2);

            Console.WriteLine(byteVariable);
            Console.WriteLine(sbyteVariable);
            Console.WriteLine(intVariable);
            Console.WriteLine(uintVariable);
            Console.WriteLine(shortVariable);
            Console.WriteLine(ushortVariable);
            Console.WriteLine(longVariable);
            Console.WriteLine(ulongVariable);
            Console.WriteLine(floatVariable);
            Console.WriteLine(doubleVariable);
            Console.WriteLine(decimalVariable);
            Console.WriteLine(charVariable);
            Console.WriteLine(boolVariable);
            Console.WriteLine(stringVariable1);
            Console.WriteLine(stringVariable2);
            Console.WriteLine(parsed);
            Console.Read();
        }
    }
}
