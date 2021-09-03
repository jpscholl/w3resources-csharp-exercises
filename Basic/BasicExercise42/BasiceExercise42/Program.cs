/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 42
//  Description: Write a C# program to create a new string where the first 4 characters will be in lower case. 
//  If the string is less than 4 characters then make the whole string in upper case
//  Comment: Attempting to figure out without solution first. I prefer to have user enter strings instead of 
//  premade strings. **Update** Solved on my own
*/
using System;

namespace BasiceExercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user and store input into string variable
            Console.WriteLine("Please enter a string: ");
            string userInput = Console.ReadLine();

            if (userInput.Length < 4)   //checks the length of the string to make sure it's less than 4
            {
                Console.WriteLine("The string is less than 4 characters long: ");   //let's user know the string is less than 4 characters
                Console.WriteLine(userInput.ToUpper());                 //ToUpper function makes all characters upper case
            }
            else                        //otherwise if the string isn't less than 4 characters
            {
                Console.WriteLine("The string 4 characters long or higher: ");      //let's user know the string is 4 characters or more
                Console.WriteLine(userInput);                           //prints the message without altering
            }

        }
    }
}
