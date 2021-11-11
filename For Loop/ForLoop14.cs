/*
//  Author: Jonathan Scholl
//  Date: 11/11/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 14
//  Description: Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
//  Notes: Found the answer while playing around with different problem
*/
using System;

namespace ForLoop14
{
    class Program
    {
        static void Main(string[] args)
        {
            int Space, asterisks, userInputNumber;
            int k = 1;

            Console.Write("Input Number: ");
            userInputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Print paramid");
            for (int i = 1; i <= userInputNumber; i++) // Total number of layer for pyramid  
            {
                for (Space = 1; Space <= (userInputNumber - i); Space++) // Loop For Space  
                    Console.Write(" ");
                for (asterisks = 1; asterisks <= i; asterisks++) //Loop prints asterisk per line
                    Console.Write($"* ");
                k++;
                Console.WriteLine();   //Creates new row
            }
        }
    }
}
