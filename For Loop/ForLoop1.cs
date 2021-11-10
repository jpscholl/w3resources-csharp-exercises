/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 1
//  Description: Write a program in C# Sharp to display the first 10 natural numbers
*/
using System;

namespace ForLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 10; x++)
            {
                Console.Write(x + 1 + " ");
            }
        }
    }
}
