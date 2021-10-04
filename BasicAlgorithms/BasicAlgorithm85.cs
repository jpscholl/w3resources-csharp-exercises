/*
//  Author: Jonathan Scholl
//  Date: 10/3/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 85
//  Description:  Write a C# Sharp program to create a new string from a given string without 
//  the first two characters. Keep the first character if it is "p" and keep the second character if it is "y".
*/
using System;

namespace BasicAlgorithm85
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
            string newStr = "";

            if (str.StartsWith("p"))
            {
                newStr += "p";
            }

            if (str.Substring(1, 1) == "y")
            {
                newStr += "y";
            }

            return newStr += str.Substring(2);
        }
    }
}
