/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 149
//  Description: Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4.
*/
using System;
using System.Collections.Generic;

namespace BasicAlgorithm149
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 0, -2, 1, 2, 3, 5, 4, 7, 8 };

            List<int> newNumList = createNewList(numList);

            foreach(var item in newNumList)
            {
                Console.Write(item + " ");
            }
        }
        public static List<int> createNewList(List<int> num)
        {
            List<int> newNumList = new List<int>();

            for (int x = 0; x < num.Count; x++)
            {
                if (num[x] < 4)
                {
                    newNumList.Add(num[x]);
                }
            }
            return newNumList;
        }
    }
}
