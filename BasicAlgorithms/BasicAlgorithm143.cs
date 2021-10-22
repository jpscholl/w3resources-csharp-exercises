/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 143
//  Description: Write a C# Sharp program to create a new list from a given list of strings where 
//  each element has "#" added at the beginning and end position
*/
using System;
using System.Collections.Generic;

namespace BasicAlgorithm143
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            stringList.Add(Convert.ToString(1));
            stringList.Add(Convert.ToString(2));
            stringList.Add(Convert.ToString(3));
            stringList.Add(Convert.ToString(4));

            for (int x = 0; x < stringList.Count; x++)
            {
                stringList[x] = "#" + stringList[x] + "#";
            }

            foreach (var item in stringList)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
