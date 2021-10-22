/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 140
//  Description: Write a C# Sharp program to create a new array of given length using the odd 
//  numbers from a given array of positive integers.
*/
using System;

namespace BasicAlgorithm140
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            //randomly generated array
            int[] randoArray = generateRandomArray();
            Console.WriteLine($"\nRandom Array: {printArray(randoArray)}");

            //new arrays
            Console.WriteLine($"\nNew array from user array: {printArray(createNewArray(userArray))}");
            Console.WriteLine($"\nNew array from random array: {printArray(createNewArray(randoArray))}");

        }
        public static int[] createNewArray(int[] num)
        {
            Console.WriteLine("Size of new array: ");
            int size = int.Parse(Console.ReadLine());
            int pos = 0;
            int[] evenArray = new int[size];

            for (int x = 0; pos < size; x++)
            {
                if (num[x] % 2 != 0)
                {
                    evenArray[pos] = num[x];
                    pos++;
                }
            }

            return evenArray;

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
        //generate random test array
        private static int[] generateRandomArray()
        {
            var rand = new Random();
            int length = rand.Next(1, 10);

            int[] numArray = new int[length];

            for (int x = 0; x < numArray.Length; x++)
            {
                numArray[x] = rand.Next(0, 20);
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
