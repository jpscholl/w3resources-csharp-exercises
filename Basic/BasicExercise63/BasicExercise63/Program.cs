/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 63
//  Description: Write a C# program to check if a given number present in an array of numbers.
*/
using System;
using System.Linq;

namespace BasicExercise63
{
    class Program
    {
        public static bool check_for_number(int[] userArray, int num)
        {
            return userArray.Contains(num);
        }
        public static void Main(string[] args)
        {
            int[] oddArray = { 1, 3, 5, 7, 9};
            int[] evenArray = { 2, 4, 6, 8, 10};

            Console.WriteLine("Please choose a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number is inside odd array: " + check_for_number(oddArray, userInput));
            Console.WriteLine("The number is inside even array: " + check_for_number(evenArray, userInput));
        }
    }
}
