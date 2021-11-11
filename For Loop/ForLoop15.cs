/*
//  Author: Jonathan Scholl
//  Date: 11/11/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 15
//  Description: Write a C# Sharp program to calculate the factorial of a given number.
*/
using System;

namespace ForLoop15
{
    class Program
    {
        static void Main(string[] args)
        {
            //input number and store variables
            int inputNumber;
            int factorial = 1;
            Console.Write("Input number: ");
            inputNumber = int.Parse(Console.ReadLine());

            //calculate factorial with for loop
            for (int x = 1; x <= inputNumber; x++)
                factorial *= x;

            //output factorial
            Console.WriteLine(factorial);

        }
    }
}
