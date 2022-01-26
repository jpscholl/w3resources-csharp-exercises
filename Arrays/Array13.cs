/*
//  Author: Jonathan Scholl
//  Date: 1/24/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Array13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumArray = CreateArray();
            Console.WriteLine();

            foreach (var item in userNumArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in insertElement(userNumArray))
            {
                Console.WriteLine(item);
            }

        }
        public static int[] insertElement(int[] num)
        {
            Console.Write("Choose a number to insert: ");
            int insertNum = Convert.ToInt32(Console.ReadLine());

            //easy way to do it
            List<int> list = num.ToList();
            list.Add(insertNum);
            list.Sort();
            return list.ToArray();

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
