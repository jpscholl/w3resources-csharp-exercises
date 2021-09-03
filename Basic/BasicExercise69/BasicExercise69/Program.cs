/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 69
//  Description: Nice....
//  Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters.
*/
using System;

namespace BasicExercise69
{
    class Program
    {
        public static bool uppercase_or_lowercase_only(string str1)
        {
            return str1 == str1.ToUpper() | str1 == str1.ToLower();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input text: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("The text contain only upper or lower case letters: " + uppercase_or_lowercase_only(userInput));
        }
    }
}
