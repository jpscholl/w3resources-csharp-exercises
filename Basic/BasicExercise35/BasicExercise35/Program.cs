/*
//  Author: Jonathan Scholl
//  Date: 3/4/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 
//  Description: Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
*/

using System;

namespace BasicExercise35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number(<100): ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput second number(>200): ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nFirst number less than 100 and second greater than 200: ");
            Console.WriteLine(num1 < 100 && num2 > 200);
        }
    }
}
