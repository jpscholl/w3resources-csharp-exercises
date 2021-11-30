/*
//  Author: Jonathan Scholl
//  Date: 11/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLooop37
//  Description: Write a program in C# Sharp to display the number in reverse order.
*/
using System;

namespace ForLoop37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            string userInputNumber = Console.ReadLine();

            reverseNumber(userInputNumber);
        }
        public static void reverseNumber(string num)
        {
            char[] splitNum = num.ToCharArray();

            Array.Reverse(splitNum);

            foreach (var item in splitNum)
            {
                Console.Write(item);
            }
        }
    }
}
