/*
//  Author: Jonathan Scholl
//  Date: 9/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php Basic Algorithm 57
//  Description: Write a C# Sharp program to compute the sum of the three given integers. However, if any of 
//  the values is in the range 10..20 inclusive then that value counts as 0, except 13 and 17
*/
using System;

namespace BasicAlgorithm57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input three integers");
            Console.Write("Int 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Int 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Int 3: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of ints: " + checkSum(num1, num2, num3));
        }
        private static int numAsZero(int n)
        {
            return (n < 13 && n > 9) || (n > 17 && n < 21) ? 0 : n;
        }
        public static int checkSum(int x, int y, int z)
        {
            return numAsZero(x) + numAsZero(y) + numAsZero(z);
        }
    }
}
