/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 17
//  Description: Write a C# Sharp program to calculate profit and loss on a transaction.
*/
using System;

namespace ConditionalStatement17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount spent: ");
            double moneySpent = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount earned: ");
            double moneyEarned = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your profit/loss amount: {profitMargin(moneySpent, moneyEarned)}");

        }
        public static double profitMargin(double spent, double earned) => spent - earned;

    }
}
