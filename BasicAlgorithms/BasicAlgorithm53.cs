/*
//  Author: Jonathan Scholl
//  Date: 9/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 53
//  Description: Write a C# Sharp program to check two given integers, each in the range 10..99. 
//  Return true if a digit appears in both numbers, such as the 3 in 13 and 33
*/
using System;

namespace BasicAlgorithm53
{
    class Program
    {
        public static bool checkDigit(int x, int y)
        {
            return x / 10 == y / 10 || x / 10 == y % 10 || x % 10 == y / 10 || x % 10 == y % 10;
        }

        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Input two integers");
            Console.Write("Integer 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Integer 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 10 && num2 >= 10 && num1 <= 99 && num2 <= 99)
            {
                Console.WriteLine(checkDigit(num1, num2));
            }
            else
            {
                Console.WriteLine("Not all numbers in range");
            }
        }
  
