/*
//  Author: Jonathan Scholl
//  Date: 5/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 75
//  Description: Write a C# Sharp program which takes a positive number and return the nth odd number.
*/
using System;

namespace BasicExercise75
{
    class Program
    {
        //public variable which takes reference of user input
        public static int odd_nth(int n)
        {
            //returns the odd number based on nth
            return n * 2 - 1;
        }
        static void Main(string[] args)
        {
            //prompts user for number input then stores number into int variable after conversion from string
            Console.WriteLine("Please enter a number good sir/madam: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //outputs message based on user input after it passes through the function
            Console.WriteLine("nth number of " + userNumber + " is: " + odd_nth(userNumber));
        }
    }
}
