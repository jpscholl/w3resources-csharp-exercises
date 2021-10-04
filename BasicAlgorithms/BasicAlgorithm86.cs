/*
//  Author: Jonathan Scholl
//  Date: 10/3/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 86
//  Description: Write a C# Sharp program to create a new string from a given string without the 
//  first and last character if the first or last characters are 'a' otherwise return the original given string.
*/
using System;

namespace BasicAlgorithm86
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString));
        }
        public static string newString(string str)
        {
            if (str.StartsWith("a"))
            {
                str = str.Remove(0, 1);
            }

            if(str.EndsWith("a"))
            {
                str = str.Remove(str.Length - 1, 1);
            }

            return str;
        }
    }
}
