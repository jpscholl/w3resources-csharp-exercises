/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 94
//  Description: Write a C# Sharp program to find out the maximum element between the first or 
//  last element in a given array of integers ( length 4), replace all elements with maximum element. 
*/
using System;
using System.Linq;

namespace BasicAlgorithm94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Four elements needed");
            var arrayLength = 4;

            int[] userNumArray = storeArrayInput(arrayLength);

            printArray(userNumArray);

            userNumArray = maxElement(userNumArray);

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
            Console.WriteLine("[{0}]", string.Join(", ", numArray));
        }

        public static int[] maxElement(int[] numArray)
        {
            int max = numArray.Max();

            return new int[] {max, max, max, max };
        }
    }
}
