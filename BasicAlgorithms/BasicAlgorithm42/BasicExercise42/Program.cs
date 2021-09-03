/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 42
//  Description: Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13
*/
using System;

namespace BasicExercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a non negative integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiple of 13: " + checkMultiple13(userNum));
        }

        public static bool checkMultiple13(int num)
        {
            if (num > 0)
            { 
                return num % 13 == 0 || num % 13 == 1;
            }
            else
               return false;          
        }
    }
}
