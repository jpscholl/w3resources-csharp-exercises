/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 25
//  Description: Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
*/
using System;

namespace BasicExercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");

            //for loop to print out first number and go up to number 99
            for (int x = 1; x < (99 + 1); x++)
            {
                if (x % 2 != 0)                       //if number divided by 2 doesn't have a remainder of zero then it's an odd number
                {
                    Console.WriteLine(x.ToString());  //prints number as string
                }
            }

            //did this to for fun
            Console.WriteLine("Even numbers from 0 to 100. Prints one number per line.");

            for (int x = 0; x < (100 + 1); x++)
            {
                if (x % 2 == 0)                       //if number divided by 2 doesn't has a remainder of zero then number is even
                {
                    Console.WriteLine(x.ToString());  //prints number as string
                }
            }
        }
    }
}
