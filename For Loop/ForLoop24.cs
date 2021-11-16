/*
//  Author: Jonathan Scholl
//  Date: 11/16/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop24
//  Description: Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....]
*/
using System;

namespace ForLoop24
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables, prompt user, and store input
            Console.Write("Input value of x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input number of terms: ");
            int numTerms = int.Parse(Console.ReadLine());
            int sumOfTerms = x;
            int pow = 3;

            //used this to test formula
            //Console.WriteLine(sumOfTerms - Math.Pow(sumOfTerms, pow) + Math.Pow(sumOfTerms, pow + 2) - Math.Pow(sumOfTerms, pow + 4) + Math.Pow(sumOfTerms, pow + 6));

            //loop for summation 
            for (int i = 1; i < numTerms; i++)
            {
                if (i % 2 == 1)
                {
                    sumOfTerms -= (int)Math.Pow(x, pow);
                }

                if (i % 2 == 0)
                {
                    sumOfTerms += (int)Math.Pow(x, pow);    
                }
                pow += 2;
            }

            //output results
            Console.WriteLine($"Sum of terms with {x} value: {sumOfTerms}");
        }
    }
}
