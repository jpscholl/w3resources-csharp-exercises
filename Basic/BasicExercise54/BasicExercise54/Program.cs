/*
//  Author: Jonathan Scholl
//  Date: 4/19/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 54
//  Description: Write a C# program to get the century from a year
//  Comment: I stop at a certain point to save time, but it's pretty much the same concept...just add more ranges
//  I wanted to do this a different way than the given solution. Feel like it was a little more viable and professional.
*/
using System;

namespace BasicExercise54
{
    class Program
    {
        public static void Main(string[] args)
        {
            //asks user for the year
            Console.WriteLine("Input a year: ");
            int userYear = Convert.ToInt32(Console.ReadLine());

            //basically for every 100 year range it outputs a message telling you which century it is
            switch (userYear)
            {
                case int x when (x < 1):
                    Console.WriteLine("Years start at 1");
                    break;
                //year 1-100 1st century
                case int x when (x <= 100):
                    Console.WriteLine("Year {0} is in the 1st Century", userYear);
                    break;
                //2nd century etc...
                case int x when (x >= 101 && x <= 200):
                    Console.WriteLine("Year {0} is in the 2nd Century", userYear);
                    break;
                case int x when (x >= 201 && x <= 300):
                    Console.WriteLine("Year {0} is in the 3rd Century", userYear);
                    break;
                case int x when (x >= 301 && x <= 400):
                    Console.WriteLine("Year {0} is in the 4th Century", userYear);
                    break;
                case int x when (x >= 401 && x <= 500):
                    Console.WriteLine("Year {0} is in the 5th Century", userYear);
                    break;
                case int x when (x >= 501 && x <= 600):
                    Console.WriteLine("Year {0} is in the 6th Century", userYear);
                    break;
                case int x when (x >= 601 && x <= 700):
                    Console.WriteLine("Year {0} is in the 7th Century", userYear);
                    break;
                case int x when (x >= 701 && x <= 800):
                    Console.WriteLine("Year {0} is in the 8th Century", userYear);
                    break;
                case int x when (x >= 801 && x <= 900):
                    Console.WriteLine("Year {0} is in the 9th Century", userYear);
                    break;
                case int x when (x >= 901 && x <= 1000):
                    Console.WriteLine("Year {0} is in the 10th Century", userYear);
                    break;
                //outputs if not in a range
                default:
                    Console.WriteLine("Range not added yet...but same concept");
                    break;
            }
        }
    }
}
