/*
//  Author: Jonathan Scholl
//  Date: 11/15/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 19
//  Description: Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........
*/
using System;

namespace ForLoop18
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables, prompt, and collect user input
            double sumOfTerms = 0.0;
            Console.Write("Input number of terms: ");
            int userInputTerms = int.Parse(Console.ReadLine());
            Console.Write("\n");

            //for loop for summation of terms and printing out each term
            for (int x = 1; x <= userInputTerms; x++)
            {
                Console.Write($"1/{x} + ");
                sumOfTerms += 1 / (float)x;
            }

            //output the total sum of the terms
            Console.Write($"\nSum of Series up to {userInputTerms} terms : {sumOfTerms} \n");
        }
    }
}
