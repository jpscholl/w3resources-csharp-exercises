/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 37
//  Description: Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.
*/
using System;
using System.Linq;

namespace BasicAlgorithm37
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for a string, store into variable

            //pass string into function as parameter and output results
            
        }

        public static string createNewString(string input)
        {
            string newString = String.Empty;
            //looping through user input string and collecting 2 letters, then skipping 2 letters
            for (var i = 0; i < input.Length; i += 4 )
            {
                var c = i + 2;
                var n = 0;
                n += c > input.Length ? 1 : 2;
                newString += input.Substring(i, n);
            }
            //return new string
            return newString;
        }
    }
}
