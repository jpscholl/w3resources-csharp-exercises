/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 5
//  Description: Write a program in C# Sharp to display the cube of the number up to given an integer.
*/
using System;

namespace ForLoop5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            cubedNumbers(userInputNumber);
        }
        public static void cubedNumbers(int num)
        {
            for (int x = 1; x <= num; x++)
            {
                Console.WriteLine($"Number {x} cubed is {Math.Pow(x, 3)}");
            }  
        }
    }
}
