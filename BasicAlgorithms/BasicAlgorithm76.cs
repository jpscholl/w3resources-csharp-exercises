/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 76
//  Description: Write a C# Sharp program to create a new string of length 2, using first two characters of a given string. 
//  If the given string length is less than 2 use '#' as missing characters
*/

using System;

namespace BasicAlgorithm76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString));
        }
        public static string newString(string str)
        {
            if (str.Length >= 2)
            {
                return str.Substring(0, 2);
            } 
            else if (str.Length == 1)
            {
                return str.PadRight(2, '#');
            }
            else
            {
                return ("##");
            }
        }
    }
}
