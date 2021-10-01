/*
//  Author: Jonathan Scholl
//  Date: 10/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 80
//  Description: Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'. If 
//  the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string
*/
using System;

namespace BasicAlgorithm80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string");
            var userString = Console.ReadLine();

            Console.WriteLine("New string after results: " + newString(userString));
        }

        public static string newString(string str)
        {
            return str.StartsWith("abc") || str.StartsWith("xyz") ? str : null;
        }
    }
}
