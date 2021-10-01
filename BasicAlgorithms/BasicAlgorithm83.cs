/*
//  Author: Jonathan Scholl
//  Date: 10/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 83
//  Description: Write a C# Sharp program to create a new string using 3 copies of the first 
//  2 characters of a given string. If the length of the given string is less than 2 use the whole string.
*/
using System;

namespace BasicAlgorithm83
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string");
            var userString = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString));
        }
        public static string newString(string str)
        {
            return str.Length > 1 ? str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) : str + str + str;
        }
    }
}
