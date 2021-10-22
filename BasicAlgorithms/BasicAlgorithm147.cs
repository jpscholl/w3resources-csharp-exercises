/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 147
//  Description: Write a C# Sharp program to create a new list from a given list of strings where strings 
//  will be in upper case in new string
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicAlgorithm147
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() { "Abc", "cdef", "js", "php" };

            foreach (var item in stringList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(Environment.NewLine);

            List<string> newStringList = createNewStringList(stringList);

            foreach (var item in newStringList)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
        public static List<string> createNewStringList(List<string> strList)
        {
            IEnumerable<string> newList = strList.Select(x => x.ToUpper());
            return newList.ToList();
        }
    }
}
