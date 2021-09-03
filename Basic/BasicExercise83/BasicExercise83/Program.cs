/*
//  Author: Jonathan Scholl
//  Date: 6/21/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 83
//  Description: Write a C# Sharp program to remove all vowels from a given string
*/
using System;
using System.Text.RegularExpressions;

namespace BasicExercise83
{
    class Program
    {
        //this method removes all vowels
        public static string removeVowels(string text)
        {
            return new Regex(@"[aeiouAEIOU]").Replace(text, "");
        }
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("Please insert text:");
            //store user input into string
            string textInput = Console.ReadLine();
            //pass input into method and stores changed string into a new variable
            string changedText = removeVowels(textInput);
            //outputs original text
            Console.WriteLine("\nText input before change: " + textInput);
            //outputs text after changes
            Console.WriteLine("\nText input after change: " + changedText);
        }
    }
}
