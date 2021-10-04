/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 93
//  Description: Write a C# Sharp program to reverse a given array of integers and length 5.
*/
using System;
using System.Linq;

namespace BasicAlgorithm93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 5 integers");
            int[] userArray = new int[5];

            for (int x = 0; x < 5; x++)
            {
                userArray[x] = int.Parse(Console.ReadLine());
            }

            Console.Write("Original: ");
            Console.WriteLine("[{0}]", string.Join(", ", userArray));
            Console.Write("Reversed: ");
            Console.WriteLine("[{0}]", string.Join(", ", userArray.Reverse()));
        }
    }
}
