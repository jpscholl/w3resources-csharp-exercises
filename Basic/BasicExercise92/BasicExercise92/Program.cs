/*
//  Author: Jonathan Scholl
//  Date: 7/12/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 92
//  Description: Write a C# Sharp program to find the next prime number of a given number. If the given number is a prime number, return the number
*/
using System;

namespace BasicExercise92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int numInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Original number: " + numInput);
            Console.WriteLine("Next prime number/Current prime number: " + FindPrimeNumber(numInput));
        }

        public static int FindPrimeNumber(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) { num++; i = 2; }
            }
            return num;
        }
    }
}
