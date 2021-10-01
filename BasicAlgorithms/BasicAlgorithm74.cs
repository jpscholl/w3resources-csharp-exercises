/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 74
//  Description: Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.
*/

using System;

namespace BasicAlgorithm74
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            var userString = Console.ReadLine();

            Console.Write("\nSelect starting index: ");
            var userIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("New string: " + newString(userString, userIndex));
        }

        public static string newString(string str, int x)
        {
            return x + 2 <= str.Length ? str.Substring(x, 2) : str.Substring(0, 2);

        }
    }
}
