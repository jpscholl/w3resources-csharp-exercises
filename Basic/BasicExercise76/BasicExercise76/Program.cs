/*
//  Author: Jonathan Scholl
//  Date: 5/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 76
//  Description: Write a C# Sharp program to get the ASCII value of a given character.
*/
using System;

namespace BasicExercise76
{
    class Program
    {
        public static int test(char ch)
        {
            //since method is int, it returns an int...casting isn't neccessary
            return (int)ch;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a character: ");
            char userChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("ASCII value of " + userChar + ": " + test(userChar));
        }
    }
}
