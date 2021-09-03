/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 67
//  Description: Write a C# Sharp program to create a coded string from a given string, using specified formula.
//  Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
*/
using System;

namespace BasicExercise67
{
    class Program
    {
        public static string replace_text(string str1)
        {
            return str1.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input stringy boi: ");
            string userString = Console.ReadLine();

            Console.WriteLine("\nString after replacement...");
            Console.WriteLine(replace_text(userString));
        }
    }
}
