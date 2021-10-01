/*
//  Author: Jonathan Scholl
//  Date: 10/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 79
//  Description: Write a C# Sharp program to create a new string from a given string after swapping last two characters.
*/
using System;

namespace BasicAlgorithm79
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString));
        }
        public static string newString(string str)
        {

            if (str.Length > 1)
            {
                string last = str.Substring(str.Length - 1);
                string secondLast = str.Substring(str.Length - 2, 1);

                return str.Substring(0, str.Length - 2) + last + secondLast;
            } 
            else
            {
                return str;
            }
            
        }
    }
}
