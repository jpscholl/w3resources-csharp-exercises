/*
//  Author: Jonathan Scholl
//  Date: 10/5/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 105
//  Description: Write a C# Sharp program to create a new array swapping the first and last 
//  elements of a given array of integers and length will be least 1.
*/
using System;

namespace BasicAlgorithm105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            int[] userNumArray = storeArrayInput(arrayLength);

            Console.WriteLine("Before");
            printArray(userNumArray);

            Console.WriteLine("\nAfter");
            newArray(userNumArray);
            printArray(userNumArray);

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
            int temp = numArray[0];

            if (numArray.Length >= 1)
            {
                numArray[0] = numArray[numArray.Length - 1];
                numArray[numArray.Length - 1] = temp;
            }

            return numArray;
        }
    }
}
