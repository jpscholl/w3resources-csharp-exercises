/*
//  Author: Jonathan Scholl
//  Date: 8/25/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 46
//  Description: Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". 
//  If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" 
//  and ends with "B" return "FizzBuzz". In other cases return the original string. 
*/
using System;

namespace BasicAlgorithm46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();

            Console.WriteLine(fizzBuzz(userInput));
        }

        public static string fizzBuzz(string input)
        {
            if (input.StartsWith("F") && input.EndsWith("B"))
                return "FizzBuzz";
            else if (input.StartsWith("F"))
                return "Fizz";
            else if (input.EndsWith(""))
                return "Buzz";
            else
                return input;
        }
    }
}
