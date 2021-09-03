/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 27
//  Description: Write a C# program and compute the sum of the digits of an integer
*/
using System;

namespace BasicExercise27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer: ");           //prompts user
            int x = Convert.ToInt32(Console.ReadLine());    //stores user input

            int sum = 0;                //starting sum of zero
            while (x != 0)              //while the stored variable not equal to zero
            {
                sum += x % 10;          //increments remainder of input divided by 10 (new digit every 10)
                x /= 10;                //x equals x divided by 10
            }

            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }
    }
}
