/*
//  Author: Jonathan Scholl
//  Date: 10/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 109
//  Description: Write a C# Sharp program to count even number of elements in a given array of integers
*/
using System;

namespace BasicAlgorithm109
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();

            Console.Write("Original input array: ");
            printArray(userArray);

            Console.WriteLine("Even elements inside array: " + countEven(userArray));
        }

        //create a unique array based on how many elements
        public static int[] createNewArray()
        {
            Console.Write("How many elements: ");
            var length = int.Parse(Console.ReadLine());

            int[] numArray = new int[length];

            for (int x = 0; x < numArray.Length; x++)
            {
                numArray[x] = int.Parse(Console.ReadLine());
            }

            return numArray;
        }

        //print the contents of an array
        public static void printArray(int[] numArray)
        {
            foreach (var item in numArray)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");
        }

        public static int countEven(int[] num)
        {
            int evenCount = 0;

            foreach (int item in num)
            {
                if (item % 2 == 0)
                {
                    evenCount++;
                }
            }
            return evenCount;
        }
    }
}
