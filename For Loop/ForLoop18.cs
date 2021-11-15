/*
//  Author: Jonathan Scholl
//  Date: 11/15/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 18
//  Description: Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........
*/
using System;

namespace ForLoop18
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables, prompts, and store user input
            double sumOfTerms = 0.0;
            double t, d;

            Console.Write("Input the value of x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input number of terms: ");
            int userInputTerms = int.Parse(Console.ReadLine());

            sumOfTerms = 1; t = 1;

            //loop for summation of terms
            for (int i = 1; i < userInputTerms; i++)
            {
                d = (2 * i) * (2 * i - 1);
                t = -t * x * x / d;
                sumOfTerms += t;
            }
            //output results
            Console.WriteLine($"\nSum of {userInputTerms} of value {x}: {sumOfTerms}");
        }
    }
}
