/*
//  Author: Jonathan Scholl
//  Date: 10/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 111
//  Description: Write a C# Sharp program to compute the sum of values in a given array of 
//  integers except the number 17. Return 0 if the given array has no integer.
*/
using System;

namespace BasicAlgorithm111
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine("\nOriginal Array: ");
            printArray(userArray);

            Console.WriteLine("\nSum but ignoring number 17: " + sumArray(userArray) + "\n");

        }
        public static int sumArray(int[] num)
        {
            int sum = 0;

            foreach (int element in num)
            {
                if (element != 17)
                {
                    sum += element;
                }
            }
            return sum;
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
