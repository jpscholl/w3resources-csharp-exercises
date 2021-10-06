/*
//  Author: Jonathan Scholl
//  Date: 10/5/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 103
//  Description: Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.
*/
using System;

namespace BasicAlgorithm103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            int[] userNumArray = storeArrayInput(arrayLength);

            Console.WriteLine("");
            printArray(userNumArray);

            int[] numArray = newArray(userNumArray);

            Console.WriteLine("\nNew array from input array: ");
            printArray(numArray);
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
            foreach (var x in numArray)
            {
                Console.Write(x.ToString() + " ");
            }
        }
        public static int[] newArray(int[] numArray)
        {
            return new int[] { numArray[numArray.Length / 2 - 1], numArray[numArray.Length / 2] };
        }
    }
}
