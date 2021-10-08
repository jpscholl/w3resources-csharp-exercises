/*
//  Author: Jonathan Scholl
//  Date: 10/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 113
//  Description: Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere
*/
using System;

namespace BasicAlgorithm113
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine("\nOriginal Array: ");
            printArray(userArray);

            Console.WriteLine("Array has consecutive 5's: " + checkArray(userArray));

        }
        public static bool checkArray(int[] numArray)
        {
            for (int x = 0; x < numArray.Length; x++)
            {
                if (numArray[x] == 5)
                {
                    if (numArray[x + 1] == 5)
                    {
                        return true;
                    }
                }
            }
            return false;
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
