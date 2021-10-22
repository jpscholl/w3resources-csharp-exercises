/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 148
//  Description: Write a C# Sharp program to remove all "a" in each string in given list of strings 
//  and return the new string.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicAlgorithm148
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = createNewStringList(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));

            foreach (var item in stringList)
            {
                Console.Write(item + " ");
            }


        }
        public static List<string> createNewStringList(List<string> strList)
        {
            return strList.Select(x => x.Replace("a", "")).ToList();
        }
    }
}
