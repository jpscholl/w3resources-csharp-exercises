/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 70
//  Description: Write a C# Sharp program to create a new string without the first and last character of a given string of any length.
*/
using System;

namespace BasicAlgorithm70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string");
            string userInput = Console.ReadLine();

            Console.WriteLine("New String: " + newString(userInput));
        }
        public static string newString(string input)
        {
            return input.Substring(1, input.Length - 2);
        }
    }
}
