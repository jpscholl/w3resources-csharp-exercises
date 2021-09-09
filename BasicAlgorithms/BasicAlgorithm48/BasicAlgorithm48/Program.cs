/*
//  Author: Jonathan Scholl
//  Date: 9/9/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 48
//  Description: Write a C# Sharp program to check if y is greater than x, and z is 
//  greater than y from three given integers x,y,z.
*/
using System;

namespace BasicAlgorithm48
{
    class Program
    {
        static void Main(string[] args)
        {
            // explains the program to the user
            Console.WriteLine("Check to see if y is greater than x " +
                "and z is greater than y based on user input.\n");

            // prompt for input and store 3 integer variables
            Console.WriteLine("Input x integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input y integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input z integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // output the results after method completes
            Console.WriteLine("Y is greater than x and z is greater than y: " + checkIfGreaterThan(num1, num2, num3));

        }
        // bool method that takes three int parameters
        public static bool checkIfGreaterThan(int x, int y, int z)
        {
            // returns true/false based on
            // 1) y being greater than x and
            // 2) z being greater than y
            return x < y && y < z;
        }
    }
}
