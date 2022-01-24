/*
//  Author: Jonathan Scholl
//  Date: 1/24/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Array7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First array size: ");
            int firstSize = Convert.ToInt32(Console.ReadLine());
            int[] Array1 = createNewArray(firstSize);

            Console.Write("Second array size: ");
            int secondSize = Convert.ToInt32(Console.ReadLine());
            int[] Array2 = createNewArray(secondSize);

            mergeArrays(Array1, Array2);
        }
        public static void mergeArrays(int[] arr1, int[] arr2)
        {
            List<int> mergedList = new List<int>();

            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine();
                Console.WriteLine("Arrays aren't same length");
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    mergedList.Add(arr1[i]);
                    mergedList.Add(arr2[i]);
                }
            }

            mergedList.Sort();

            foreach (var item in mergedList)
            {
                Console.Write($"{item} ");
            }
        }

        public static int[] createNewArray(int size)
        {
            int[] numArray= new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Input element: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numArray;
        }
    }
}
