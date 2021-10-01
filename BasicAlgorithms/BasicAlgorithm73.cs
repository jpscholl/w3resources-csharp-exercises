/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 73
//  Description: Write a C# Sharp program to create a new string using the first and 
//  last n characters from a given string of length at least n.
*/

using System;

namespace BasicAlgorithm73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string userString = Console.ReadLine();

            Console.Write("\nEnter an integer: ");
            int userInt = int.Parse(Console.ReadLine());

            Console.WriteLine("New string: " + newString(userString, userInt));
        }

        public static string newString(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n);
        }
    }
}
