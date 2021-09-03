/*
//  Author: Jonathan Scholl
//  Date: 2/26/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 12
//  Description: Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), 
//  and then four times in the next row, with no separation. You should do it two times: Use Console.Write and then use {0}
*/
using System;

namespace BasicExercise12
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Please input a number: \n");
            int numInput = Convert.ToInt32(Console.ReadLine());

            // Part A: "num num num num" using Write
            Console.Write(numInput);
            Console.Write(" ");
            Console.Write(numInput);
            Console.Write(" ");
            Console.Write(numInput);
            Console.Write(" ");
            Console.Write(numInput);
            Console.WriteLine();

            // Part B: "numnumnumnum" using Write
            Console.Write(numInput);
            Console.Write(numInput);
            Console.Write(numInput);
            Console.WriteLine(numInput);
            Console.WriteLine();

            Console.Write("{0} {0} {0} {0}\n", numInput);
            Console.Write("{0}{0}{0}{0}\n", numInput);

        }
    }
}
