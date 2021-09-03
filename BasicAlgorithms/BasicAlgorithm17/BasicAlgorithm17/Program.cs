/*
//  Author: Jonathan Scholl
//  Date: 7/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 17
//  Description: Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. 
//  If it appears return a string without 'yt' otherwise return the original string
*/
using System;

namespace BasicAlgorithm17
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user to enter string and stores it
            Console.WriteLine("Please input string: ");
            string userInput = Console.ReadLine();

            Console.WriteLine(checkString(userInput));

        }
        public static string checkString(string input)
        {
            if (input.Substring(1, 2).Equals("yt"))
            {
                return input.Remove(1,2);
            }
            else
            {
                return input;
            }
        }
    }
}
//does the same thing except one line
//return str.Substring(1, 2).Equals("yt") ? str.Remove(1, 2) : str;
