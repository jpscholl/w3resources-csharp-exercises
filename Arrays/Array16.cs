/*
//  Author: Jonathan Scholl
//  Date: 1/26/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Collections.Generic;

namespace Array16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumArray = CreateArray();

            Console.WriteLine($"\n Second largest element: {sorted(userNumArray)[userNumArray.Length - 2]}");

        }
        public static int[] sorted(int[] num)
        {
            List<int> array = new List<int>();

            for (int i = 0; i < num.Length; i++)
            {
                array.Add(num[i]);
            }
            array.Sort();
            return array.ToArray();
        }
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
