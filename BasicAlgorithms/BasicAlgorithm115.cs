/*
//  Author: Jonathan Scholl
//  Date: 10/12/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 115
//  Description: Write a C# Sharp program to check if the sum of all 5's in the array exactly 15 in a given array of integers. 
*/
using System;

namespace BasicAlgorithm115
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine("\nOriginal Array: ");
            printArray(userArray);

            Console.WriteLine("\nSum of all the 5's is 15: " + checkSumArray(userArray));
        }
        public static bool checkSumArray(int[] num)
        {
            int sumFives = 0;

            for (int x = 0; x < num.Length; x++)
            {
                if (num[x] == 5)
                {
                    sumFives += num[x];
                }
            }

            return sumFives == 15;
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
