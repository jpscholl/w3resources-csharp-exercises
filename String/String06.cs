/*
//  Author: Jonathan Scholl
//  Date: 9/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String6.cs
*/
using System;

namespace String6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables for storing word count
            int firstStringCount = 0;
            int secondStringCount = 0;

            //ask for user input and store into string variables
            Console.Write("Input first string: ");
            string firstString = Console.ReadLine();
            Console.Write("Input second string: ");
            string secondString = Console.ReadLine();

            //count each letter of each string
            foreach (char c in firstString)
            {
                firstStringCount++;
            }
            foreach (char c in secondString)
            {
                secondStringCount++;
            }

            //compare the counts and output if the length is same
            if (firstStringCount == secondStringCount)
            {
                Console.WriteLine("\nBoth strings are the same length");
            }
            else
            {
                Console.WriteLine("\nBoth strings aren't the same length");
            }

            //checks if both strings are the same and outputs based on results
            if (firstString == secondString)
            {
                Console.WriteLine("\nAnd both strings are the same");
            }
            else
            {
                Console.WriteLine("\nAnd both strings aren't the same");
            }

        }
    }
}
