/*
//  Author: Jonathan Scholl
//  Date: 12/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop47
//  Description: Write a C# Sharp program to check whether a number is a Strong Number or not
*/
using System;

namespace ForLoop47
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user and store number
            Console.Write("Input number: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            //output results of input sent to method
            Console.WriteLine($"{userInputNumber} is a strong number: {strongNumber(userInputNumber)}");
        }
        //method calculates strong number based on input
        public static bool strongNumber(int num)
        {
            int factorial = 0;
            int y = 0;
            for (int x = 1; x <= num; x++)
            {
                factorial = x * (x - y);
                y++;
            }

            return factorial == num;
        }
    }
