/*
//  Author: Jonathan Scholl
//  Date: 9/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php Basic Algorithm 55
//  Description: Write a C# Sharp program to compute the sum of three given integers. If the two 
//  values are same return the third value.
*/

using System;

namespace BasicAlgorithm55
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

            Console.WriteLine("Outcome: " + checkSum(num1, num2, num3));
        }
        public static int checkSum(int x, int y, int z)
        {
            return x == y ? z : (x + y + z);
        }
    }
}
