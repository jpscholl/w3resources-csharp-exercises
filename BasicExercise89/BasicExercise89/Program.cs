/*
//  Author: Jonathan Scholl
//  Date: 7/12/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 89
//  Description: Write a C# Sharp program to count positive and negative numbers in a given array of integers
*/
using System;
using System.Linq;

namespace BasicExercise89
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] inputNumArray = new int[10];
            for (int i = 0; i < inputNumArray.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                inputNumArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(countNegativePositive(inputNumArray));

        }

        public static string countNegativePositive(int[] nums)
        {
            var pos = nums.Where(n => n > 0);
            var neg = nums.Where(n => n < 0);
            Console.WriteLine("\nOut of the " + nums.Length + " numbers: ");
            return "\nNumber of positive numbers: " + pos.Count() + "\nNumber of negative numbers: " + neg.Count();
        }
    }
}
