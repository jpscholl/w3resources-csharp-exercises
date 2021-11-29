/*
//  Author: Jonathan Scholl
//  Date: 11/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop35
//  Description: Write a program in C# Sharp to display the first n terms of Fibonacci series
*/
using System;

namespace ForLoop35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input term number: ");
            int userTermInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fibonacci sequence for first {userTermInput} numbers: ");
            Fibonacci(userTermInput);
            Console.WriteLine();
        }

        public static void Fibonacci(int term)
        {
            int[] fibonacciArray = new int[term];

            for (int x = 0; x < term; x++)
            {
                if (x == 0 || x == 1)
                {
                    fibonacciArray[x] = x;
                    Console.Write($"{fibonacciArray[x]} ");
                }

                if (x > 1)
                {
                    fibonacciArray[x] = fibonacciArray[x - 1] + fibonacciArray[x - 2];
                    Console.Write($"{fibonacciArray[x]} ");
                } 
            }
        }
    }
}
