/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 44
//  Description: Write a C# Sharp program to check if a given number is within 2 of a multiple of 10
*/
using System;

namespace BasicAlgorithm44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Within 2 of multiple of 10: " + within2OfMultipleOf10(inputNum));
        }

        public static bool within2OfMultipleOf10(int input)
        {
            return input % 10 <= 2 || input % 10 >= 8;
        }
    }
}
