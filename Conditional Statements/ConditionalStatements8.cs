/*
//  Author: Jonathan Scholl
//  Date: 11/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php COnditional Statements 8
//  Description: Write a C# Sharp program to find the largest of three numbers
*/
using System;

namespace ConditionalStatement8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int userNum1, userNum2, userNum3;

            //prompt user and store input
            Console.WriteLine("Input first integer: ");
            userNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer: ");
            userNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input third integer: ");
            userNum3 = int.Parse(Console.ReadLine());

            //output greatest int
            Console.WriteLine($"Highest value integer: {greatestOfThree(userNum1, userNum2, userNum3)}");
        }
        //method for finding greatest value of three ints
        public static int greatestOfThree(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3) return n1;
            if (n2 > n1 && n2 > n3) return n2;
            return n3;
        }
    }
}
