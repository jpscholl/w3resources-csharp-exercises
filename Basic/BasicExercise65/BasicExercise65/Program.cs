/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 65
//  Description: Write a C# Sharp program to multiply all of elements of a given array of numbers by the array length.
*/
using System;
using System.Linq;

namespace BasicExercise65
{
    class Program
    {
        public static int[] multiply_array_number_length(int[] nums)
        {
            var arr_len = nums.Length;
            return nums.Select(el => el * arr_len).ToArray();
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] new_nums = multiply_array_number_length(nums);
            Array.ForEach(new_nums, Console.WriteLine);
        }
    }
}
