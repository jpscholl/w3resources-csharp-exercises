/*
//  Author: Jonathan Scholl
//  Date: 12/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop55
//  Description: Write a program in C# Sharp to convert a decimal number to hexadecimal.
*/
using System;
using System.Collections.Generic;

namespace ForLoop55
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user and store decimal number
            Console.Write("Input a number in decimal format: ");
            int userInputDecimal = int.Parse(Console.ReadLine());

            //output results from calculation method
            Console.WriteLine($"\n{userInputDecimal} as hexadecimal: {convertDecimalToHexadecimal(userInputDecimal)}");
        }
        //method to convert decimal to hexadecimal
        public static string convertDecimalToHexadecimal(int num)
        {
            //variables
            string[] hexaValues = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9" 
            , "A", "B", "C", "D", "E", "F"};
            string hexadecimalFormat = string.Empty;
            int remainder = 0, quotient = 0;
            List<string> reverseHexadecimal= new List<string>();

            //for each digit, save remainder and quotient. Add value of remainder to list
            for (; num > 0 ; num /= 16 )
            {
                remainder = num % 16;
                quotient = num / 16;
                reverseHexadecimal.Add($"{hexaValues[remainder]}");
            }

            //since digits are calculated in reverse, you reverse the order to get proper number
            reverseHexadecimal.Reverse();

            //store into string in proper order
            foreach (var item in reverseHexadecimal)
            {
                hexadecimalFormat += item;
            }

            //return string
            return hexadecimalFormat;
        }
    }
}
