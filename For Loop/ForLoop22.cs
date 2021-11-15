/*
//  Author: Jonathan Scholl
//  Date: 11/15/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop22
//  Description: Write a program in C# Sharp to print the Floyd's Triangle. 
*/
using System;

namespace ForLoop22
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input and variables
            int p, q;
            Console.Write("Number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            //print triangle results
            Console.WriteLine("Floyd's Triangle");
            for (int x = 1; x <= rows; x++)
            {
                if (x % 2 == 0)
                { 
                    p = 1; 
                    q = 0; 
                }
                else
                { 
                    p = 0; 
                    q = 1; 
                }
                    for (int y = 1; y <= x; y++)
                if (y % 2 == 0)
                        Console.Write($"{p}");
                else
                        Console.Write($"{q}");
                Console.WriteLine();
                }
            }
        }
    }
