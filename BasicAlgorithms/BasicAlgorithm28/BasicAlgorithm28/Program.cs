/*
//  Author: Jonathan Scholl
//  Date: 8/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 28
//  Description: Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a"
*/
using System;

namespace BasicAlgorithm28
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable to close program
            char exit;
            do
            {
                //prompts user for input and stores input into variable
                Console.WriteLine("Please input a string: ");
                var userString = Console.ReadLine();

                Console.WriteLine("\nFirst appearance of a followed by another a: " + firstAFollowedByA(userString));

                //if you wish to close or start over
                Console.WriteLine("\npress x and enter to close program");

                exit = Convert.ToChar(Console.ReadLine());
            } while (exit != 'x' || exit != 'X');         
        }

        public static bool firstAFollowedByA(string str)
        {
            //counter to hold how many time conditions are met
            var counter = 0;
            //loops through entire string based on length
            for (var i = 0; i < str.Length - 1; i++)
            {
                //if the location in the string equals a, counter incremented
                if (str[i].Equals('a')) counter++;
                //if the 2 consecutive elements of the substring equals 'aa' and the counter is less than 2 return true;
                if (str.Substring(i, 2).Equals("aa") && counter < 2)
                    return true;
            }
            //if conditions aren't met returns false
            return false;
        }
    }
}
