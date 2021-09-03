/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 71
//  Description: Write a C# Sharp program to check if a given string contains two similar consecutive letters
*/
using System;

namespace BasicExercise71
{
    class Program
    {
        public static bool test(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("\nOriginal string: {0}", userInput);
            Console.WriteLine("Does the string contain consecutive similar letters: " + test(userInput));
        }
    }
}
