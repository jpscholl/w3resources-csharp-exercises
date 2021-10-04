/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 91
//  Description: Write a C# Sharp program to compute the sum of the elements of an given array of integers.
*/
using System;
using System.Linq;

namespace BasicAlgorithm91
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            int[] userNumArray = storeArrayInput(arrayLength);

            printArray(userNumArray);

            sumOfArray(userNumArray);
        }

        public static int[] storeArrayInput(int arrLength)
        {
            int[] storeInput = new int[arrLength];

            for (int x = 0; x < arrLength; x++)
            {
                storeInput[x] = int.Parse(Console.ReadLine());
            }

            return storeInput;
        }

        public static void printArray(int[] numArray)
        {
            Console.Write("\nContents of the array: ");
            Console.WriteLine("[{0}]", string.Join(", ", numArray));
        }
        public static void sumOfArray(int[] numArray)
        {
            int sum = numArray.Sum();
            Console.Write("Sum of the array: " + sum);
        }
    }
}
