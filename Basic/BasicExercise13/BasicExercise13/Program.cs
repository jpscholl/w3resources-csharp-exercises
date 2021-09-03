/*
//  Author: Jonathan Scholl
//  Date: 2/26/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 13
//  Description: Write a C# program that takes a number as input and then displays a 
//  rectangle of 3 columns wide and 5 rows tall using that digit.
*/
using System;

namespace BasicExercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:\n");
            int numInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}",numInput);
            Console.WriteLine("{0} {0}", numInput);
            Console.WriteLine("{0} {0}", numInput);
            Console.WriteLine("{0} {0}", numInput);
            Console.WriteLine("{0}{0}{0}", numInput);
        }
    }
}
