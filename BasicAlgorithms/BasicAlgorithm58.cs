/*
//  Author: Jonathan Scholl
//  Date: 9/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php BA 58
//  Description:  Write a C# Sharp program to check two given integers and return the value 
//  whichever value is nearest to 13 without going over. Return 0 if both numbers go over.
*/

using System;

namespace BasicAlgorithm58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two integers");
            Console.Write("Int 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Int 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Closest to 13: " + checkNum(num1, num2));
        }
        private static int closeToThirteen(int n)
        {
            return n - 13;
        }
        public static int checkNum(int x, int y)
        {
            if (x <= 13 && y <= 13)
            {
                return closeToThirteen(x) > closeToThirteen(y) ? x : y;
            }
            else
            {
                return 0;
            }
        }
    }
}
