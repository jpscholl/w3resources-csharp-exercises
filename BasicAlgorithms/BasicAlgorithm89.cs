*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 89
//  Description: Write a C# Sharp program to check a given array of integers of length 1 or more 
//  and return true if 10 appears as either first or last element in the given array.
//
//  Notes: I mixed up exercise 89 and 88 so this is actually exercise 88
*/
using System;

namespace BasicAlgorithm89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            int[] userNumArray = storeArrayInput(arrayLength);

            printArray(userNumArray);

            Console.WriteLine("First or last element is 10: " + checkArray(userNumArray));
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

        public static bool checkArray(int[] intArray)
        {
            if (intArray.Length >= 1) return intArray[0] == 10 || intArray[intArray.Length - 1] == 10;
            else return false;
        }
    }
}
