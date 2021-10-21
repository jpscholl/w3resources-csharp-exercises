/*
//  Author: Jonathan Scholl
//  Date: 10/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 134
//  Description: Write a C# Sharp program to check a given array (length will be at least 2) of integers and 
//  return true if there are two values 15, 15 next to each other.
*/
using System;

namespace BasicAlgorithm134
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");
            Console.WriteLine($"\nMeets conditions: {checkArray(userArray)}");

            //randomly generated array
            int[] randoArray = generateRandomArray();
            Console.WriteLine($"\nRandom Array: {printArray(randoArray)}");
            Console.WriteLine($"\nMeets conditions: {checkArray(randoArray)}");

        }
        public static bool checkArray(int[] num)
        {
            if (num.Length >= 2)
            {
                for (int x = 0; x < num.Length - 1; x++)
                {
                    if (num[x] == 15 && num[x + 1] == 15) return true;
                }
            }
            return false;
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
