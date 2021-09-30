/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 69 niiice....
//  Description: Write a C# Sharp program to move the last two characters to the start of a given string of length at least two. 
*/
using System;

namespace BasicAlgorithm69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string");
            string userInput = Console.ReadLine();

            Console.WriteLine(newString(userInput));
        }

        public static string newString(string input)
        {
            if (input.Length > 2)
            {
                return input.Substring(input.Length - 2, 2) + input.Substring(0, input.Length - 2);
            }
            else
            {
                return input;
            }   
        }
    }
}
