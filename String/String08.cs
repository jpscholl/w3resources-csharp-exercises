/*
//  Author: Jonathan Scholl
//  Date: 9/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String8.cs
*/
using System;
using System.Collections.Generic;

namespace String08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //ask user for input and store input
            Console.Write("Input string: ");
            string userInput = Console.ReadLine();

            //variables
            char[] charArray = new char[userInput.Length];
            int copyCount = 0;

            //copy each letter into a char array
            userInput.CopyTo(0, charArray, 0, userInput.Length);

            //output
            Console.WriteLine($"\nFirst string: {userInput}");

            //output each char of char array
            Console.Write("\nSecond string: ");
            foreach (char c in charArray)
            {
                Console.Write(c);
                copyCount++;
            }

            Console.WriteLine($"\n\nCopied characters: {copyCount}");
        }
    }
}
