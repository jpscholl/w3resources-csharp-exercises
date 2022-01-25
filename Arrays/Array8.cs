/*
//  Author: Jonathan Scholl
//  Date: 1/24/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Linq;

namespace Array8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = CreateArray();

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine($"{numArray[i]} is repeated: {howManyOfElement(numArray[i], numArray)} times");
            }
        }
        //shows count of particular value inside array
        public static int howManyOfElement(int num, int[] arr)
        {
            return arr.Count(x => x.Equals(num));
        }
        //method to created array with custom size and elements
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
