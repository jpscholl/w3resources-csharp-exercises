/*
//  Author: Jonathan Scholl
//  Date: 7/12/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 90
//  Description: Write a C# Sharp program to count number of ones and zeros in the binary representation of a given integer.
*/
using System;
using System.Linq;

namespace BasicExercise90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int userNumInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Original number: " + userNumInput);
            Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");
            Console.WriteLine(countBinaryNums(userNumInput));
        }

        public static string countBinaryNums(int n)
        {
            int ones = Convert.ToString(n, 2).Count(c => c == '1');
            int zeros = Convert.ToString(n, 2).Count(c => c == '0');

            return "Number of ones: " + ones + "\nNumber of zeros: " + zeros;
        }

    }
}
