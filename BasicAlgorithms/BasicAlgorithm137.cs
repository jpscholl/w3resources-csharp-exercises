/*
//  Author: Jonathan Scholl
//  Date: 10/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 138
//  Description: Write a C# Sharp program to create a new array from a given array of strings 
//  using all the strings whose length are matched with given string length
*/
using System;

namespace BasicAlgorithm138
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            string[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            string[] stringArray = createNewString(userArray);
            Console.WriteLine($"\nNew Array: {printArray(stringArray)}");
        }
        public static string[] createNewString(string[] str)
        {
            int position = 0;
            Console.WriteLine("How many elements: ");
            int size = int.Parse(Console.ReadLine());

            string[] newString = new string[size];

            for (int x = 0; x < str.Length; x++)
            {
                if (str[x].Length == size)
                {
                    newString[x] = str[x];
                    position++;
                }
            }

            return newString;
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
