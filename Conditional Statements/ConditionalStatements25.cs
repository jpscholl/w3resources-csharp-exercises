/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 25
//  Description: Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
*/
using System;

namespace ConditionalStatement25
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int choice = 0;

            //outputs opening message
            openingMessage();

            //calculates and outputs results from choice
            while (choice != 5)
            {
                //prompt user and store input
                Console.Write("Input first integer: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Input first integer: ");
                int num2 = int.Parse(Console.ReadLine());
                //displays choices
                optionMessage();

                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());

                Console.WriteLine(doTheMath(num1, num2, choice));
                Console.WriteLine("---------------------------------------------------");
            }

            Console.WriteLine("\nExiting Program...");
        }
        //opening message
        public static void openingMessage()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Input two numbers and choose a math operations");
            Console.WriteLine("---------------------------------------------------");
        }
        //option messages
        public static void optionMessage()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("----------------------------------------------------");
        }
        //calculations
        public static string doTheMath(int num1, int num2, int choice)
        {
            return choice == 1 ? $"{num1} + {num2} = {num1 + num2}" :
                choice == 2 ? $"{num1} - {num2} = {num1 - num2} " :
                choice == 3 ? $"{num1} * {num2} = {num1 * num2} " :
                choice == 4 ? $"{num1} / {num2} = {num1 / num2} " : "Invalid choice";
        }
    }
}
