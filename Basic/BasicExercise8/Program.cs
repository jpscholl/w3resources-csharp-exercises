/*
//  Author: Jonathan Scholl
//  Date: 2/17/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 8
//  Description: Write a C# Sharp program that takes a number as input and print its multiplication table
*/

using System;

namespace BasicExercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input number and store into variable
            Console.WriteLine("Enter number: ");
            int multiple = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Multiplication tables for " + multiple + " are:\n");
            //this loop outputs and calculates all multiplication tables up to 12
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(multiple + " x " + i + " = " + (multiple * i));
            }
        }
    }
}
