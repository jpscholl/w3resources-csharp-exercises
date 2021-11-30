/*
//  Author: Jonathan Scholl
//  Date: 11/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop39
//  Description: Write a program in C# Sharp to check whether a number is a palindrome or not.
*/
using System;

namespace ForLoop38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            string userInputNumber = Console.ReadLine();

            Console.WriteLine($"Number is palindrome: {palindromeNumber(userInputNumber)}");
        }

        public static bool palindromeNumber(string num)
        {
            string reverseArray = string.Empty;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                reverseArray += num[i];
            }

            return reverseArray == num;
        }
    }
}
