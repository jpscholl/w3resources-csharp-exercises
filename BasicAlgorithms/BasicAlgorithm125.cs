/*
//  Author: Jonathan Scholl
//  Date: 10/19/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 125
//  Description: Write a C# Sharp program to check a given array of integers and return true if 
//  the specified number of same elements appears at the start and end of the given array.
*/
using System;
using System.Linq;

namespace BasicAlgorithm125
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            Console.WriteLine("Meet conditions: " + checkArray(userArray));
        }
        public static bool checkArray(int[] num)
        {   
            int arra_size = num.Length;
            Console.WriteLine("How many elements to check: ");
            int length = int.Parse(Console.ReadLine());

            for (int x = 0; x < length; x++)
            {
                if (num[x] != num[arra_size - length + x])
                {
                    return false;
                }
            }
            return true;  
        }

        //create a unique array based on how many elements
        public static int[] createNewArray()
        {
            Console.Write("How long the array should be: ");
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
