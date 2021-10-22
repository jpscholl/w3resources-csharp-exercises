/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 142
//  Description: Write a C# Sharp program to create a new list from a given list of integers where each integer multiplied by itself three times
*/
using System;
using System.Collections.Generic;

namespace BasicAlgorithm142
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userIntList = createNewList(initializeIntList());

            foreach (var item in userIntList)
            {
                Console.Write(item + ", ");
            }
        }
        public static List<int> createNewList(List<int> intList)
        {
            List<int> newIntList = new List<int>(); 

            foreach (var item in intList)
            {
                newIntList.Add(item * item * item);
            }
            return newIntList;
        }

        public static List<int> initializeIntList()
        {
            List<int> intList = new List<int>();

            Console.Write("How many integers to add: ");
            int item = int.Parse(Console.ReadLine());

            for (int x = 0; x < item; x++)
            {
                intList.Add(int.Parse(Console.ReadLine()));
            }
            return intList;
        }
    }
}
