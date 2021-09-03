/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 9
//  Description: Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more
*/
using System;

namespace BasicAlgorithm9
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input string and store string into variable
            Console.WriteLine("Please input string: ");
            string userInputStr = Console.ReadLine();

            //pass user string to method and output results
            Console.WriteLine(AddCharFrontAndBack(userInputStr));
        }
        //method to add last letter to front and end of string
        public static string AddCharFrontAndBack(string userInput)
        {
            //stores last letter of a string
            string lastLetter = userInput.Substring(userInput.Length - 1);
            //returns string based on last letter + original string + last letter
            return  lastLetter + userInput + lastLetter;
        }
    }
}
