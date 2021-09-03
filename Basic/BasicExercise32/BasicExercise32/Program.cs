/*
//  Author: Jonathan Scholl
//  Date: 3/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 32
//  Description: Write a C# program to create a new string of four copies, taking last four characters from a given string. 
//  If the length of the given string is less than 4 return the original one
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input string: ");
            string userInput = Console.ReadLine();

            //determines if string is less than 4 characters
            if (userInput.Length > 4)
            {
                Console.WriteLine(userInput.Substring(userInput.Length - 4) +
                    userInput.Substring(userInput.Length - 4) +                 //last four characters of string based on length of string
                    userInput.Substring(userInput.Length - 4) +                 //copied four times
                    userInput.Substring(userInput.Length - 4));
            }
            else
                Console.WriteLine(userInput);                                   //outputs original if less than 4
        }
    }
}
