/*
//  Author: Jonathan Scholl
//  Date: 8/23/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 29
//  Description: Write a C# Sharp program to create a new string made of every other character starting with the first from a given string. 
*/
using System;

namespace BasicAlgorithm29
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

                //outputs before and after to show that function works properly
                Console.WriteLine("Before: " + userString);
                Console.WriteLine("After: " + everyOtherLetter(userString));

                //if you wish to close or start over
                Console.WriteLine("press x and enter to close program");
                exit = Console.ReadLine();
            } while (exit != "x");
        }
        //public string function takes string as parameter
        public static string everyOtherLetter(string str)
        {
            //instantiates empty string variable
            var result = string.Empty;

            //for loop loops through every letter in the string based on length
            for (var i = 0; i < str.Length; i++)
            {
                //if the modulus of two equal to 0 then add letter to result
                if (i % 2 == 0) result += str[i];
            }
            //returns the new string based on the letters added
            return result;
        }
    }
}
