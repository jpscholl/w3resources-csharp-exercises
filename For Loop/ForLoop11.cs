/*
//  Author: Jonathan Scholl
//  Date: 11/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop11
//  Description: Write a program in C# Sharp to make such a pattern like right angle triangle with a 
//  number which will repeat a number in a row
*/
using System;

namespace ForLoop11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number: ");
            int userInputerNumber = int.Parse(Console.ReadLine());

            for (int x = 1; x <= userInputerNumber; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(x);
                }
                Console.Write("\n");
            }
        }
    }
}
