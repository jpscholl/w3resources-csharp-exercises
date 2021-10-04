/*
//  Author: Jonathan Scholl
//  Date: 10/3/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 84
//  Description: Write a C# Sharp program to create a new string from a given string. 
//  If the two characters of the given string from its beginning and end are same return  
//  the given string without the first two characters otherwise return the original string
*/
using System;

namespace BasicAlgorithm84
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            var userString = Console.ReadLine();

            Console.WriteLine("New string: " + newString(userString));
        }

        public static string newString(string str)
        {
            if (str.Length > 1 &&  str.Substring(0, 2) ==  str.Substring(str.Length - 2))
            {
                return str.Substring(2);
            }
            else
            {
                return str;
            } 
        }
    }
}
