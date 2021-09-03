/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 22
//  Description: Write a C# program to check if an given integer is within 20 of 100 or 200
*/
using System;

namespace BasicExecercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is the number within 20 of 100 or 200?\n" 
                + (Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) <= 20));

            Console.WriteLine(result(x));
        }

        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            {
                return true;
            }
            return false;
        }
    }
}
