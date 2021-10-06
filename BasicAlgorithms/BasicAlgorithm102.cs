/*
//  Author: Jonathan Scholl
//  Date: 10/5/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 102
//  Description:  Write a C# Sharp program to compute the sum of the two given arrays of integers, 
//  length 3 and find the array which has the largest sum.
*/
using System;

namespace BasicAlgorithm102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            int[] userNumArray1 = storeArrayInput(arrayLength);
            int[] userNumArray2 = storeArrayInput(arrayLength);

            printArray(userNumArray1);
            printArray(userNumArray2);

            Console.WriteLine("\nLargest array: ");
            largestArraySum(userNumArray1, userNumArray2, arrayLength);
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

        public static int sumOfArray(int[] num)
        {
            int sum = 0;
            foreach(int element in num)
            {
                sum += element;
            }
            return sum;
        }

        public static void largestArraySum(int[] num1, int[] num2, int arrLength)
        {
            int[] largestArray = new int[arrLength];

            if (sumOfArray(num1) > sumOfArray(num2))
            {
                largestArray = num1;
            }
            else
            {
                largestArray = num2;
            }

            printArray(largestArray);
        }
    }
}
