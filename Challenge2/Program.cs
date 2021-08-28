﻿using System;

/*This application asks the user to input a string in the first line like “Enter a string here: ”.
* In the Second Line, it should ask for the character to search in the string which you have entered in the first line like 
* “Enter the character to search: ”
* On the third line, it should write the index of the first occurrence of the searched character from the string.
* Now on concatenation...
* It should then ask to enter the first name and once the name is written and the enter button is pressed, 
* it should ask to enter the last name.
* It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". 
* Output can be different in your case. Try to store the full name in a variable, before displaying it.*/

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string here: ");
            string input = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            // We are using char data type because we only require one character from the user. In case they enter a string
            // we will only take the first character of that string and the program will continue.
            char character = Console.ReadLine()[0];
            Console.WriteLine($"Index of the first occurrence of the searched character: {input.IndexOf(character)}");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);
            Console.Read();
        }
    }
}