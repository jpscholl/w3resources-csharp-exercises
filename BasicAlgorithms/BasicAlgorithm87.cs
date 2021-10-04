/*
//  Author: Jonathan Scholl
//  Date: 10/3/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 87
//  Description: Write a C# Sharp program to create a new string from a given string. 
//  If the first or first two characters is 'a', return the string without those 'a' characters 
//  otherwise return the original given string.
*/
using System;

namespace BasicAlgorithm87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New String: " + newString(userString)); 
        }

        public static string newString(string str)
        {
            if (str.StartsWith("a"))
            {
                str = str.Remove(0, 1);
            }

            if (str.StartsWith("a"))
            {
                str = str.Remove(0, 1);
            }

            return str;
        }
    }
}
