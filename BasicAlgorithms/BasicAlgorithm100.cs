/*
//  Author: Jonathan Scholl
//  Date: 10/5/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 100
//  Description: Write a C# Sharp program to check a given array of integers and return true 
//  if the array contains 10 or 20 twice. The length of the array will be 0, 1, or 2.
*/
using System;

namespace BasicAlgorithm100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            int[] userNumArray = storeArrayInput(arrayLength);

            printArray(userNumArray);

            Console.WriteLine("Array contains 10 or 20 twice: " + checkArray(userNumArray));

        }
        public static int[] storeArrayInput(int arrLength)
        {
            int[] storeInput = new int[arrLength];

            for (int x = 0; x < arrLength; x++)
            {
                Console.Write("Enter integer: ");
                storeInput[x] = int.Parse(Console.ReadLine());
            }

            return storeInput;
        }
        public static void printArray(int[] numArray)
        {
            Console.Write("\nContents of the array: ");
            Console.WriteLine("[{0}]", string.Join(", ", numArray));
        }


        public static bool checkArray(int[] numArray)
        {
            return numArray.Length == 2
                && ((numArray[0] == 10 && numArray[1] == 10)
                     || (numArray[0] == 20 && numArray[1] == 20));
        }
    }
}
