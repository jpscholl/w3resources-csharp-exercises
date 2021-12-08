/*
//  Author: Jonathan Scholl
//  Date: 12/8/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop50
//  Description: Write a program in C# Sharp to convert a decimal number into octal without using an array.
*/
using System;

namespace ForLoop50
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store user input number
            Console.Write("Input a decimal number: ");
            int userInputDecimal = Convert.ToInt32(Console.ReadLine());

            //output octal number
            Console.WriteLine($"{userInputDecimal} in Octal format is: {octalConversion(userInputDecimal)}");
        }
        
        //calculate decimal to octal with formula
        public static int octalConversion(int num)
        {
            int i = 1;
            int octalFormat = 0;

            for (int x = num; x > 0; x = x / 8)
            {
                octalFormat += (x % 8) * i;
                i *= 10;
                num /= 8;
            }

            return octalFormat;
        }
    }
}
