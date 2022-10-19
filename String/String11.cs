/*
//  Author: Jonathan Scholl
//  Date: 10/18/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String11.cs
*/
using System;
using System.Collections.Generic;

namespace String11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input string and store information
            Console.Write("Please input a string: ");
            string userInputString = Console.ReadLine();

            //results
            builtInFunctions(userInputString);

        }
        static void builtInFunctions(string input)
        {
            
            //variables
            List<char> charList = new List<char>();

            //add to list
            foreach (char c in input)
            {
                //checks for whitespace/null and doesn't include that in the new list
                if (!Char.IsWhiteSpace(c))
                {
                    //adds char to the list
                    charList.Add(c);
                }           
            }

            //sort list in alphabetical order
            charList.Sort();

            //print each char in the list
            foreach (char c in charList)
            {
                Console.Write($"{c} ");
            }
        }
    }
}
