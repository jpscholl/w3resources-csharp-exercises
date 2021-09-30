/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 68
//  Description: Write a C# Sharp program to move the first two characters to the end of a given string of length at least two
*/
using System;

namespace BasicAlgorithm68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            var userInput = Console.ReadLine();

            Console.WriteLine("New string output: " + newString(userInput));

        }
        public static string newString(string input)
        {
            if (input.Length > 2)
            {
                return input.Substring(2) + input.Substring(0, 2);
            }
            else
            {
                return input;
            }
            
        }
    }
}
