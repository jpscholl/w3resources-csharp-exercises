/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 66
//  Description: Write a C# Sharp program to create a new string from two given string one 
//  is shorter and another is longer. The format of the new string will be long string + short 
//  string + long string
*/
using System;

namespace BasicAlgorithm66
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string userString1, userString2;

            //prompt for and store input
            Console.WriteLine("Input two strings");
            Console.Write("String 1: ");
            userString1 = Console.ReadLine();
            Console.Write("String 2: ");
            userString2 = Console.ReadLine();

            //output test resultsfa
            Console.WriteLine("Output: " + newString(userString1, userString2));

        }

        public static string newString(string str1, string str2)
        {
            string longString, shortString;

            if (str1.Length > str2.Length)
            {
                longString = str1;
                shortString = str2;
            }
            else
            {
                longString = str2;
                shortString = str1;
            }

            return longString + shortString + longString;
        }
    }
}
