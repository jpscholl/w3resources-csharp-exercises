/*
//  Author: Jonathan Scholl
//  Date: 3/4/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 34
//  Description: Write a C# program to check if a string starts with a specified word
*/
using System;

namespace BasicExercise34
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.Write("Input a string : ");
            userInput = Console.ReadLine();
            Console.WriteLine((userInput.Length < 6 && userInput.Equals("Hello")) || (userInput.StartsWith("Hello") && userInput[5] == ' '));
        }
    }
}
