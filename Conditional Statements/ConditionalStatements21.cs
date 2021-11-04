/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 21
//  Description: Write a program in C# Sharp to read any digit, display in the word.
*/
using System;

namespace ConditionalStatement21
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user and store input in variable
            Console.Write("Please input a single digit number: ");
            int userNumberInput = int.Parse(Console.ReadLine());

            //output results based on input
            Console.WriteLine(numberAsWord(userNumberInput));

        }
        //method to test number
        public static string numberAsWord(int num) => num == 0 ? "Zero" : num == 1 ? "One" : num == 2 ? "Two" : num == 3 ? "Three" 
            : num == 4 ? "Four" : num == 5 ? "Five" : num == 6 ? "Six" : num == 7 ? "Seven" : num == 8 ? "Eight" : num == 9 ? "Nine" : "Invalid";
        /*
        {
            //solution 2
            return num == 0 ? "Zero" : num == 1 ? "One" : num == 2 ? "Two" : num == 3 ? "Three" : num == 4 ? "Four"
                : num == 5 ? "Five" : num == 6 ? "Six" : num == 7 ? "Seven" : num == 8 ? "Eight" : num == 9 ? "Nine" : "Invalid";
            
            //solution 3
            switch (num)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: return "Invalid";
            }    
        }*/
    }
}
