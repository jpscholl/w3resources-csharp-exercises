/*
//  Author: Jonathan Scholl
//  Date: 4/19/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 56
//  Description: Write a C# program to check if a given string is a palindrome or not
*/
using System;

namespace BasicExercise56
{
    class Program
    {
        //method to check if string is palindrom
        static public bool isPalindrome(string inputString)
        {
            //stores individual letters of string into char array
            char[] x = inputString.ToCharArray();
            //array reverse method to reverse the letters of the string
            Array.Reverse(x);
            //stores into new string and checks to see if equals original string. If it does outputs true and string is palindrome
            return new string(x).Equals(inputString);
        }
        static void Main()
        {
            //prompts user to input string and stores into string variable
            Console.WriteLine("Enter string to check if it's a palindrome: ");
            string userInput = Console.ReadLine();

            //call method and outputs if user input is a paldindrome in bool form
            Console.WriteLine("\nIs the string a palindrome: " + isPalindrome(userInput));
        }
    }
}
