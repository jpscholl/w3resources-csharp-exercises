/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 90
//  Description: Write a C# Sharp program to check two given arrays of integers of length 1 or 
//  more and return true if they have the same first element or they have the same last element.
*/
using System;

namespace BasicAlgorithm90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            Console.Write("First array: ");
            int[] userNumArray1 = storeArrayInput(arrayLength);
            Console.Write("Second array: ");
            int[] userNumArray2 = storeArrayInput(arrayLength);

            Console.Write("First array: ");
            printArray(userNumArray1);
            Console.Write("Second array: ");
            printArray(userNumArray2);

            Console.WriteLine("Arrays have same first or last element: " + checkArray(userNumArray1, userNumArray2));
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
        public static bool checkArray(int[] num1, int[] num2)
        {
            return num1[0] == num2[0] || num1[num1.Length - 1] == num2[num2.Length - 1];
        }
    }
}
