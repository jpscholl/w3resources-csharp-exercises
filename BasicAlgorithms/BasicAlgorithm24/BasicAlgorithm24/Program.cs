/*
//  Author: Jonathan Scholl
//  Date: 8/16/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 24
//  Description: Write a C# Sharp program to convert the last 3 characters of a given string in upper case. 
//  If the length of the string has less than 3 then uppercase all the characters
*/
using System;

namespace BasicAlgorithm24
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input string and store inside variable
            Console.WriteLine("Input a string: ");
            string userInput = Console.ReadLine();

            //output based on the userinput passed into the function
            Console.WriteLine(upperCase(userInput));

        }
        //string variable takes user input as a reference and outputs string
        public static string upperCase(string input)
        {
            //if the length of the string is less than 3, make all character uppercase
            //else, remove the last 3 characters based on length then add the last 3 letters converted to uppercase
            return input.Length < 3 ? input.ToUpper() : input.Remove(input.Length - 3) + input.Substring(input.Length - 3).ToUpper();
        }
    }
}
