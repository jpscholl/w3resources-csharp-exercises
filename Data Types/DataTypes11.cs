/*
//  Author: Jonathan Scholl
//  Date: 10/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php DataTypes 11
//  Description: Write a C# Sharp program that takes a decimal number as input and displays its 
//  equivalent in binary form.
*/
using System;

namespace DataTypes11
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate variables
            int userNumInput;

            //prompt user and store input
            Console.WriteLine("Please input a decimal number: ");
            userNumInput = int.Parse(Console.ReadLine());

            //send input to method to calculate binary number
            //output binary number
            Console.WriteLine($"Number as binary: {convertNumberToBinary(userNumInput)}");

        }
        //method to calculate binary number
        public static string convertNumberToBinary(int input)
        {
            int num = input;
            string result = string.Empty;

            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            return Convert.ToString(num) + result;
        }
    }
}
