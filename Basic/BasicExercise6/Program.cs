/*
//  Author: Jonathan Scholl
//  Date: 2/17/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 6
//  Description: 
*/
using System;

namespace BasicExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user for input and store into int variables
            Console.WriteLine("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            //output results
            Console.WriteLine("Results:");
            //had to use concatenation to output the results in the format the exercise asked for
            Console.WriteLine(x + " x " + y + " x " + z + " = " + (x * y * z));

        }
    }
}