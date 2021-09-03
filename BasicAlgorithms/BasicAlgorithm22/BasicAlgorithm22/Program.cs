/*
//  Author: Jonathan Scholl
//  Date: 8/6/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 22
//  Description: Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character
*/
using System;

namespace BasicAlgorithm22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string with z's: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("Contain between 2 and 4 z's: " + checkZ(userInput));
        }
        public static bool checkZ(string input)
        {
            int ctr = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'z')
                {
                    ctr++;
                }
            }

            return ctr > 1 && ctr < 4;
        }
    }
}
