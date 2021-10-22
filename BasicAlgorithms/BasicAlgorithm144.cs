/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 144
//  Description: Write a C# Sharp program to create a new list from a given list of strings where each element is 
//  replaced by 4 copies of the string concatenated together
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicAlgorithm144
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

            var quadList = newList(stringList);

            foreach (var item in quadList)
            {
                Console.WriteLine(item + " ");
            }
        }
        public static List<string> newList(List<string> strList)
        {
            IEnumerable<string> quadList = strList.Select(x => x = x + x + x + x);
            return quadList.ToList();

        }
    }
}
