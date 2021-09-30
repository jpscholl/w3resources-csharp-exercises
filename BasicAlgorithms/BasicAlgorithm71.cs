/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 71
//  Description: Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2)
*/
using System;

namespace BasicAlgorithm71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string");
            string userInput = Console.ReadLine();

            Console.WriteLine(newString(userInput));
        }

        public static string newString(string input)
        {
            return input.Substring((input.Length / 2) - 1, 2);
        }
    }
}
