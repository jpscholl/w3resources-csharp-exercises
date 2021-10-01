/*
//  Author: Jonathan Scholl
//  Date: 10/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 81
//  Description: Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same.
*/
using System;

namespace BasicAlgorithm81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string");
            var userString = Console.ReadLine();

            Console.WriteLine("First two same as last two: " + checkString(userString));
        }
        public static bool checkString(string str)
        {
            return str.Substring(0, 2) == str.Substring(str.Length - 2);
        }
    }
}
