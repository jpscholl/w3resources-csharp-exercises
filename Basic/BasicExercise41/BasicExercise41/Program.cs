/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 41
//  Description:  Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
//  Comments: Used the solution to study how the lambda operators works. Altered version of regular solution, I
//  didn't figure it out on my own.
*/
using System;
using System.Linq;

namespace BasicExercise41
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.Write("Please enter a string: ");

            //stores input in string variable
            string userInput = Console.ReadLine();

            //variable to store number of instances of w in string

            var instance = userInput.Count(x => x == 'w');  //count function checks for each instance of w inside of the userInput string
            
            //display and formatting
            Console.Write("Does the input contain 1 to 3 instances of 'w': ");

            //displays true/false based on range of 1 to 3 instances of w
            Console.WriteLine(instance >= 1 && instance <= 3);

        }
    }
}
