/*
//  Author: Jonathan Scholl
//  Date: 11/16/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 25
//  Description: Write a program in C# Sharp to display the n terms of square natural number and their sum.
*/
using System;

namespace ForLoop25
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate variables, prompt user, store input
            int sumOfTerms = 0;
            Console.Write("Input number of terms: ");
            int userTermInput = int.Parse(Console.ReadLine());

            //loop for summation of terms and calculate based on formula
            Console.Write($"Square natural {userTermInput} terms: ");
            for (int i = 1; i <= userTermInput; i++)
            {
                Console.Write($"{i * i} ");
                sumOfTerms += i * i;
            }

            //output results
            Console.WriteLine($"\nSum of {userTermInput} terms: {sumOfTerms}");
        }
    }
}
