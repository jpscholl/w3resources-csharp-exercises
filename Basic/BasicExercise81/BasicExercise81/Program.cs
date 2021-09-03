/*
//  Author: Jonathan Scholl
//  Date: 6/17/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 81
//  Description: Write a C# Sharp program to swap a two digit given number and check whether the given number is greater than its swap value
*/
using System;
using System.Linq;

namespace BasicExercise81
{
    class Program
    {
        public static bool testSwap(int x)
        {
            return (int)(x / 10) >= x % 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a two digit number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check whether the said value is greater than its swap value: " + testSwap(inputNum));

        }
    }
}
