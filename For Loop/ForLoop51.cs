/*
//  Author: Jonathan Scholl
//  Date: 12/8/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop51
//  Description: Write a program in C# Sharp to convert an octal number to decimal without using array.
*/
using System;

namespace ForLoop51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input octal number: ");
            int userOctalInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"{userOctalInput} converted to decimal: {octalToDecimalConversion(userOctalInput)}");

        }

        public static int octalToDecimalConversion(int num)
        {
            int p = 1, k, ch = 1;
            int dec = 0, i = 1, j, d;

            int storeOriginal = num;

            for (;num > 0; num = num / 10)
            {
                k = num % 10;
                if (k >= 8)
                {
                    ch = 0;
                }
            }

            switch (ch)
            {
                case 0:
                    Console.Write("\nThe number is not an octal number\n");
                    break;
                case 1:
                    num = storeOriginal;
                for (j = num; j > 0; j = j / 10)
                    {
                        d = j % 10;
                        if (i == 1)
                            p = p * 1;
                        else
                            p = p * 8;

                        dec = dec + (d * p);
                        i++;
                    }
                    Console.Write($"\nThe Octal Number: {storeOriginal}\nThe equivalent Decimal Number: {dec} \n\n");
                    break;
            }

            return num;
        }
    }
}
