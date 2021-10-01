/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 75
//  Description: Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3.
*/

using System;

namespace BasicAlgorithm75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString));
        }
        public static string newString(string str)
        {
            return str.Substring((str.Length - 1) / 2 - 1, 3);
        }
    }
}
