/*
//  Author: Jonathan Scholl
//  Date: 11/19/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop33
//  Description: Write a C# Sharp program to display by Pascal's triangle.
*/
using System;

namespace ForLoop33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int userInputNum = int.Parse(Console.ReadLine());

            for (int x = 0; x <= userInputNum; x++)
            {   
                Console.WriteLine(Math.Pow(11, x));
            }
        }
    }
}
