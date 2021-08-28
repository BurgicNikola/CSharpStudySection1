using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            string name = "Nikola";
            string height = "191cm";

            // 1. String concatenation:
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hi, my name is " + name + " and I am " + age + " years old.");

            // 2. String formatting:
            // String formatting uses indexing.
            Console.WriteLine("");
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hi, my name is {0} and I am {1} years old.", name, age);
            Console.WriteLine("Hi, my name is {0}, I am {1} tall, and I am {2} old.", name, height, age);

            // 3. String interpolation:
            // String Interpolation uses $ at the start which will allow us to write our variables like this {var}
            Console.WriteLine("");
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hi, my name is {name} and I am {age} years old.");

            // 4. Verbatim strings:
            // Verbatim strings start with @ and tell the compiler to take the string
            // literally and ignore any spaces and escape characters like \n
            Console.WriteLine("");
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Tortor condimentum lacinia quis vel eros donec. Sagittis vitae et leo duis ut diam quam. At tellus at urna condimentum mattis pellentesque id nibh. Eleifend mi in nulla posuere sollicitudin aliquam ultrices sagittis orci. Rutrum tellus pellentesque eu tincidunt tortor aliquam nulla. Massa id neque aliquam vestibulum morbi blandit cursus risus. Eget dolor morbi non arcu risus quis varius quam. Lobortis feugiat vivamus at augue eget arcu dictum varius duis. In metus vulputate eu scelerisque felis. Facilisis mauris sit amet massa vitae tortor condimentum. Nunc id cursus metus aliquam eleifend mi in nulla. Orci sagittis eu volutpat odio facilisis mauris sit amet. Est ultricies integer quis auctor. A diam maecenas sed enim ut sem viverra aliquet. Ipsum consequat nisl vel pretium lectus quam id leo in. Ac turpis egestas sed tempus urna et pharetra. Feugiat nisl pretium fusce id.


            Vitae congue eu consequat ac felis donec et. Morbi quis commodo odio aenean sed adipiscing diam. Bibendum neque egestas congue quisque egestas. Scelerisque eleifend donec pretium vulputate sapien nec. Lectus urna duis convallis convallis tellus id interdum velit. Dui id ornare arcu odio ut sem nulla pharetra diam. Auctor eu augue ut lectus arcu bibendum at varius. Lacus suspendisse faucibus interdum posuere. Vitae justo eget magna fermentum iaculis eu non diam. Magna fringilla urna porttitor rhoncus dolor purus non enim praesent. Ultricies lacus sed turpis tincidunt id aliquet. Pellentesque elit eget gravida cum. Tempor commodo ullamcorper a lacus vestibulum sed arcu. Aliquam malesuada bibendum arcu vitae elementum curabitur vitae nunc. Rhoncus dolor purus non enim. Mollis nunc sed id semper risus in hendrerit. Mauris pellentesque pulvinar pellentesque habitant morbi tristique senectus et netus.");

            // Why use verbatim strings?
            // Instead of using \\ to write file paths we can use verbatim strings to make it easier
            // if you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            Console.WriteLine("");
            Console.WriteLine(@"C:\User\Admin\Doggos\Dog1\Awesome Dog.jpg");
            // Without @ you would have to write the same thing like this
            Console.WriteLine("C:\\User\\Admin\\Doggos\\Dog1\\Awesome Dog.jpg");

            Console.ReadKey();
        }
    }
}
