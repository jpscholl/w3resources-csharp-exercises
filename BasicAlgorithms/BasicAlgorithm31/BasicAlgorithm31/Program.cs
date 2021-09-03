/*
//  Author: Jonathan Scholl
//  Date: 8/23/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 31
//  Description: Write a C# Sharp program to count a substring of length 2 appears in a given string 
//  and also as the last 2 characters of the string. Do not count the end substring
*/
using System;

namespace BasicAlgorithm31
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable to close program
            string exit = string.Empty;
            do
            {
                //prompts user for input and stores input into variables
                Console.WriteLine("Please input a string: ");
                var userString = Console.ReadLine();

                //outputs before and after function test
                Console.WriteLine("Before: " + userString);
                Console.WriteLine("After: " + test(userString));

                //if you wish to close or start over
                Console.WriteLine("press x and enter to close program");
                exit = Console.ReadLine();
            } while (exit != "x");
        }
        //public int function that takes string as parameter
        public static int test(string str)
        {
            //store the last two chars of the user input string
            var last_two_char = str.Substring(str.Length - 2);
            //counter variable
            var ctr = 0;
            //
            for (var i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2).Equals(last_two_char)) ctr++;
            }
            return ctr;
        }    
    }   
}
