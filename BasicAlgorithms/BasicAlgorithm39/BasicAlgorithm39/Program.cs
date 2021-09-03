/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 39
//  Description: Write a C# Sharp program to check if a triple is presents in an array of integers or not.
//  If a value appears three times in a row in an array it is called a triple.
*/
using System;
using System.Linq;

namespace BasicAlgorithm39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray1 = { 1, 1, 2, 2, 1 };
            int[] numArray2 = { 1, 1, 2, 1, 2, 3 };
            int[] numArray3 = { 1, 1, 1, 2, 2, 2, 1 };

            Console.WriteLine(test(numArray1));
            Console.WriteLine(test(numArray2));
            Console.WriteLine(test(numArray3));

        }

        public static bool test(int[] nums)
        {
            //variable to hold length of array minus 1?
            int arra_len = nums.Length - 1;

            //instantiate null int?
            int n = 0;

            //counter, if counter less than arra_len, increment
            for (int i = 0; i < arra_len; i++)
            {
                //n holds current array index
                n = nums[i];
                //if the held number equals the value of the next number and the next number returns true
                if (n == nums[i + 1] && n == nums[i + 2]) return true;
            }
            return false;
        }
    }
}
