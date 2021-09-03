/*
//  Author: Jonathan Scholl
//  Date: 8/23/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 30
//  Description: Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
*/
using System;

namespace BasicAlgorithm30
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable to close program
            string exit = string.Empty;
            do
            {
                //prompts user for input and stores input into variables
                Console.WriteLine("Please input a string: ");
                var userString = Console.ReadLine();

                //output before and after function results
                Console.WriteLine("Before: " + userString);
                Console.WriteLine("After: " + abcd(userString));

                //if you wish to close or start over
                Console.WriteLine("press x and enter to close program");
                exit = Console.ReadLine();
            } while (exit != "x");
        }
        //public string function takes string parameter
        public static string abcd(string input)
        {
            //instantiate empty string variable
            var result = string.Empty;
            //loop through user input based on the length of the string
            for (var i = 0; i < input.Length; i++)
            {
                //adds substring to result variable every loop based on miminum location of 0 and maximum location of i(based on loop iteration) plus one.
                result += input.Substring(0, i + 1);
            }
            //outputs new results based on concatenated string
            return result;
        }
    }
}
