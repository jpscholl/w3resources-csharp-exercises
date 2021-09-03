/*
//  Author: Jonathan Scholl
//  Date: 3/5/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 38
//  Description: Write a C# program to get a new string of two characters from a given string. 
//  The first and second character of the given string must be "P" and "H", so PHP will be "PH"
*/
using System;

namespace BasicExercise38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input string");

            string userInput = Console.ReadLine();
            var result = "";

            if (userInput.Length >= 1 && userInput[0] == 'P' || userInput[0] == 'p')
                result += userInput[0];
            if (userInput.Length >= 2 && userInput[1] == 'H' || userInput[1] == 'h')
                result += userInput[1];
            Console.WriteLine(result);
        }
    }
}
