/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 150
//  Description: Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicAlgorithm150
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = removeSeven(new List<int>() { 10, 22, 35, 47, 53, 67 });

            foreach (var x in intList)
            {
                Console.Write(x.ToString() + " ");
            }
        }

        public static List<int> removeSeven(List<int> num)
        {
            return num.Where(x => x % 10 != 7).ToList();
        }
    }
}
