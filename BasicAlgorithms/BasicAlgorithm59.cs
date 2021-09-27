/*
//  Author: Jonathan Scholl
//  Date: 9/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 59
//  Description: Write a C# Sharp program to check three given integers (small, medium and large) 
//  and return true if the difference between small and medium and the difference between medium and large is same.
*/

using System;
using System.Collections.Generic;

namespace BasicAlgorithm59
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Input three integers\n");
            Console.Write("Int 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Int 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Int 3: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDifference between small and medium and the \n" +
                "difference between medium and large is same: " + checkNum(num1, num2, num3));
        }

        private static bool checkNum(int x, int y, int z)
        {
            if (x > y && x > z && y > z)
            {
                return x - y == y - z;
            }
            if (x > y && x > z && z > y) 
            {
                return x - z == z - y; 
            }
            if (y > x && y > z && x > z)
            {
                return y - x == x - z;
            }
            if (y > x && y > z && z > x)
            {
                return y - z == z - x;
            }
            if (z > x && z > y && x > y)
            {
                return z - x == x - y;
            }
            return z - y == y - x;

        }
    }
}
