/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 19
//  Description: Write a C# program to compute the sum of two given integers, if two values 
//  are equal then return the triple of their sum.
*/
using System;

namespace BasicExercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine((x + y) * 3);
            } else
            {
                Console.WriteLine("Numbers are not equal");
            }
        }
    }
}
