/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 145
//  Description: Write a C# Sharp program to create a new list from a given list of integers where each 
//  integer value is added to 2 and the result value is multiplied by 5.
*/
using System;
using System.Collections.Generic;

namespace BasicAlgorithm145
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = newList(new List<int>() {1,2,3,4 });

            foreach (var item in intList)
            {
                Console.WriteLine(item + " ");
            }
        }
        public static List<int> newList(List<int> intList)
        {
            List<int> newIntList = new List<int>();

            for (int x = 0; x < intList.Count; x++)
            {
                newIntList.Add((intList[x] + 2) * 5);
            }

            return newIntList;
        }
    }
}
