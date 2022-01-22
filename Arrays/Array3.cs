/*
//  Author: Jonathan Scholl
//  Date: 1/22/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Linq;

namespace Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of elements: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            int[] numArray = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write("Input element: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            //method 1
            int sum = 0;

            foreach(int num in numArray)
            {
                sum += num;
            }

            Console.WriteLine($"Sum of numbers: {sum}");

            //method 2
            Console.WriteLine();

            Console.WriteLine("Sum of numbers: " + numArray.Sum());
        }
    }
}
