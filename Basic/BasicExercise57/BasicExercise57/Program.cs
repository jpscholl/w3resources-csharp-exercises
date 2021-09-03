/*
//  Author: Jonathan Scholl
//  Date: 4/19/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 57
//  Description: Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers
*/
using System;

namespace BasicExercise57
{
    class Program
    {
        public static int calculateProduct(int[] inputArray)
        {
            int max = inputArray[0] * inputArray[1];
            for (int x = 1; x <= inputArray.Length - 2; x++)
            {
                max = Math.Max(max, inputArray[x] * inputArray[x + 1]);
            }
            return max;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(calculateProduct(new int[] { 1, -3, 4, -5, 1 }));
            Console.WriteLine(calculateProduct(new int[] { 1, 3, 4, 5, 2 }));
            Console.WriteLine(calculateProduct(new int[] { 1, 3, -4, 5, 2 }));
            Console.WriteLine(calculateProduct(new int[] { 1, 0, -4, 0, 2 }));
        }
    }
}
