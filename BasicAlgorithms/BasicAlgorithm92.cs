/*
//  Author: Jonathan Scholl
//  Date: 10/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 92
//  Description: Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) 
//  in left direction and return the new array.
*/
using System;

namespace BasicAlgorithm92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Only four elements needed");
            var arrayLength = 4;

            int[] userNumArray = storeArrayInput(arrayLength);

            Console.Write("Before rotation: "); 
            printArray(userNumArray);

            userNumArray = rotateElementsLeft(userNumArray);
            Console.Write("After rotation: ");
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
        public static int[] rotateElementsLeft(int[] numArray)
        {
            int[] temp = new int[4];

            for (int x = 0; temp.Length - 1  > x; x++)
            {
                temp[x] = numArray[x + 1];
            }
            temp[3] = numArray[0];

            return temp;

            //easier solution from given solution
            //return new int[] { numArray[1], numArray[2], numArray[3], numArray[0] };
        }
    }
}
