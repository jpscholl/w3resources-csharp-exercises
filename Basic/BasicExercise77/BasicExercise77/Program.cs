/*
//  Author: Jonathan Scholl
//  Date: 5/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 77
//  Description: Write a C# Sharp program to check whether a given word is plural or not.
*/
using System;

namespace BasicExercise77
{
    class Program
    {
        public static bool isPlural(string word)
        {
            return word.EndsWith("s");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text");
            string userInput = Console.ReadLine();

            Console.WriteLine("Is the input plural: " + isPlural(userInput));

        }
    }
}
