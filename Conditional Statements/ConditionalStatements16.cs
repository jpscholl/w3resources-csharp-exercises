/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 16
//  Description: Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
*/
using System;

namespace ConditionalStatements16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a letter");
            char inputLetter = Convert.ToChar(Console.ReadLine().ToLower());

            if (inputLetter == 'a' || inputLetter == 'e' || inputLetter == 'i'|| inputLetter == 'o' 
                || inputLetter == 'u') Console.WriteLine("Vowel");
                else if (inputLetter >= 'a' && inputLetter <= 'z') Console.WriteLine("Consonant");
                    else Console.WriteLine("Invalid");
        }
    }
}
