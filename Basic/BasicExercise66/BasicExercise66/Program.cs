/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 66
//  Description: Write a C# Sharp program to find the minimum value from two given two numbers, represented as string.
*/
using System;

namespace BasicExercise66
{
    class Program
    {
        public static string minimum_number_comparison(string str1, string str2)
            {
                return Int32.Parse(str1) > Int32.Parse(str2) ? str2 : str1;
            }
        static void Main(string[] args)
        {
           Console.WriteLine("input number 1: ");
           string num1 = Console.ReadLine();

           Console.WriteLine("input number 2: ");
           string num2 = Console.ReadLine();

           Console.WriteLine(minimum_number_comparison(num1, num2));

        }
    }
}
