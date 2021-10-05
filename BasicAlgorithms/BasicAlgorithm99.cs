/*
//  Author: Jonathan Scholl
//  Date: 10/5/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 99
//  Description: Write a C# Sharp program to create a new array of integers and length 1 or more. 
//  The length of the new array will be double length of the given array and all the elements are 1 
//  except the first element which is equal to the given array.
*/
using System;

namespace BasicAlgorithm99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements: ");
            var arrayLength = int.Parse(Console.ReadLine());

            int[] userNumArray = storeArrayInput(arrayLength);

            Console.Write("Original array: ");
            printArray(userNumArray);
            Console.Write("New array:");
            printArray(newString(userNumArray));

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

        public static int[] newString(int[] numArray)
        {
            int doubleLength = numArray.Length * 2;
            int[] doubleNumArray = new int[doubleLength];

            doubleNumArray[0] = numArray[0];
            return doubleNumArray;

        }
    }
}
