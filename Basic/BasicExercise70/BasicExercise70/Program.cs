/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 70
//  Description: Write a C# Sharp program to remove the first and last elements from a given string
*/
using System;

namespace BasicExercise70
{
    class Program
    {
        public static string test(string str1)
        {
            return str1.Length > 2 ? str1.Substring(1, str1.Length - 2) : str1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Original string: PHP");
            Console.WriteLine("After removing first and last elements: " + test("PHP"));
            Console.WriteLine("Original string: Python");
            Console.WriteLine("After removing first and last elements: " + test("Python"));
            Console.WriteLine("Original string: JavaScript");
            Console.WriteLine("After removing first and last elements: " + test("JavaScript"));
        }
    }
}
