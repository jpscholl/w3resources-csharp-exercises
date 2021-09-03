/*
//  Author: Jonathan Scholl
//  Date: 2/17/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 9
//  Description: Write a C# Sharp program that takes four numbers as input to calculate and print the average
*/
using System;

namespace BasicExercise9
{
    class Program
    {
        static void Main(string[] args)
        {

            //prompts user to input 4 numbers and stores them into integer variables
            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter fourth number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",num1, num2, num3, num4, result);

        }
    }
}
