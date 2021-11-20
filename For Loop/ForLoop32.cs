/*
//  Author: Jonathan Scholl
//  Date: 11/19/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop32
//  Description: Write a C# Sharp program to determine whether a given number is prime or not.
*/
using System;

namespace ForLoop32
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input a number: ");
            int userInputNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{userInputNum} is a Prime number: {isPrimeNumber(userInputNum)}");
        }
        public static bool isPrimeNumber(int num)
        {
            int counter = 0;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                    break;
                }
            }
            return (counter == 0 && num != 1);
        }
    }
}
