/*
//  Author: Jonathan Scholl
//  Date: 10/25/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php 2
//  Description: Write a C# Sharp program that takes a number and a width also a number, as input and 
//  then displays a triangle of that width, using that number.
*/
using System;
using System.Linq;

namespace DataTypes2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int userNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int x = width; x >= 0; x--)
            {
                for (int y = x - 1; y >= 0; y--)
                {
                    Console.Write(userNum);
                }
                Console.WriteLine();

            }

            for (int i = 0; i < width; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat(userNum, width - i)));
            }
        }
    }
}
