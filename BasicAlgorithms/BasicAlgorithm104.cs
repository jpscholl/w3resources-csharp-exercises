/*
//  Author: Jonathan Scholl
//  Date: 10/5/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 104
//  Description: Write a C# Sharp program to create a new array from two give array of integers, each length 3.
*/
using System;

namespace BasicAlgorithm104
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayLength = 3;
            int[] userNumArray1 = storeArrayInput(arrayLength);
            int[] userNumArray2 = storeArrayInput(arrayLength);

            printArray(createNewArray(userNumArray1, userNumArray2));
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

        public static int[] createNewArray(int[] nums1, int[] nums2)
        {
            return new int[] { nums1[0], nums1[1], nums1[2], nums2[0], nums2[1], nums2[2] };

        }
    }
}
