/*
//  Author: Jonathan Scholl
//  Date: 12/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop46
//  Description: Write a program in C# Sharp to convert a binary number into a decimal number using math function
*/
using System;

namespace ForLoop46
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int dividedNumber;
            double x = 0, decimalFormat = 0;

            //prompt for input and store
            Console.Write("Input binary number: ");
            int binaryUserInput = int.Parse(Console.ReadLine());

            //store original number so you can manipulate the input number
            int originalNumber = binaryUserInput;

            //while there's still numbers left
            while (binaryUserInput != 0)
            {
                //store the end number
                dividedNumber = binaryUserInput % 10;
                //add converted number to decimal format total
                decimalFormat = decimalFormat + dividedNumber * Math.Pow(2, x);
                //get rid of end number
                binaryUserInput = binaryUserInput / 10;
                x++;
            }

            //output results
            Console.WriteLine($"The decimal version of {originalNumber}: {decimalFormat}");
        }
    }
}
