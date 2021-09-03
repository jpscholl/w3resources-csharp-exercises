/*
//  Author: Jonathan Scholl
//  Date: 6/21/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 85
//  Description: Write a C# Sharp program to find the cumulative sum of an array of numbers.
*/
using System;

namespace BasicExercise85
{
    class Program
    {
        public static double[] sumOfArray(double[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }

            return nums;
        }
        static void Main(string[] args)
        {
            double[] numArray1 = { 1, 2, 3, 4, 5, 6 };
            double[] numArray2 = { 2, 4, 6, 8, 10};

            Console.WriteLine("Orginal Array elements: ");
            foreach (var item in numArray1)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine("\nCumulative sum of the said array elements:");
            double[] result = sumOfArray(numArray1);
            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine("\nOrginal Array elements: ");
            foreach (var item in numArray2)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine("\nCumulative sum of the said array elements:");
            double[] result2 = sumOfArray(numArray2);
            foreach (var item in result2)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();
        }
    }
}
