/*
//  Author: Jonathan Scholl
//  Date: 1/24/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Linq;

namespace Array10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = CreateArray();

            //create arrays based on user created array
            int[] evenArray = createEvenArray(userArray);
            int[] oddArray = createOddArray(userArray);

            //print contents of arrays
            Console.WriteLine("\nEven: ");
            foreach (int i in evenArray)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nOdd: ");
            foreach (int i in oddArray)
            {
                Console.Write($"{i} ");
            }
        }
        //separates even numbers into new array
        public static int[] createEvenArray(int[] arr)
        {
            var results = arr.Where(i => i % 2 == 0);
            return results.ToArray();
        }
        //separate odd numbers into new array
        public static int[] createOddArray(int[] arr)
        {
            var results = arr.Where(i => i % 2 == 1);
            return results.ToArray();
        }
        //create new int array with custom size and elements
        public static int[] CreateArray()
        {
            Console.Write("Array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Input element: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numArray;
        }
    }
}
