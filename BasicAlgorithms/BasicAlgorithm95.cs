/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 95
//  Description: Write a C# Sharp program to create a new array containing the middle elements from the 
//  two given arrays of integers, each length 5.
*/
using System;
using System.Linq;

namespace BasicAlgorithm95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("5 Elements in each array\n");
            var arrayLength = 5;

            Console.WriteLine("First array: ");
            int[] userNumArray1 = storeArrayInput(arrayLength);
            Console.WriteLine("Second array: ");
            int[] userNumArray2 = storeArrayInput(arrayLength);

            var results = newArray(userNumArray1, userNumArray2);

            printArray(results);
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

        public static int[] newArray(int[] num1, int[] num2)
        { 
            return new int[] { num1[2], num2[2] };
        } 
    } 
}
