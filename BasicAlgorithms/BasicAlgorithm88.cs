/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 88
//  Description: Write a C# Sharp program to check a given array of integers of length 1 
//  or more and return true if 10 appears as either first or last element in the given array.
*/
using System;

namespace BasicAlgorithm88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many integers: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] numArray = storeArrayInput(arrayLength);

            printArray(numArray);

            Console.WriteLine("First and last element are same: " + checkArray(numArray)); 
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
            Console.WriteLine("\n[{0}]", string.Join(", ", numArray));
        }

        public static bool checkArray(int[] numArray)
        {
            if (numArray.Length >= 1)
            {
                return numArray[0] == numArray[numArray.Length - 1];
            }
            else
            {
                return false;
            }

        }
    }
}
