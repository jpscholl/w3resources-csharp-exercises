/*
//  Author: Jonathan Scholl
//  Date: 8/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 27
//  Description: Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
*/
using System;

namespace BasicAlgorithm27
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input string and store into variable
            Console.WriteLine("Please input a string: ");
            var userString = Console.ReadLine();
            //outputs number of times aa's in a string
            Console.WriteLine("Number of aa's: " + countAA(userString));

        }
        //int function that takes string as reference
        static public int countAA(string input)
        {
            //counter for storing number of aa's
            int counter = 0;
            //for loop loops through the string based on length
            for (int i = 0; i < input.Length - 1; i++)
            {
                //if the location of the string and the following character are equal to "aa"...
                if (input.Substring(i, 2) == "aa")
                {
                    //...the counter is incremented if conditions met
                    counter++;
                }
            }
            //returns number of aa's based on the count
            return counter;

        }
    }
}
