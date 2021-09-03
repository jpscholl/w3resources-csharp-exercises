/*
//  Author: Jonathan Scholl
//  Date: 5/11/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 78
//  Description: Write a C# Sharp program to find sum of squares of elements of a given array of integers.
*/
using System;
using System.Linq;

namespace BasicExercise78
{
    class Program
    {
        public static int test(int[] nums)
        {
            return nums.Sum(n => n * n);
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            Console.WriteLine("Sum of squares of elements of the said array: " + test(nums));
            int[] nums1 = { -2, 0, 3, 4 };
            Console.WriteLine("Sum of squares of elements of the said array: " + test(nums1));

        }
    }
}
