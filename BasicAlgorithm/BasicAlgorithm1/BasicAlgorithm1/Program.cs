/*
//  Author: Jonathan Scholl
//  Date: 7/13/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 1
//  Description: Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
*/
using System;

namespace BasicAlgorithm1
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter a number then store into int variable
            Console.Write("Please enter num1: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            //prompt user to enter a number then store into int variable
            Console.Write("Please enter num2: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            //output the results before and after calculations
            Console.WriteLine("\nNumbers before calculation: " + userNum1 + " and " + userNum2 + "\n");
            //outputs the returned sum of the integers passed into the function
            Console.WriteLine(sumOfIntTimes3(userNum1, userNum2));
        }

        public static int sumOfIntTimes3(int x, int y)
        {
            Console.WriteLine("After calculation: ");
            //ternary operator that checks to see if numbers are the same value. If true: adds values together and multiplies by 3. If false: adds both values together
            //the sum is returned
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
