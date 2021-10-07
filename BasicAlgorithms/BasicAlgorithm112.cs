/*
//  Author: Jonathan Scholl
//  Date: 10/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 112
//  Description: Write a C# Sharp program to compute the sum of the numbers in a given array except those 
//  numbers starting with 5 followed by at least one 6. Return 0 if the given array has no integer.
*/
using System;

namespace BasicAlgorithm112
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine("\nOriginal Array: ");
            printArray(userArray);

            Console.WriteLine("\nSum of array: " + sumArray(userArray));
        }
        public static int sumArray(int[] nums)
        {
            //variables
            int sum = 0;
            int inSection = 0;
            int flag = 0;

            //loop through sections and add total not flagged as 5 6 consecutively
            for (int i = 0; i < nums.Length; i++)
            {
                inSection = 0;
                if (nums[i] == 5)
                {
                    inSection = 0;
                    flag = 1;
                }
                if (inSection == 0 && nums[i] == 6)
                {
                    if (flag == 1)
                    {
                        sum = sum - 5;
                        inSection = 1;
                    }
                    flag = 0;
                }
                if (inSection == 0)
                {
                    sum += nums[i];
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
