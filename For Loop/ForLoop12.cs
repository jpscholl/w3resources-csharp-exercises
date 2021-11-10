/*
//  Author: Jonathan Scholl
//  Date: 11/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop12
//  Description: Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
*/
using System;

namespace ForLoop12
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            Console.Write("Input integer: ");
            int userInputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= userInputNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", k);
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
