/*
//  Author: Jonathan Scholl
//  Date: 10/20/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 131
//  Description: Write a C# Sharp program to create a new array after replacing all the values 5 
//  with 0 shifting all zeros to right direction
*/
using System;

namespace BasicAlgorithm131
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            int[] sortedArray = createNewArray(userArray);
            Console.WriteLine($"New Array: {printArray(sortedArray)}");
        }
        public static int[] createNewArray(int[] num)
        {
            int size = num.Length;
            int index = 0;
            int[] arra = new int[size];

            for (int x = 0; x < size; x++)
            {
                if (num[x] != 5)
                {
                    arra[index++] = num[x];
                }
            }

            return arra;
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
