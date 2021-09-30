/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 65
//  Description: Write a C# Sharp program to create a new string without the first and last character of a given string of length at least two.
*/
using System;

namespace BasicAlgorithm65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString));
        }
        public static string newString(string str)
        {
            return str.Length >= 2 ? str.Substring(1, str.Length - 2) : " ";
        }
    }
}
