/*
//  Author: Jonathan Scholl
//  Date: 11/11/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop16
//  Description: Write a program in C# Sharp to display the n terms of even natural number and their sum.
*/
using System;

namespace ForLoop16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of terms: ");
            int userTerms = int.Parse(Console.ReadLine());

            for (int x = 2; x <= userTerms * 2; x += 2)
            {
                Console.Write($"{x} ");
            }
        }
    }
}
