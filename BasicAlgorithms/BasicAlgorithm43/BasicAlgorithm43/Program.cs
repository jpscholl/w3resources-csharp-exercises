/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 43
//  Description: Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both
*/
using System;

namespace BasicAlgorithm43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer: ");
            int numInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiple of 3 or 7, but not both: " + multipleOf3or7(numInput));
            
        }
        public static bool multipleOf3or7(int num)
        {
            return num % 3 == 0 ^ num % 7 == 0;
        }
    }
}
