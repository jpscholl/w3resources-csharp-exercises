/*
//  Author: Jonathan Scholl
//  Date: 9/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 63
//  Description: Write a C# Sharp program to create a new string using first two characters of a given string. 
//  If the string length is less than 2 then return the original string.
*/
using System;

namespace BasicAlgorithm63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New output: " + checkString(userString));

        }

        public static string checkString(string str)
        {
            if (str.Length >= 2)
            {
                return str.Substring(0, 2);
            }
            else
            {
                return str;
            }
            
        }
    }
}
