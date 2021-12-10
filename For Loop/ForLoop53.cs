/*
//  Author: Jonathan Scholl
//  Date: 12/9/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop53
//  Description: Write a program in C# Sharp to convert a binary number to octal.
*/
using System;

namespace ForLoop53
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store binary number
            Console.Write("Input binary number: ");
            int userBinaryNumber = int.Parse(Console.ReadLine());

            //
            Console.WriteLine($"\nBinary number: {userBinaryNumber} \n\nDecimal number: {convertBinaryToOctal(userBinaryNumber)}");

        }
        public static int convertBinaryToOctal(int num)
        {
            int p = 1, i = 1, d;
            int decimalFormat = 0;
            int octalFormat = 0;

            for (int x = num; x > 0; x = x / 10)
            {
                d = x % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;

                decimalFormat = decimalFormat + (d * p);
                i++;
            }


            i = 1;

            for (int x = decimalFormat; x > 0; x = x / 8)
            {
                octalFormat = octalFormat + (x % 8) * i;
                i = i * 10;
                num = num / 8;
            }

            return octalFormat;
        }
    }
}
