/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 96
//  Description: Write a C# Sharp program to create a new array taking  the first and last elements 
//  of a given array of integers and length 1 or more. 
*/
using System;

namespace BasicAlgorithm96
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            int[] userNumArray = storeArrayInput(arrayLength);

            printArray(newArray(userNumArray));
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

        public static int[] newArray(int[] numArray)
        {
            return new int[] {numArray[0], numArray[numArray.Length - 1] };
        }
    }
}
