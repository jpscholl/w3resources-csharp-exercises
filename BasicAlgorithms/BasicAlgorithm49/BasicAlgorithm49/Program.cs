/*
//  Author: Jonathan Scholl
//  Date: 9/10/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 49
//  Description: Write a C# Sharp program to check if three given numbers are in strict 
//  increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8. However, 
//  if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7
*/
using System;

namespace BasicAlgorithm49
{ 
    class Program
    {
        public static bool test(int[] num, bool flag)
        {
            int x = num[0];
            int y = num[1];
            int z = num[2];

            return flag ? x <= y && y <= z : x < y && y < z;
        }
        static void Main(string[] args)
        {

            int[] numArray = new int[3];
            int x = 0;

            Console.WriteLine("Enter 3 Integers:");

            while (x < 3)
            {
                if (int.TryParse(Console.ReadLine(), out numArray[x]))
                    x++;
                else
                    Console.WriteLine("You didn't enter a number! Please enter again!");
            }

            Console.Write("Repeat numbers (true or false): ");
            bool repeat = bool.Parse(Console.ReadLine());

            Console.WriteLine("The integers are in numerical order: " + test(numArray, repeat));

        }

    }
}
