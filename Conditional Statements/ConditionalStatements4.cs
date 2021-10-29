/*
//  Author: Jonathan Scholl
//  Date: 10/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 4
//  Description:  Write a C# Sharp program to find whether a given year is a leap year or not
*/
using System;

namespace ConditionalStatement4
{
    class Program
    {
        static void Main(string[] args)
        {
            //collect and store integer from user input
            Console.WriteLine("Enter a year: ");
            int inputYear = int.Parse(Console.ReadLine());

            //calculate whether the year is a leap year
            //output whether or not year is leap year based on calculations
            if (inputYear % 400 == 0)
            {
                Console.WriteLine($"{inputYear} is a leap year");
            }
            else if (inputYear % 100 == 0)
            {
                Console.WriteLine($"{inputYear} is not a leap year");
            }
            else if (inputYear % 4 == 0)
            {
                Console.WriteLine($"{inputYear} is a leap year");
            }
            else
            {
                Console.WriteLine($"{inputYear} is not a leap year");
            }
        }
    }
}
