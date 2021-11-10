/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 2
//  Description: Write a C# Sharp program to find the sum of first 10 natural numbers
*/
using System;

namespace ForLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int x = 1; x <= 10; x++)
            {
                sum += x;
            }

            Console.WriteLine($"Sum of first 10 numbers: {sum}");
        }
    }
}
