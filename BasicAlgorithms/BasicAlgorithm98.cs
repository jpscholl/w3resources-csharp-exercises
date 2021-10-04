/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 98
//  Description: Write a C# Sharp program to check if a given array of integers and length 2, doesn't contains 15 or 20
*/
using System;
using System.Linq;

namespace BasicAlgorithm98
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integers");
            int[] numArray = new int[2];

            for (int x = 0; numArray.Length > x; x++)
            {
                numArray[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("[{0}]", string.Join(", ", numArray));

            Console.WriteLine("The array doesn't contain 15 or 20: " + checkNumArray(numArray));
        }

        public static bool checkNumArray(int[] numArray)
        {
            return numArray.Contains(15) != true && numArray.Contains(20) != true;
        }
    }
}
