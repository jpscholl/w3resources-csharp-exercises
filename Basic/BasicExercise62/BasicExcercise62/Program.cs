/*
//  Author: Jonathan Scholl
//  Date: 4/26/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 62
//  Description:  Write a C# program to reverse the strings contained in each pair of matching parentheses
//  in a given string and also remove the parentheses within the given string
*/
using System;
using System.Linq;
using System.Collections;

namespace BasicExcercise62
{
    class Program
    {
        public static string reverse_string_remove_parentheses(string str)
        {
            int lid = str.LastIndexOf('(');
            if (lid == -1)
            {
                return str;
            }
            else
            {
                int rid = str.IndexOf(')', lid);

                return reverse_string_remove_parentheses(
                      str.Substring(0, lid)
                    + new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
                    + str.Substring(rid + 1)
                );
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input text for string: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("\nOriginal input: " + userInput);
            Console.WriteLine("\nAfter removal: " + reverse_string_remove_parentheses(userInput));


        }
    }
}
