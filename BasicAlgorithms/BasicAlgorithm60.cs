/*
//  Author: Jonathan Scholl
//  Date: 9/28/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php
//  Description: Write a C# Sharp program to create a new string using two given strings s1, s2, 
//  the format of the new string will be s1s2s2s1
*/
using System;

namespace BasicAlgorithm60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two strings");
            Console.Write("String 1:");
            string firstString = Console.ReadLine();
            Console.Write("String 1:");
            string secondString = Console.ReadLine();

            Console.WriteLine("New string from input: " + newString(firstString, secondString));
        }

        public static string newString(string str1, string str2)
        {
            return str1 + str2 + str2 + str1;
        }
    }
}
