/*
//  Author: Jonathan Scholl
//  Date: 12/6/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop41.cs
//  Description:  Write a program in C# Sharp to convert a decimal number into binary without using an array. 
*/
using System;
using System.Linq;

namespace ForLoop41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(userInputNumber, 2);

            Console.WriteLine($"{userInputNumber} in binary: {binary}");

        }
    }
}
