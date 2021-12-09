/*
//  Author: Jonathan Scholl
//  Date: 12/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop52
//  Description: Write a program in C# Sharp to find the Sum of GP series.
*/
using System;

namespace ForLoop52
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store input
            Console.Write("Input first number: ");
            double startNumber = int.Parse(Console.ReadLine());
            Console.Write("Input number of terms: ");
            int inputTerms = int.Parse(Console.ReadLine());
            Console.Write("Input the common ratio: ");
            double inputRatio = double.Parse(Console.ReadLine());

            //output results
            calculateGPSeries(startNumber, inputTerms, inputRatio);

        }
        //method for calculation and output
        public static void calculateGPSeries(double start, int terms, double ratio)
        {
            //variables
            int sumOfRange = 0;
            int tnTerms = 0;

            Console.WriteLine("\nGP terms: ");
            for (int x = 0; x <= terms; x++)
            {
                Console.Write($"{start} ");
                sumOfRange += (int)start; 
                start *= ratio;
            }

            Console.WriteLine($"\n\ntn term: {tnTerms}");

            Console.WriteLine($"\nSum of terms: {sumOfRange}");
        }
    }
}
