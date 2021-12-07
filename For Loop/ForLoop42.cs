/*
//  Author: Jonathan Scholl
//  Date: 12/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop42
//  Description: Write a program in C# Sharp to convert a binary number into a decimal number without using array, function and while loop
*/
using System;

namespace ForLoop42
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            int i = 1;
            int decimalFormat = 0;

            Console.Write("Input a binary number: ");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());
            int originalNumber = userInputNumber;

            for (int x = userInputNumber; x > 0; x = x / 10)
            {
                int d = x % 10;
                if (i == 1)
                    p *= 1;
                else
                    p *= 2;

                decimalFormat = decimalFormat + (d * p);
                i++;
            }
            Console.WriteLine($"The Binary Number: {originalNumber}\nThe equivalent Decimal Number: {decimalFormat}");
        }
    }
}
