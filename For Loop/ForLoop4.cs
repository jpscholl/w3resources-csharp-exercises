/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 4
//  Description: Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average
*/
using System;
using System.Linq;

namespace ForLoop4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numInputArray = new int[10];

            Console.WriteLine("Input ten numbers\n");

            for (int x = 0; x < numInputArray.Length; x++)
            {
                Console.Write($"Input Number {x + 1}: ");
                numInputArray[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nSum of integers: {numInputArray.Sum()}");
            Console.WriteLine($"Average of integers: {numInputArray.Average()}");
        }
    }
}
