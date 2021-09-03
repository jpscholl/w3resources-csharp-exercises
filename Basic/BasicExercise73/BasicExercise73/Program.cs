/*
//  Author: Jonathan Scholl
//  Date: 5/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 73
//  Description: Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order.
*/
using System;
using System.Linq;

namespace BasicExercise73
{
    class Program
    {
        public static string abc_Order(string str)
        {
            //built in string function OrderBy sorts letters into abc order
            return new string(str.OrderBy(x => x).ToArray());
        }
        static void Main(string[] args)
        {
            //prompt user to enter text
            Console.WriteLine("Enter some text: ");
            //store text into string variable
            string userInput = Console.ReadLine();
            //outputs a message showing the letters of the string in abc order
            Console.WriteLine("Letters in abc order: " + abc_Order(userInput));
        }
    }
}
