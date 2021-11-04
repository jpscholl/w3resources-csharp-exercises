/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 23
//  Description: Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
*/
using System;

namespace ConditionalStatement23
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and store into proper variable
            Console.Write("Please input month number: ");
            int monthNumber = int.Parse(Console.ReadLine());

            //output based on user input passed to a method
            Console.WriteLine(daysInAMonth(monthNumber));

        }
        //method outputs num of days based on month num
        public static string daysInAMonth(int month) => 
            month == 1 ? "Jan has 31 days"
            : month == 2 ? "Feb has 28/29 days" 
            : month == 3 ? "Mar has 31 days" 
            : month == 4 ? "April has 30 days"
            : month == 5 ? "May has 31 days"
            : month == 6 ? "Jun has 30 days"
            : month == 7 ? "Jul has 31 days" 
            : month == 8 ? "Aug has 31 days"
            : month == 9 ? "Sep has 30 days"
            : month == 10 ? "Oct has 31 days" 
            : month == 11 ? "Nov has 30 days"
            : month == 12 ? "Dec has 31 days" : "Invalid month";
    }
}
