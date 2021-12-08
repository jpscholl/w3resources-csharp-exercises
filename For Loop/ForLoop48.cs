/*
//  Author: Jonathan Scholl
//  Date: 12/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop48
//  Description: Write a C# Sharp program to find Strong Numbers within a range of numbers
*/
using System;

namespace ForLoop48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input start range: ");
            int startRange = int.Parse(Console.ReadLine());

            Console.Write("Input end range: ");
            int endRange = int.Parse(Console.ReadLine());

            Console.Write("Strong numbers in range: ");

            for (int x = startRange; x <= endRange; x++)
            {
                if (strongNumber(x) == true) Console.Write($"{x} ");
            }
        }

        //method calculates strong number based on input
        public static bool strongNumber(int num)
        {
            int factorial;
            int sumFactorial = 0;

            for (int x = num; x > 0; x = x / 10)
            {
                factorial = 1;

                for (int y = 1; y <= x % 10; y++)
                {
                    factorial = factorial * y;
                }

                sumFactorial = sumFactorial + factorial;
            }

            return sumFactorial == num;
        }
    }
}
