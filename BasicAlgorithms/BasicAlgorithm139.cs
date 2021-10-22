/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 139
//  Description: Write a C# Sharp program to check a positive integer and return true if it contains a number 2.
*/
using System;
using System.Collections.Generic;

namespace BasicAlgorithm139
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer: ");
            int userNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Contains 2: {checkInt(userNum)}");
        }

        public static bool checkInt(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }

            return listOfInts.Contains(2);

        }
    }
}
