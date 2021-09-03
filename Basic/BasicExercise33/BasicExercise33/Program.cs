/*
//  Author: Jonathan Scholl
//  Date: 3/4/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 33
//  Description: Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
//  Comment: added my own spin with exception handling
*/
using System;

namespace BasicExercise33
{
    class Program
    {
        //method/function to check if number is divisible by 3
        static void DivByThree(int x)
        {
            Console.WriteLine(x % 3 == 0);
        }

        //method/function to check if number is divisble by 7
        static void DivBySeven(int x)
        {
            Console.WriteLine(x % 7 == 0);
        }
        //checks to see if input is zero. Stays in loop until input isn't zero then passes new value out of function.
        private static int MultipleOfZero(ref int x)
        {
            while (x == 0)
            {
                Console.WriteLine("Zero is only a multiple of itself, Try again!");
                x = Convert.ToInt32(Console.ReadLine());
            }

            return x;
        }

        //main function
        static void Main(string[] args)
        {
            //prompt user for number input
            Console.WriteLine("Please input a positive number: ");

            //convert user input from string to integer and store in integer variable
            int numInput = Convert.ToInt32(Console.ReadLine());

            //function forces the referenced input to not be zero
            MultipleOfZero(ref numInput);

            if (numInput > 0)
            {
                Console.WriteLine("\nIs number divisible by 3:");
                DivByThree(numInput);

                Console.WriteLine("\nIs number divisible by 7:");
                DivBySeven(numInput);
            }
            
            else
            {
                Console.WriteLine("You didn't enter a positive number.");
            }
        }
    }
}
