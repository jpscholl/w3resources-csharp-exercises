/*
//  Author: Jonathan Scholl
//  Date: 6/23/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 86
//  Description: Write a C# Sharp program to get the number of letters and digits in a given string
*/
using System;
using System.Linq;

namespace BasicExercise86
{
    class Program
    {
        //counts numbers and letters
        public static string countLettersDigis(string text)
        {
            //count for letters
            int ctr_letters = text.Count(char.IsLetter);
            //count for numbers
            int ctr_digits = text.Count(char.IsDigit);
            //returns the counts for each
            return "Number of letters: " + ctr_letters + "  Number of digits: " + ctr_digits;
        }
        static void Main(string[] args)
        {
            //prompts user to input text then stores text into variable
            Console.WriteLine("Insert text: ");
            string userInput = Console.ReadLine();

            //shows original text and then shows returned value after text is passed into method
            Console.WriteLine("\nOG text: " + userInput);
            Console.WriteLine(countLettersDigis(userInput));

        }
    }
}
