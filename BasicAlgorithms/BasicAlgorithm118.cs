/*
//  Author: Jonathan Scholl
//  Date: 10/12/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 118
//  Description: Write a C# Sharp program to check if a given array of integers contains no 3 or a 5
*/
using System;
using System.Linq;

namespace BasicAlgorithm118
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine("\nOriginal Array: ");
            printArray(userArray);

            Console.WriteLine("\nThe array doesn't contain 3 or 5: " + checkArray(userArray));
        }
        public static bool checkArray(int[] num)
        {
            if (num.Contains(5) && num.Contains(3))
            {
                return false;
            }
            else if (num.Contains(5) || num.Contains(3))
            {
                return true;
            }

            return true;

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
