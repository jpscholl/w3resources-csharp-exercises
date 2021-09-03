/*
//  Author: Jonathan Scholl
//  Date: 3/5/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 39
//  Description: Write a C# program to find the largest and lowest values from three integer values.
//  Comments: I could've done it with nested ifs, but Math.Max and Math.Min function is much easier.
*/

using System;

namespace BasicExercise39
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //the higher number of num2 and num3 is then compared to num1, then outputs the highest value
            Console.WriteLine("Largest of three: "+ Math.Max(num1, Math.Max(num2, num3)));

            //the lower number of num2 and num3 is then compared to num1, then outputs the lowest value
            Console.WriteLine("Lowest of three: "+ Math.Min(num1, Math.Min(num2, num3)));

        }
    }
}
