/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 3
//  Description: Write a program in C# Sharp to display n terms of natural number and their sum.
*/
using System;

namespace ForLoop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int sum = 0;
            int userInputNumber;

            //prompt and store user input
            Console.Write("Input a number: ");
            userInputNumber = int.Parse(Console.ReadLine());

            //inital message ouput
            Console.Write($"First {userInputNumber} natural numbers are: ");

            //loops through numbers up to the user's input number and accumulates each number into sum variable
            for (int x = 1; x <= userInputNumber; x++)
            {
                Console.Write($"{x} ");
                sum += x;
            }

            //output sum
            Console.WriteLine($"\nSum of natural numbers up to {userInputNumber}: {sum}");

        }
    }
}
