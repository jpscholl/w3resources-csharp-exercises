/*
//  Author: Jonathan Scholl
//  Date: 6/21/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 82
//  Description: Write a C# Sharp program to remove all characters which are non-letters from a given string.
//  Notes: First time working with Regex.Replace
*/
using System;
using System.Text.RegularExpressions;


namespace BasicExercise82
{
    class Program
    {
        //method used to remove non letter characters
        public static string removeNonLetters(string text)
        {
            return Regex.Replace(text, @"[^a-zA-Z]", "");
        }

        static void Main(string[] args)
        {
            //prompt for input
            Console.WriteLine("Input text: ");

            //store userinput in string
            string userInput = Console.ReadLine();

            //outputs original text
            Console.WriteLine("\nOriginal text: " + userInput);

            //passes text to removeNonLetters method and stores the returned value into a new variable
            string removedText = removeNonLetters(userInput);

            //outputs the results that were saved in removedText variable
            Console.WriteLine("\nAfter removing non letters: " + removedText);

        }
    }
}
