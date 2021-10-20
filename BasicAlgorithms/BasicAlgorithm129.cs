/*
//  Author: Jonathan Scholl
//  Date: 10/20/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 129
//  Description: Write a C# Sharp program to create a new array taking the elements after 
//  the element value 5 from a given array of integers.
*/
using System;
using System.Linq;

namespace BasicAlgorithm129
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            int[] newArray = createNewArray(userArray);
            Console.WriteLine($"New array: {printArray(newArray)}");

        }
        public static int[] createNewArray(int[] num)
        {
            int index = Array.IndexOf(num, 5) + 1;
            return num.Skip(index).ToArray();

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
