/*
//  Author: Jonathan Scholl
//  Date: 9/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String9.cs
*/
using System;

namespace String09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables for count
            int vowelCount = 0;
            int consonantCount = 0;

            //prompt user to input string and store into variable
            Console.Write("Input a string: ");
            string userInputString = Console.ReadLine();
            userInputString.ToLower();

            //checks each char
            for (int x = 0; x < userInputString.Length; x++)
            {
                if (userInputString[x] == 'a' || userInputString[x] == 'e' || userInputString[x] == 'i'
                    || userInputString[x] == 'o' || userInputString[x] == 'u')
                {
                    vowelCount++;
                }
                else if (userInputString[x] >= 'a' && userInputString[x] <= 'z')
                {
                    consonantCount++;
                }

            }

            //outputs results
            Console.WriteLine($"\nVowels: {vowelCount}");
            Console.WriteLine($"Consonants: {consonantCount}");

        }
    }
}
