/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 8
//  Description:  Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string
*/
using System;

namespace BasicAlgorithm8
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input string and store string into variable
            Console.WriteLine("Please input string: ");
            string userInputString = Console.ReadLine();

            //pass user string to method and output results
            Console.WriteLine(FrontCharCopy(userInputString));
        }
        public static string FrontCharCopy(string userInput)
         {
            //returns a string that is the first two letters added together four times if the string is greater than 2. Otherwise output original string
            return userInput.Length > 2 
                ? userInput.Substring(0, 2) 
                + userInput.Substring(0, 2)
                + userInput.Substring(0, 2) 
                + userInput.Substring(0, 2) : userInput;
         }
    }
}
