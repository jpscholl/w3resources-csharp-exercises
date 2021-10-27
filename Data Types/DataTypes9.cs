/*
//  Author: Jonathan Scholl
//  Date: 10/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php DataTypes 9
//  Description: Write a C# Sharp program that takes a character as input and check the input (lowercase) 
//  is a vowel, a digit, or any other symbol.
*/
using System;

namespace DataTypes9
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            char userInputChar;

            //prompt and store char
            Console.WriteLine("Input a char");
            userInputChar = Convert.ToChar(Console.ReadLine().ToLower());

            //check char for conditions (lowercase, digit, and other symbol
            //output message based on condition met
            if (isVowel(userInputChar)) Console.WriteLine("It's a lowercase vowel"); 
            else if ((userInputChar >= '0') && (userInputChar <= '9')) Console.WriteLine("It's a digit");
            else Console.WriteLine("It's a different symbol.");

        }
        //check for vowel
        public static bool isVowel(char userChar)
        {
            return userChar == 'a' || userChar == 'e' || userChar == 'i' ||
                userChar == 'o' || userChar == 'u' || userChar == 'y';
        }
    }
}
