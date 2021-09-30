/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 64
//  Description: Write a C# Sharp program to create a new string of the first half of a given string of even length
*/
using System;

namespace BasicAlgorithm64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString));
        }

        public static string newString(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }
}
