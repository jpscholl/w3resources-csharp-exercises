/*
//  Author: Jonathan Scholl
//  Date: 10/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php DataTypes 10
//  Description: Write a C# Sharp program that takes two numbers as input and returns true 
//  or false when both numbers are even or odd.
*/
using System;

namespace DataTypes10
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int userNum1, userNum2;

            //prompt and store user input (2 ints)
            Console.WriteLine("Please input first int: ");
            userNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input second int: ");
            userNum2 = int.Parse(Console.ReadLine());

            //send ints as parameters to bool method
            //output results based on method
            Console.WriteLine($"Both ints are even or odd: {bothOddOrEven(userNum1, userNum2)}");

        }
        //check if both ints are both even or both odd
        //method to test both integers
        public static bool bothOddOrEven(int num1, int num2)
        {
            return num1 % 2 == num2 % 2;
        }
    }
}
