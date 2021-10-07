/*
//  Author: Jonathan Scholl
//  Date: 10/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 110
//  Description: Write a C# Sharp program to compute the difference between the largest and smallest values 
//  in a given array of integers and length one or more.
*/
using System;

namespace BasicAlgorithm110
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();

            Console.WriteLine("\nOriginal Array: ");
            printArray(userArray);

            Console.Write("\nDifference: " + diffValues(userArray) + "\n");
            
        }
        //compute difference of largest and smallest
        public static int diffValues(int[] num)
        {
            int largeNum = 0, smallNum = 0;

            if (num.Length > 0)
            {
                smallNum = largeNum = num[0];
            }

            for (int x = 1; x < num.Length; x++)
            {
                smallNum = Math.Min(smallNum, num[x]);
                largeNum = Math.Max(largeNum, num[x]);
            }
            return largeNum - smallNum;
            
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
    }
}
