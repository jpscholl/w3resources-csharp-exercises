/*
//  Author: Jonathan Scholl
//  Date: 9/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php Basic Algorithm 56
//  Description: Write a C# Sharp program to compute the sum of the three integers. 
//  If one of the values is 13 then do not count it and its right towards the sum.
*/

using System;

namespace BasicAlgorithm56
{
    class Program
    {
        static void Main(string[] args)
        { 
            int num1, num2, num3;

            Console.WriteLine("Input three integers");
            Console.Write("Int 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Int 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Int 3: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of three digits: " + sumOfDigits(num1, num2, num3));

        }

        public static int sumOfDigits(int x, int y, int z)
        {
            if (x == 13)
            {
                return 0;
            } 
            else if(y == 13)
            {
                return x;
            }
            else if (z == 13)
            {
                return x + y;
            }
            else
            {
                return x + y + z;
            }
        }
    }
}
