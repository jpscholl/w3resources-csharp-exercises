/*
//  Author: Jonathan Scholl
//  Date: 2/26/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 11
//  Description: Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20"
*/
using System;

namespace BasicExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older than {0}\n\n", age);

        }
    }
}
