/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 23
//  Description: Write a C# program to convert a given string into lowercase.
*/
using System;

namespace BasicExercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a given string
            string msg = "THIS WOULD BE IN ALL CAPITAL LETTERS IF NOT FOR THE BUILT-IN TOLOWER FUNCTION";

            //ToLower() automatically converts all letters to lower case
            Console.WriteLine(msg.ToLower());

        }
    }
}
