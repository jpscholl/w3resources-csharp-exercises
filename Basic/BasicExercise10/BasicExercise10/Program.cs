/*
//  Author: Jonathan Scholl
//  Date: 2/26/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 10
//  Description:  Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z
*/
using System;

namespace BasicExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int firstCalc = (x + y) * z;
            int secondCalc = (x * y) + (y * z);

            Console.Write("\nResult of specified numbers {0}, {1}, and {2} " +
                "\n(x + y) · z = {3} " +
                "\n(x · y) + (y · z) = {4}\n\n",
        x, y, z, ((x + y) * z), (x * y + y * z));

        }
    }
}
