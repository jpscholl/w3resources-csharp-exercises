/*
//  Author: Jonathan Scholl
//  Date: 3/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 31
//  Description: Write a C# program to multiply corresponding elements of two arrays of integers.
*/
using System;

namespace BasicExercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = {1, 2, 3, 4, 5 };
            int[] arrayTwo = {2, 2, 6, 8, 10 };

            //added this after looking at solution
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arrayOne));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", arrayTwo));
            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

            //came up with this myself
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.WriteLine(arrayOne[i] * arrayTwo[i]);
            }
        }
    }
}
