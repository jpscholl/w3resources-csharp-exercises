/*
//  Author: Jonathan Scholl
//  Date: 2/26/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 16
//  Description: Write a C# program to create a new string from a given string where 
//  the first and last characters will change their positions
//  Comment: Not great with string manipulating, so I'm just studying answers
*/
using System;

namespace BasicExercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
        }

        public static string first_last(string str)
        {
            //checks to see if string is longer than 1 letter
            return str.Length > 1
                ? str.Substring(str.Length - 1)             //last letter in string
                + str.Substring(1, str.Length - 2)          //everything in between first and last letters
                + str.Substring(0, 1) : str;                //first letter in string

            //basically breaks it down into pieces and adds it back together in different order to produce
            //desired output
        }
    }
}
