/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 72
//  Description: Write a C# Sharp program to check if a given string ends with "on"
*/

using System;

namespace BasicAlgorithm72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string");
            string userString = Console.ReadLine();

            Console.WriteLine("Ends with \"on\": " + checkString(userString));
        }

        public static bool checkString(string input)
        {
            return input.ToLower().EndsWith("on");
        }
    }
}
