/*
//  Author: Jonathan Scholl
//  Date: 10/25/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php 4
//  Description: Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation
*/
using System;

namespace DataTypes4
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum1, userNum2;
            char operation = ' ';
            Console.WriteLine("Input first number: ");
            userNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input operation");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Input second number: ");
            userNum2 = int.Parse(Console.ReadLine());

            doMath(userNum1, userNum2, operation);
        }

        public static void doMath(int num1, int num2, char op)
        {
            Console.WriteLine(Environment.NewLine);
            if (op == '+') Console.WriteLine($"{num1} {op} {num2} = {num1 + num2}");
            else if (op == '-') Console.WriteLine($"{num1} {op} {num2} = {num1 - num2}");
            else if (op == 'x') Console.WriteLine($"{num1} {op} {num2} = {num1 * num2}");
            else if (op == '/') Console.WriteLine($"{num1} {op} {num2} = {num1 / num2}");
            else Console.WriteLine("Wrong Character");
        }
    }
}
