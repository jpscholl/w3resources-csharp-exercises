/*
//  Author: Jonathan Scholl
//  Date: 1/24/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Array6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of elements: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] numArray = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write("Input element: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            uniqueElements(numArray);
        }
        public static void uniqueElements(int[] num)
        {
            Console.WriteLine();

            List<int> unique = num.Distinct().ToList();

            foreach (var item in unique.Distinct())
            {
                Console.WriteLine(item);
            }

        }
    }
}
