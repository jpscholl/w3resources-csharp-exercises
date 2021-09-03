/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 26
//  Description: Write a C# program to compute the sum of the first 500 prime numbers
//  Comments: Decided to just break down the solution to learn how it works since I'd never
//  figure this out on my own
*/
using System;

namespace BasicExercise26
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sum of the first 500 prime numbers: ");
            long sum = 0;               //holds sum of the numbers
            int ctr = 0;                //start counter
            int n = 2;                  //starting number since 2 is first prime number

            while (ctr < 500)           //500 because we want to loop through first 500 prime numbers
            {
                if (isPrime(n))         //function to check if number is prime number
                {
                    sum += n;           //if the number is prime, it adds to sum variable total
                    ctr++;              //counter increments
                }
                n++;                    //number increments
            }

            Console.WriteLine(sum.ToString());      //outputs the final sum onto screen
        }
        public static bool isPrime(int n)           //start of function to check if number is prime (passes in integer)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));  //nani????

            if (n == 1) return false;               //if the number is 1, it's not a prime number
            if (n == 2) return true;                //if the number is 2, it's a prime number

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
