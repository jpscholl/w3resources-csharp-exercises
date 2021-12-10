/*
//  Author: Jonathan Scholl
//  Date: 12/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop57
//  Description: Write a program in C# Sharp to print a string in reverse order
*/
using System;

namespace ForLoop57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string userInput = Console.ReadLine();

            Console.Write($"Word {userInput} in reverse: ");
            reverseString(userInput);
            Console.WriteLine();
        }

        public static void reverseString(string input)
        {
            char[] splitString = input.ToCharArray();

            for (int x = input.Length - 1; x >= 0; x--)
            {
                Console.Write(splitString[x]);
            }

        }
    }
}
