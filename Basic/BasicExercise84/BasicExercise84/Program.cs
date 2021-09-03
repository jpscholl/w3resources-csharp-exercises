/*
//  Author: Jonathan Scholl
//  Date: 6/21/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 84
//  Description:  Write a C# Sharp program to get the index number of all lower case letters in a given string.
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicExercise84
{
    class Program
    {
        public static int[] searchLowerCase(string str)
        {
            return str.Select((x, i) => i).Where(i => char.IsLower(str[i])).ToArray();
        }
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Original text: "+ userInput);

            int[] lcIndex = searchLowerCase(userInput);
            Console.WriteLine("\nIndices of all lower case letters of the said string:");
            foreach (var item in lcIndex)
            {
                Console.Write(item.ToString() + " ");
            }

        }
    }
}
