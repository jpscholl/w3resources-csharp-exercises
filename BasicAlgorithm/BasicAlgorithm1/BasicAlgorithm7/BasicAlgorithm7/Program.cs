/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 7
//  Description: Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
*/
using System;

namespace BasicAlgorithm7
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter string and store into string variable
            Console.WriteLine("Enter a string: ");
            string userInputString = Console.ReadLine();

            //sends string to method and returns results
            Console.WriteLine(exchangeFirstLastChar(userInputString));
        }

        public static string exchangeFirstLastChar(string userInput)
        {
            //if user input length is greater than 1
            return userInput.Length > 1
                  //this is the last character                     
                ? userInput.Substring(userInput.Length - 1)
                //middle of the string minus off first and last letters
                + userInput.Substring(1, userInput.Length - 2)
                //first character of string
                + userInput.Substring(0, 1) : userInput;
            //then basically it adds them together in different order and returns string
        }
    }
}
