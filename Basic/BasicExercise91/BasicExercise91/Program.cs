/*
//  Author: Jonathan Scholl
//  Date: 7/12/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 91
//  Description: Write a C# Sharp program to remove all the values except integer values from a given array of mixed values.
*/
using System;
using System.Linq;

namespace BasicExercise91
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] mixedArray = new object[6];
            mixedArray[0] = 25;
            mixedArray[1] = "Anna";
            mixedArray[2] = false;
            mixedArray[3] = System.DateTime.Now;
            mixedArray[4] = -112;
            mixedArray[5] = -34.67;
            Console.WriteLine("Original array elements:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.Write(mixedArray[i] + " ");
            }
            int[] new_nums = RemoveNonIntegers(mixedArray);
            Console.WriteLine("\n\nAfter removing all the values except integer values from the said array of mixed values:");
            for (int i = 0; i < new_nums.Length; i++)
            {
                Console.Write(new_nums[i] + " ");
            }
        }
        public static int[] RemoveNonIntegers(object[] nums)
        {
            return nums.OfType<int>().ToArray();
        }
    }
}
