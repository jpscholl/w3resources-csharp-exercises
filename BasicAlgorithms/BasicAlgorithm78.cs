/*
//  Author: Jonathan Scholl
//  Date: 10/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 78
//  Description: Write a C# Sharp program to combine two given strings (lowercase). 
//  If there are any double character in new string then omit one character.
*/
using System;

namespace BasicAlgorithm78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two strings");

            Console.Write("String 1: ");
            var userString1 = Console.ReadLine();

            Console.Write("String 2: ");
            var userString2 = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString1, userString2));
        }

        public static string newString(string str1, string str2)
        {
            if (str1.Length < 1)
            {
                return str2;
            }

            if (str2.Length < 1)
            {
                return str1;
            }

            return !str1.EndsWith(str2.Substring(0, 1)) ? str1 + str2 : str1 + str2.Substring(1);
        }
    }
}
