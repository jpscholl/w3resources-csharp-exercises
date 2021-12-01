/*
//  Author: Jonathan Scholl
//  Date: 12/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop39
//  Description: Write a program in C# Sharp to find the number and sum of all integer between 100 and 200 which are divisible by 9
*/
using System;

namespace ForLoop39
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Numbers between 100 and 200 that are divisible by 9\n");

            for (int x = 100; x < 200; x++)
            {
                if (divisibleByNine(x))
                {
                    Console.Write($"{x} ");
                    sum += x;
                }
            }

            Console.WriteLine($"\nSum: {sum}");
        }

        public static bool divisibleByNine(int num)
        {
            return num % 9 == 0;
        }
    }
}
