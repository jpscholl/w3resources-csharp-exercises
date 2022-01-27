/*
//  Author: Jonathan Scholl
//  Date: 1/26/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;

namespace Array18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] userNumArray = CreateMultiArray();

            printMultiArray3x3(userNumArray);

        }
        public static void printMultiArray3x3(int[,] num)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write($"{num[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        public static int [,] CreateMultiArray()
        {
            int[,] userNumArray = new int[3,3];

            for (int i = 0; i < userNumArray.GetLength(0); i++)
            {
                for (int j = 0; j < userNumArray.GetLength(1); j++)
                {
                    Console.Write("Input element: ");
                    userNumArray[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return userNumArray;
        }
    }
}
