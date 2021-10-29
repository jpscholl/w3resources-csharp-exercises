/*
//  Author: Jonathan Scholl
//  Date: 10/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statements 3
//  Description: Write a C# Sharp program to check whether a given number is positive or negative.
*/
using System;

namespace ConditionalStatements3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber > 0)
            {
                Console.WriteLine($"{userInputNumber} is a positive number");
            } 
            else if (userInputNumber == 0)
            {
                Console.WriteLine($"{userInputNumber} is a neither negative or positive number");
            } 
            else
            {
                Console.WriteLine($"{userInputNumber} is a negative number");
            }
        }
    }
}
