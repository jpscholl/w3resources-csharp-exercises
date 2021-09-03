/*
//  Author: Jonathan Scholl
//  Date: 2/17/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 7
//  Description: input two numbers and output the results of addtion, subtraction, multiplication, division, and modulus of the numbers
*/

using System;

namespace BasicExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input numbers and store them into variables
            Console.WriteLine("Test Data:");
            Console.WriteLine("Input first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            //output calculations of the input numbers
            Console.WriteLine("Output:");
            Console.WriteLine(x + " + " + y + " = " + (x + y));
            Console.WriteLine(x + " - " + y + " = " + (x - y));
            Console.WriteLine(x + " x " + y + " = " + (x * y));
            Console.WriteLine(x + " / " + y + " = " + (x / y));
            Console.WriteLine(x + " mod " + y + " = " + (x % y));
        }
    }
}
