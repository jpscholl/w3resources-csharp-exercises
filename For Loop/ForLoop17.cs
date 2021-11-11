/*
//  Author: Jonathan Scholl
//  Date: 11/11/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop17
//  Description: Write a program in C# Sharp to make such a pattern like a pyramid with a number which will repeat the number in the same row.
*/
using System;

namespace ForLoop17
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            int space, number;

            Console.Write("Input a number: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Building number pyramid");

            for (int x = 1; x <= userInputNumber; x++)
            {
                for (space = 1; space <= (userInputNumber - x); space++) // Loop For Space  
                    Console.Write(" ");
                for (number = 1; number <= x; number++) //increase the value  
                    Console.Write($"{y} ");
                y++;
                Console.WriteLine();
            }
        }
    }
}
