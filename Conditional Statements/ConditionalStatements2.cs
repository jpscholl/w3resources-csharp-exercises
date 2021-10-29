/*
//  Author: Jonathan Scholl
//  Date: 10/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 2
//  Description: Write a C# Sharp program to check whether a given number is even or odd
*/
using System;

namespace ConditionalStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input integer: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber % 2 == 0)
            {
                Console.WriteLine($"{userInputNumber} is an even integer");
            }

            if (userInputNumber % 2 == 1)
            {
                Console.WriteLine($"{userInputNumber} is an odd integer");
            }
        }
    }
}
