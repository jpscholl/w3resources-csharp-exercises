/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php 1
//  Description: Write a C# Sharp program that takes three letters as input and display them in reverse order
*/
using System;
using System.Linq;
namespace DataTypes1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] userChar = new char[3];

            for(int x = 0; x < userChar.Length; x++)
            {
                Console.Write("Enter letter: ");
                userChar[x] = Convert.ToChar(Console.ReadLine());
            }

            Array.Reverse(userChar);

            foreach (var item in userChar)
            {
                Console.Write(item + " ");
            }
        }
    }
}
