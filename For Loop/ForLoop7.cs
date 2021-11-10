/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 7
//  Description: Write a program in C# Sharp to display the multiplication table vertically from 1 to n. 
*/
using System;

namespace ForLoop7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Create multiplication table from 1 to: ");
            int userInputNum = int.Parse(Console.ReadLine());

            for (int x = 1; x <= userInputNum; x++)
            {
                Console.WriteLine();
                for (int y = 1; y <= userInputNum; y++)
                {
                    Console.Write($"{y} x {x} = {x * y}, ");
                }
            }
        }
    }
}
