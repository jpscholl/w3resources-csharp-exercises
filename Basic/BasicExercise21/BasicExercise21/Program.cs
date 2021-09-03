/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 21
//  Description: Write a C# program to check the sum of the two given integers and 
//  return true if one of the integer is 20 or if their sum is 20.
*/
using System;
using System.Collections.Generic;

namespace BasicExercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Please enter integer: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter integer: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
            testBool(x, y);
        }

        //why doesn't this work for me????
        public static bool testBool(int x, int y)
        {
            return (x == 20 || y == 20 || (x + y == 20));
        }
    }
}
