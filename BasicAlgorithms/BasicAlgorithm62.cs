/*
//  Author: Jonathan Scholl
//  Date: 9/28/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 62
//  Description: Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two.
*/
using System;

namespace BasicAlgorithm62
{
    class Program
    {
        static void Main(string[] args)
        {
            bool twoLetters = false;
            string userInput = "";

            while (twoLetters == false)
            {
                Console.WriteLine("Input a string of at least 2 letters: ");
                userInput = Console.ReadLine();

                if (userInput.Length < 2)
                {
                    Console.WriteLine("You need at least 2 letters");
                    twoLetters = false;
                }
                else
                {
                    twoLetters = true;
                }
            }

            Console.WriteLine("Output: " + newString(userInput));
        }

        public static string newString(string str)
        {
            string lastTwo = str.Substring(str.Length - 2);
            return lastTwo + lastTwo + lastTwo;
        }
    }
}
