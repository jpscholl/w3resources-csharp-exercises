/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 19
//  Description: Write a program in C# Sharp to accept a grade and declare the equivalent description
*/
using System;

namespace ConditionalStatement19
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store input
            Console.Write("Input Grade Letter: ");
            char letterGrade= Convert.ToChar(Console.ReadLine().ToUpper());

            //output results of method
            Console.WriteLine($"{gradeOutputMessage(letterGrade)}");
        }
        //method to choose output based on letter grade
        public static string gradeOutputMessage(char grade)
        {
            switch (grade)
            {
                case 'E': return("Excellent");
                case 'V': return("Very Good");
                case 'G': return("Good");
                case 'A': return("Average");
                case 'F': return("Fail");
                default: return("Invalid");
            } 
        }
    }
}
