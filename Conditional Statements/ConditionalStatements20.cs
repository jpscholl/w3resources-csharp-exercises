/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statements 20
//  Description: Write a program in C# Sharp to read any day number in integer and display day name in the word
*/
using System;

namespace ConditionalStatement20
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store input
            Console.Write("Input a number for day of the week (1-7): ");
            char userDayOfWeek = Convert.ToChar(Console.ReadLine());

            //output method based on user input
            Console.WriteLine(dayOfTheWeek(userDayOfWeek));
        }
        //chooses day of week based on user input
        public static string dayOfTheWeek(char dayNum)
        {
            switch (dayNum)
            {
                case '1': return "Sunday";
                case '2': return "Monday";
                case '3': return "Tuesday";
                case '4': return "Wednesday";
                case '5': return "Thursday";
                case '6': return "Friday";
                case '7': return "Saturday";
                default: return "Invalid";
            }
        }
    }
}
