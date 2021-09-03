/*
//  Author: Jonathan Scholl
//  Date: 2/17/2021
//  https://www.w3resource.com/csharp-exercises/basic/index.php
*/
using System;

namespace BasiceExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables for input
            int temp;

            //prompts user for input and stores in variables;
            Console.WriteLine("Input first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            //outputs user input
            Console.WriteLine("Test Data");
            Console.WriteLine("First number: " + x);
            Console.WriteLine("Second number: " + y);

            //swap numbers
            temp = x;
            x = y;
            y = temp;

            //output swaps
            Console.WriteLine("After Swap");
            Console.WriteLine("First number: " + x);
            Console.WriteLine("Second number: " + y);

        }
    }
}
