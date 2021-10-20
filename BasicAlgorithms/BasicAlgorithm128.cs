/*
//  Author: Jonathan Scholl
//  Date: 10/19/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 128
//  Description: Write a C# Sharp program to create a new array taking the elements before 
//  the element value 5 from a given array of integers
*/
using System;

namespace BasicAlgorithm128
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            int[] userArray2 = test(userArray);

            Console.WriteLine("New array: " + printArray(userArray2));
        }
        static int[] test(int[] numbers)
        {
            int size = 0;
            int[] pre_ele_5;
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] == 5)
                {
                    size = x;
                    break;
                }
            }
            pre_ele_5 = new int[size];

            for (int x = 0; x < size; x++)
            {
                pre_ele_5[x] = numbers[x];
            }
            return pre_ele_5;
        }

        //create a unique array based on how many elements
        public static int[] createArray()
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
