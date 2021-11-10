/*
//  Author: Jonathan Scholl
//  Date: 11/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop10
//  Description: Write a program in C# Sharp to display the pattern like right angle triangle with a number
*/
using System;

namespace ForLoop10
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
                    Console.Write(y);
                    
                }
                Console.Write("\n");
            }
        }
    }
}
