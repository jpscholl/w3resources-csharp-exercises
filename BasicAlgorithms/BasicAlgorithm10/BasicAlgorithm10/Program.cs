/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 10
//  Description: Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
*/
using System;

namespace BasicAlgorithm10
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user to enter number and stores number
            Console.WriteLine("Enter number: ");
            int userNumInput = Convert.ToInt32(Console.ReadLine());

            //pass user number into method and output results
            Console.WriteLine(Multiple3or7(userNumInput));
        }
        //bool method outputs true or false based on conditions met
        public static bool Multiple3or7(int userNum)
        {
            //Condition: checks to see if there's a remainder of 0 for 3 OR reminder of 0 for 7
            //returns true if condition is met and false if not met
            return userNum % 3 == 0 || userNum % 7 == 0;
        }
    }
}
