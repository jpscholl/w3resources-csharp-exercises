/*
//  Author: Jonathan Scholl
//  Date: 9/28/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 61
//  Description: Write a C# Sharp program to insert a given string into middle of the another given string of length 4
*/
using System;

namespace BasicAlgorithm61
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFourLetters = false;
            string fourLetterString = "";

            while (isFourLetters == false)
            {
                Console.Write("Input 4 letter string: ");
                fourLetterString = Console.ReadLine();

                if (fourLetterString.Length != 4)
                {
                    Console.WriteLine("Needs to be a four letter string. Try again!");
                    isFourLetters = false;
                }
                else
                {
                    isFourLetters = true;
                }
            }

            Console.Write("Input another string: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("New output: " + newString(fourLetterString, userInput));
        }

        public static string newString(string fourLetter, string input)
        {
            return fourLetter.Substring(0, 2) + input + fourLetter.Substring(2, 2);
        }
    }
}
