/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 77
//  Description: Write a C# Sharp program to create a new string taking the first character 
//  from a given string and the last character from another given string. If the length of 
//  any given string is 0, use '#' as its missing character
*/

using System;

namespace BasicAlgorithm77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two strings\n");

            Console.Write("String 1: ");
            var userString1 = Console.ReadLine();

            Console.Write("String 2: ");
            var userString2 = Console.ReadLine();

            Console.WriteLine("New String: " + newString(userString1, userString2));
        }
        public static string newString(string str1, string str2)
        {
            char firstChar, lastChar;

            if (str1.Length == 0)
            {
                firstChar = '#';
            }
            else
            {
                firstChar = Convert.ToChar(str1.Substring(0, 1));
            }

            if (str2.Length == 0)
            {
                lastChar = '#';
            }
            else
            {
                lastChar = Convert.ToChar(str2.Substring(str2.Length - 1, 1));
            }

            return Convert.ToString(firstChar) + Convert.ToString(lastChar);
        }
    }
}
