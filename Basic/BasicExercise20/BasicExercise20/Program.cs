/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 20
//  Description: Write a C# program to get the absolute value of the difference between 
//  two given numbers. Return double the absolute value of the difference if the first number 
//  is greater than second number
*/
using System;
using System.Collections.Generic;

namespace BasicExercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            //it asked for integers already given but I prefer to have input for more scaleability
            Console.WriteLine("Please enter integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter integer: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");                  //formatting
            Console.WriteLine(result(x, y));        

            static int result(int x, int y)
            {
                if(x > y)
            {
                    return (x - y) * 2;
                }
                return y - x;
            }
        }
    }
}
