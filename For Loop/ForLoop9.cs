/*
//  Author: Jonathan Scholl
//  Date: 11/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 9
//  Description:  Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
*/
using System;

namespace ForLoop9
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store input
            Console.WriteLine("Input number of rows: ");
            int userInputRows = int.Parse(Console.ReadLine());
            Console.WriteLine();    //spacing

            for (int x = 1; x <= userInputRows; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
