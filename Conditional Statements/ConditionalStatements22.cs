/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 22
//  Description: Write a program in C# Sharp to read any Month Number in integer and display Month name in the word.
*/
using System;

namespace ConditionalStatement22
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and store into proper variable
            Console.Write("Input number of month: ");
            int monthNumber = int.Parse(Console.ReadLine());

            //call method and pass user input to method which outputs results
            Console.WriteLine(monthNumberAsWord(monthNumber));
        }
        //method to change input number to month
        public static string monthNumberAsWord(int month) => month == 1 ? "January" : month == 2 ? "February" : month == 3 ? "March" : month == 4 ? "April"
            : month == 5 ? "May" : month == 6 ? "June" : month == 7 ? "July" : month == 8 ? "August" : month == 9 ? "September" : month == 10 ? "October"
            : month == 11 ? "November" : month == 12 ? "December" : "Invalid month";

    }
}
