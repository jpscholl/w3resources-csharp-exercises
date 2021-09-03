/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 5
//  Description: Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged
*/
using System;

namespace BasicAlgorithm5
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter a string and stores into string variable
            Console.WriteLine("Enter a string: ");
            string userString = Console.ReadLine();

            //pass string into method and output results
            Console.WriteLine(addIfString(userString));

        }
        //public string method that takes string as reference
        public static string addIfString(string input)
        {
            //condition: if the length of the user input is less than 2 AND the first two elements of string are equal to "if"
            if (input.Length > 2 && input.Substring(0, 2).Equals("if"))
            {
                //condition met will return same string
                return input;
            }
            //if false: add if to the beginning of string and return
            return "if " + input;
        }
    }
}
