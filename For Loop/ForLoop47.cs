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
            int factorial;
            int sumFactorial = 0;

            for(int x = num; x > 0; x = x / 10)
            {
                factorial = 1;

                for(int y = 1; y <= x % 10; y++)
                {
                    factorial = factorial * y;
                }

                sumFactorial = sumFactorial + factorial;
            }

            return sumFactorial == num;
        }
    }
}
