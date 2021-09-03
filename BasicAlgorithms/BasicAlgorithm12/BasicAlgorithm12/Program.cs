/*
//  Author: Jonathan Scholl
//  Date: 7/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 12
//  Description: Write a C# Sharp program to check if a given string starts with 'C#' or not
*/
using System;

namespace BasicAlgorithm12
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter test input and store data
            Console.WriteLine("Please enter a string: ");
            string userInput = Console.ReadLine();
            //pass user input into function
            Console.WriteLine(startWithCSharp(userInput));

        }
        //bool function reurning true or false depending on conditions met
        public static bool startWithCSharp(string input)
        {
            // returns true if either:
            // 1) length of input less than 3 and equals "C#"
            // 2) length of input is more than 2 and starts with C#
            return (input.Length < 3 && input.Equals("C#") || input.Length > 2 && input.StartsWith("C#"));
        }
    }
}
//different way according to the solution on the website
//(input.StartsWith("C#") && input[2] == ' '));