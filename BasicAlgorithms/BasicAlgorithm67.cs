/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 67
//  Description: Write a C# Sharp program to concat two given string of length at least 1, 
//  after removing their first character.
*/
using System;

namespace BasicAlgorithm67
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString1, userString2;

            Console.WriteLine("Input two strings.");
            Console.Write("String 1: ");
            userString1 = Console.ReadLine();
            Console.Write("String 2: ");
            userString2 = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString1, userString2));

        }

        public static string newString(string str1, string str2)
        {
            return str1.Substring(1) + str2.Substring(1);
        }
    }
}
