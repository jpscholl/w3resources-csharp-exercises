/*
//  Author: Jonathan Scholl
//  Date: 9/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String7.cs
*/
using System;

namespace String07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //store count for alphabet, special, and digits
            int letterCount = 0;
            int specialCount = 0;
            int digitCount = 0;

            //input and store string
            Console.Write("Input string: ");
            string userInput = Console.ReadLine();

            //checks each char of the input string and adds to total that matches
            foreach (char c in userInput)
            {
                if (char.IsLetter(c))
                    letterCount++;
                else if (char.IsDigit(c))
                    digitCount++;
                else
                    specialCount++;
            }

            //outputs results
            Console.WriteLine($"String contains {letterCount} letters");
            Console.WriteLine($"String contains {digitCount} numbers");
            Console.WriteLine($"String contains {specialCount} special symbols");
        }
    }
}
