/*
//  Author: Jonathan Scholl
//  Date: 12/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop56
//  Description: Write a program in C# Sharp to check whether a number can be express as sum of two prime numbers.
*/
using System;

namespace ForLoop56
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store input
            Console.Write("Input a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            //method to print tables that are sum of primes
            sumOfPrime(userNumber);
        }
        public static void sumOfPrime(int num)
        {
            //prints half the tables (otherwise you will get repeats)
            for (int x = 0; x <= num / 2; x++)
            {
                //check if both numbers in the table are prime and only prints those
                if (primeCheck(x) == true && primeCheck(num - x) == true)
                {
                    Console.WriteLine($"{num} = {x} + {num - x}");
                } 
            }
        }

        //test if number is prime
        public static bool primeCheck(int num)
        {
            bool isPrime = true;

            if (num == 1 || num == 4) return false;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
