/*
//  Author: Jonathan Scholl
//  Date: 11/18/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop26   
//  Description: Write a program in C# Sharp to find the sum of the series 1 + 11 + 111 + 1111 + .. n terms.
*/
using System;

namespace ForLoop26.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables, prompt for input, and store input
            Console.Write("Input number of terms: ");
            int userInputTerms = int.Parse(Console.ReadLine());

            //output of method based on input
            Console.WriteLine($"Sum: {SumOfSeries(userInputTerms)}");

        }
        //calculates sum based on formula in description
        public static int SumOfSeries(int terms)
        {
            string sumAsString = string.Empty;

            for (int i = 1; i <= terms; i++)
            {
                sumAsString += i;
            }

            return Convert.ToInt32(sumAsString);
        }
    }
}
