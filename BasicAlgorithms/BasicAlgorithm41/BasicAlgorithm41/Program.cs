/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 41
//  Description: Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.
*/

using System;

namespace BasicAlgorithm41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Contains 5 or is sum/difference of 5: " + checkFive(userNum1, userNum2));
        }

        public static bool checkFive(int num1, int num2)
        {
            //returns true if any of the following conditions are true
            return num1.Equals(5) || num2.Equals(5) || (num1 + num2).Equals(5) || (num1 - num2).Equals(5);
        }
    }
}
