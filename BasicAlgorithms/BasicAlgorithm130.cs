/*
//  Author: Jonathan Scholl
//  Date: 10/20/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 130
//  Description: Write a C# Sharp program to create a new array from a given array of integers shifting all zeros to left direction
*/
using System;
using System.Linq;

namespace BasicAlgorithm130
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            int[] shiftArray = createNewArray(userArray);
            
            Console.WriteLine("After shift: " + printArray(userArray));
        }
        public static int[] createNewArray(int[] num)
        {
            int position = 0;
            for (int x = 0; x < num.Length; x++)
            {
                if (num[x] == 0)
                {
                    num[x] = num[position];
                    num[position++] = 0;
                }
            }
            return num;
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
