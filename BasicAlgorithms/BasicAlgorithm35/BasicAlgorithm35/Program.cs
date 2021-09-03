/*
//  Author: Jonathan Scholl
//  Date: 8/23/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 35
//  Description: Write a C# Sharp program to compare two given strings and return the number of the 
//  positions where they contain the same length 2 substring.
*/
using System;

namespace BasicAlgorithm35
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and store into string
            Console.Write("Input string 1: ");
            string userString1 = Console.ReadLine();

            //prompt user for input and store into string
            Console.Write("Input string 2: ");
            string userString2 = Console.ReadLine();

            //output results of input string passed into sameSubString function
            Console.WriteLine(sameSubString(userString1, userString2));
        }
        //int function that takes two strings as params
        static public int sameSubString(string userString1, string userString2)
        {
            //counter to hold instances
            var ctr = 0;

            for (var i = 0; i < userString1.Length - 1; i++)
            {
                var firstString = userString1.Substring(i, 2);
                for (var x = 0; x < userString1.Length - 1; x++)
                {
                    var secondString = userString2.Substring(x, 2);
                    if (firstString.Equals(secondString))
                        ctr++;
                }
            }
            return ctr;
        }
    }
}
