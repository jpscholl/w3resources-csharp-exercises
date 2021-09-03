/*
//  Author: Jonathan Scholl
//  Date: 5/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 74
//  Description: Write a C# Sharp program to check the length of a given string is odd or even. 
//  Return 'Odd length' if the string length is odd otherwise 'Even length'
*/
using System;

namespace BasicExercise74
{
    class Program
    {
        //created function to check odd and even string length
        public static string odd_even_length_check (string str)
        {
            //if the length of the string has a remainder of 0...
            if (str.Length % 2 == 0)
            {
                //return if 0
                return "even length";
            }
            else
            {
                //return if not 0
                return "odd length";
            }
        }
        public static void Main(string[] args)
        {
            //ask user to input text then store into string variable
            Console.WriteLine("Enter text: ");
            string userInput = Console.ReadLine();

            //output message to test the function based on the users input text
            Console.WriteLine("The text string is " + (odd_even_length_check(userInput)) + ".");
        }
    }
}
