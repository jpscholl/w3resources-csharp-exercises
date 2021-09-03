/*
//  Author: Jonathan Scholl
//  Date: 5/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 72
//  Description: Write a C# Sharp program to check whether the average value of the 
//  elements of a given array of numbers is a whole number or not.
*/
using System;
using System.Linq;

namespace BasicExercise72
{
    class Program
    {
        //passes int array to method
        public static bool test(int[] arr_nums)
        {
            //returns true if the average of the numbers have no remainder, because whole numbers don't contain fractions/decimals
            return arr_nums.Average() % 1 == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input how big the array should be: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] userNumArray = new int[size];

            Console.WriteLine("\nPlease input " + userNumArray.Length + " numbers: ");

            for (int i = 0; i < userNumArray.Length; i++)
            {
                userNumArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nChecking if the average value of array is whole number: " + test(userNumArray));

            /*
            int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
            Console.WriteLine("Check the average value of the said array is a whole number or not: " + test(nums));

            int[] nums1 = { 2, 4, 2, 6, 4, 8 };
            Console.WriteLine("Check the average value of the said array is a whole number or not: " + test(nums1));
            */
        }
    }
}
