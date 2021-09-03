/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 6
//  Description: Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive.
*/
using System;

namespace BasicAlgorithm6
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter string and store into variable
            Console.WriteLine("Enter a string: ");
            string userString = Console.ReadLine();

            //prompt user to enter number for position
            Console.WriteLine("What position would you like to remove from string");
            int userPosition = Convert.ToInt32(Console.ReadLine());

            //outputs results after method is called
            Console.WriteLine(removeLetter(userString, userPosition));

        }
        //method to remove character based on user input that is passed into method
        public static string removeLetter(string input, int position)
        {
            //returns the string after remove function takes out on character based on position
            return input.Remove(position, 1);
        }
    }
}
