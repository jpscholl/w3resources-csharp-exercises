/*
//  Author: Jonathan Scholl
//  Date: 10/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 106
//  Description: Write a C# Sharp program to create a new array length 3 from a given array (length at least 3) using the elements from the middle of the array
*/
using System;
using System.Linq;

namespace BasicAlgorithm106
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userNumArray = createNewArray();

            Console.WriteLine("\nOriginal array:");
            printArray(userNumArray);

            Console.WriteLine("\nNew array:");
            printArray(newArray(userNumArray));
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

        public static int[] newArray(int[] numArray)
        {
            return new int[] { numArray[numArray.Length / 2 - 1], numArray[numArray.Length / 2], 
                numArray[numArray.Length / 2 + 1] };
        }
    }
}
