/*
//  Author: Jonathan Scholl
//  Date: 9/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php
//  Description: Write a C# Sharp program to find the larger from two given integers. 
//  However if the two integers have the same remainder when divided by 7, then the return the smaller 
//  integer. If the two integers are the same, return 0
//  Note: I had the right idea but I was a little off with if statments and didn't consider ternary operator
*/

using System;
using System.Collections.Generic;

namespace BasicAlgorithm52
{
    class Program
    {
        public static int testInteger(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            if (x % 7 == y % 7)
            {
                return (x < y) ? x : y;
            }
            return (x > y) ? x: y;
            
        }

        static void Main(string[] args)
        {
            //variables
            int num1, num2;

            //prompt user and store input
            Console.WriteLine("Input two integers: ");
            num1 = int.Parse(Console.ReadLine().Trim());
            num2 = int.Parse(Console.ReadLine().Trim());

            //test function with input
            Console.WriteLine("Returned: " + testInteger(num1, num2));
        }
    }
}
