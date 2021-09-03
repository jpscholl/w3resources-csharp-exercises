/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 17
//  Description:  Write a C# program to create a new string from a given string (length 1 or more) 
//  with the first character added at the front and back
*/
using System;

namespace BasicExercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user to input a string
            Console.Write("Input a string: ");

            //inputs string into variable (no need for conversion)
            string input = Console.ReadLine();

            //if the length of the user input is less than or equal one then not valid
            if (input.Length >= 1)
            {
                //takes first letter from the user string and stores it inside separate variable
                string s = input.Substring(0,1);

                //add new string to beginning and end of original string
                Console.WriteLine(s + input + s); 
            }     
        }
    }
}
