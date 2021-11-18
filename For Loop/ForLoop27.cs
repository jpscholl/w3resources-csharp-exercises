/*
//  Author: Jonathan Scholl
//  Date: 11/18/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop27   
//  Description: Write a C# Sharp program to check whether a given number is perfect number or not.
*/
using System;

namespace ForLoop27.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and store
            Console.Write("Input a number: ");
            int userInputNum = int.Parse(Console.ReadLine());

            //output based on input passed to method
            Console.WriteLine($"\nNumber is perfect: {isPerfectNum(userInputNum)}");
        }
        //method to determine if number is perfect
        public static bool isPerfectNum(int num)
        {
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                    Console.Write($"{i} ");
                }
            }
            Console.Write($"\nThe sum of the divisors is: {sum}");

            return (sum == num);
        }
    }
}
