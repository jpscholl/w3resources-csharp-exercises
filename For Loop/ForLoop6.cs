/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 6
//  Description: Write a program in C# Sharp to display the multiplication table of a given integer.
*/
using System;

namespace ForLoop6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int userInputNum = int.Parse(Console.ReadLine());

            multiplicationTables(userInputNum);
        }
        public static void multiplicationTables(int num)
        {
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine($"{num} x {x} = {num * x}");
            }
        }
    }
}
