/*
//  Author: Jonathan Scholl
//  Date: 10/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 138b
//  Description: Write a C# Sharp program to create a new array from a given array of strings 
//  using all the strings whose length are matched with given string length
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm138
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            string[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            ArrayList stringArray = createNewString(userArray);
            foreach (var item in stringArray)
            {
                Console.Write("{ ");
                Console.Write(String.Join(", ", item.ToString()) + " }");
            }

        }
        public static ArrayList createNewString(string[] str)
        {
            Console.WriteLine("How many elements: ");
            int size = int.Parse(Console.ReadLine());

            ArrayList newArrayList = new ArrayList();

            for (int x = 0; x < str.Length; x++)
            {
                if(str[x].Length == size)
                {
                    newArrayList.Add(str[x]);
                }
            }

            return newArrayList;
        }
        //create a unique array based on how many elements
        public static string[] initializeArray()
        {
            Console.Write("How many elements: ");
            var length = int.Parse(Console.ReadLine());

            string[] strArray = new string[length];

            for (int x = 0; x < strArray.Length; x++)
            {
                strArray[x] = Console.ReadLine();
            }

            return strArray;
        }

        //print the contents of an array
        public static string printArray(string[] strArray)
        {
            return "{ " + String.Join(", ", strArray) + " }";
        }
    }
}
