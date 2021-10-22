/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 146
//  Description: Write a C# Sharp program to create a new list of the rightmost digits from 
//  a given list of positive integers.
*/
using System;
using System.Collections.Generic;

namespace BasicAlgorithm146
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = newList(new List<int>() { 10, 22, 35, 41 });

            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
        }
        public static List<int> newList(List<int> intList)
        {
            List<int> newIntList = new List<int>();

            foreach (int num in intList)
            {
                newIntList.Add(rightMost(num));
            }
            return newIntList;
        }

        public static int rightMost(int n)
        {
            n = n % 10;
            return n;
        }
    }
}
