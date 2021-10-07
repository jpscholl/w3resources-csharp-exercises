/*
//  Author: Jonathan Scholl
//  Date: 10/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 108   
//  Description: Write a C# Sharp program to create a new array taking the first two elements from a 
//  given array. If the length of the given array is less than 2 then return the give array.
*/
using System;

namespace BasicAlgorithm108
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine("\nInput array: ");
            printArray(userArray);

            Console.WriteLine("\nNew array: ");
            printArray(newArray(userArray));
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

        public static int[] newArray(int[] num)
        {
            int[] newArray = new int[2];

            if (num.Length < 2)
            {
                newArray = num;
            }
            else
            {
                newArray[0] = num[0];
                newArray[1] = num[1];
            }

            return newArray;
        }
    }
}
