/*
//  Author: Jonathan Scholl
//  Date: 10/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 5
//  Description: Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
*/
using System;

namespace ConditionalStatement5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine("You are allowed to vote");
            }
            else
            {
                Console.WriteLine("You are too young to vote");
            }
        }
    }
}
