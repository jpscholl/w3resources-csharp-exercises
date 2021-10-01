/*
//  Author: Jonathan Scholl
//  Date: 10/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 82
//  Description: Write a C# Sharp program to combine two given strings. If the given strings have 
//  different length remove the characters from the longer string
*/
using System;

namespace BasicAlgorithm82
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
            if (str1.Length < str2.Length)
            {
                return str1 + str2.Substring(str2.Length - str1.Length);
            }
            else if (str1.Length > str2.Length)
            {
                return str1.Substring(str1.Length - str2.Length) + str2;
            }
            else
            {
                return str1 + str2;
            }
           
        }
    }
}
