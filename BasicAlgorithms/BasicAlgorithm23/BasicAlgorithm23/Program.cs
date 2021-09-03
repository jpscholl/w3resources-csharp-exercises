/*
//  Author: Jonathan Scholl
//  Date: 8/16/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 23
//  Description: Write a C# Sharp program to check if two given non-negative integers have the same last digit
*/
using System;

namespace BasicAlgorithm23
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and store into variables
            Console.WriteLine("Please input two numbers:");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            //output message demonstrating the function that checks last digits
            Console.WriteLine("Numbers have the same last digit: " + sameLastDigit(userNum1, userNum2));

        }
        //bool function that takes the numbers the user input
        public static bool sameLastDigit(int x, int y)
        {
            //returns true if the absolute value of the modulus divided by 10 for each number is equal
            return Math.Abs(x % 10) == Math.Abs(y % 10);
        }
    }
}
