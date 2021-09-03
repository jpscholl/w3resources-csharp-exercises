/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 36
//  Description: Write a C# Sharp program to create a new string from a give string where a specified 
//  character have been removed except starting and ending position of the given string
*/
using System;
using System.Linq;

namespace BasicAlgorithm36
{
    class Program
    {
        static void Main(string[] args)
        {

            //prompt users, store variables, pass variables to function, output results
            Console.Write("Please input string: ");
            string userInput = Console.ReadLine();

            Console.Write("What letter would you like removed: ");
            string userLetter = Console.ReadLine();

            Console.WriteLine(removeLetter(userInput, userLetter));
        }

        public static string removeLetter(string input, string letter)
        {
            //checking the length of the string (-2 to ignore the last letter)
            for (int i = input.Length - 2; i > 0; i-- )
            {
                if(input[i] == letter[0])
                {
                    input = input.Remove(i, 1);
                }
            }
            return input;
        }
    }
}
