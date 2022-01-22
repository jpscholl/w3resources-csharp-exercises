/*
//  Author: Jonathan Scholl
//  Date: 1/22/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;

namespace Array4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of elements: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            int[] numArray = new int[sizeArray];

            for(int i = 0; i < sizeArray; i++)
            {
                Console.Write("Input element: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] numArray2 = new int[numArray.Length];

            Array.Copy(numArray, numArray2, sizeArray);
            foreach(int num in numArray2)
            { 
                Console.Write($"{num} ");
            }
        }
    }
}
