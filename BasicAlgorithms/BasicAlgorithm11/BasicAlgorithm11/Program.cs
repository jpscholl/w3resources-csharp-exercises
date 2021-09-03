/*
//  Author: Jonathan Scholl
//  Date: 7/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 11
//  Description: Write a C# Sharp program to create a new string taking the first 3 characters of a given string and 
//  return the string with the 3 characters added at both the front and back. If the given string length is less than 3, 
//  use whatever characters are there
*/
using System;

namespace BasicAlgorithm11
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter string and store into string variable
            Console.WriteLine("Please enter a string: ");
            string userString = Console.ReadLine();

            //pass user string into method and output results
            Console.WriteLine("\nString before:");
            Console.WriteLine("\nString after: " + newString(userString));
            
        }

        public static string newString(string inputString)
        {
            if (inputString.Length < 3)
            {
                return inputString + inputString + inputString;
            } 
            else { 
            string str = inputString.Substring(0, 3);
            return str + inputString + str;
            }
        }
    } 
}
