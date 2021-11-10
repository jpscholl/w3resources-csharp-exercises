/*
//  Author: Jonathan Scholl
//  Date: 11/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 8
//  Description: Write a program in C# Sharp to display the n terms of odd natural number and their sum
*/
using System;
using System.Linq;

namespace ForLoop8
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddSum = 0;
            Console.WriteLine("Input number of terms: ");
            int userTermsInput = int.Parse(Console.ReadLine());

            for (int x = 1; x <= userTermsInput * 2; x++)
            {
                if (x % 2 != 0)
                { 
                    Console.Write($"{x} ");
                    oddSum += x;
                }
                 
            }
            Console.WriteLine($"\nSum of odd natural numbers up to {userTermsInput}: {oddSum}");
        }
    }
}
