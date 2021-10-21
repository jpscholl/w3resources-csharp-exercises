/*
//  Author: Jonathan Scholl
//  Date: 10/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 133
//  Description: Write a C# Sharp program to check if the value of each element is equal or greater than the value 
//  of previous element of a given array of integers.
*/
using System;

namespace BasicAlgorithm133
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            Console.WriteLine($"\nMeets conditions: {checkArray(userArray)}");

        }
        public static bool checkArray(int[] num)
        {
            for (int x = 1; x < num.Length; x++)
            {
                if (num[x] < num[x - 1]) return false;
            }
            return true;
        }

        //create a unique array based on how many elements
        public static int[] initializeArray()
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
        public static string printArray(int[] numArray)
        {
            return "{ " + String.Join(", ", numArray) + " }";
        }
    }
}
