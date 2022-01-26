/*
//  Author: Jonathan Scholl
//  Date: 1/26/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Collections.Generic;

namespace Array17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumArray = CreateArray();

            Console.WriteLine(secondSmallest(userNumArray));
        }
        public static int secondSmallest(int[] num)
        {
            List<int> numArray = new List<int>();

            for (int i = 0; i < num.Length; i++)
            {
                numArray.Add(num[i]);
            }

            numArray.Sort();

            return numArray[1];
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
