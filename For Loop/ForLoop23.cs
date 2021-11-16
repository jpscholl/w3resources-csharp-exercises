/*
//  Author: Jonathan Scholl
//  Date: 11/16/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop23
//  Description: Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....]
*/
using System;

namespace ForLoop23
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfTerms = 0.0;
            //variables, prompts, store input
            Console.Write("Input value of x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Input number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            //calculation
            for (int i = 1; i <= terms; i++)
            {
                double termCalculation = 1 + x + x * (x + 1) / (x + 1);
                sumOfTerms += (float)termCalculation;
            }

            Console.WriteLine($"Sum: {(float)sumOfTerms}");
        }
    }
}
