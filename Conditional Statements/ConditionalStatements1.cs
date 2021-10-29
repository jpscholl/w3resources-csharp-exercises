/*
//  Author: Jonathan Scholl
//  Date: 10/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statements 1
//  Description: Write a C# Sharp program to accept two integers and check whether they are equal or not.
*/
using System;

namespace ConditionalStatements1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first integer: ");
            int firstUserNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input second integer: ");
            int secondUserNum = int.Parse(Console.ReadLine());

            if (firstUserNum == secondUserNum)
            {
                Console.WriteLine($"{firstUserNum} and {secondUserNum} are equal");
            }
            else
            {
                Console.WriteLine($"{firstUserNum} and {secondUserNum} are not equal");
            }
        }
    }
}
