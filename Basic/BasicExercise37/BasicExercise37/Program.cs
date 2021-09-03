/*
//  Author: Jonathan Scholl
//  Date: 3/5/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 37
//  Description:  Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP"
*/
using System;

namespace BasicExercise37
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and store input into string variable
            Console.WriteLine("Please input string: ");
            string stringInput = Console.ReadLine();

            Console.WriteLine((stringInput.Substring(1, 2).Equals("HP") ? stringInput.Remove(1, 2) : stringInput));

        }
    }
}
