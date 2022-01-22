/*
//  Author: Jonathan Scholl
//  Date: 1/22/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array size: ");
            int sizeArray = int.Parse(Console.ReadLine());

            //input elements inside array
            int[] numArray = new int[sizeArray];
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("Input element: ");
                numArray[i] = int.Parse(Console.ReadLine());
            }

            //output contents of the array
            Console.WriteLine("Array contents:");
            foreach (var num in numArray)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
