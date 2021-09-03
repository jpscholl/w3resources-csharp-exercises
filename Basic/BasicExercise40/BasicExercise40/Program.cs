/*
//  Author: Jonathan Scholl
//  Date: 3/5/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 40
//  Description: Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
*/
using System;

namespace BasicExercise40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
        }
    }
}
