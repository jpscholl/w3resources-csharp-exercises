/*
//  Author: Jonathan Scholl
//  Date: 10/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 136
//  Description: Write a C# Sharp program to count the number of strings with given length in given array of strings
*/
using System;

namespace BasicAlgorithm136
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            string[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            Console.WriteLine($"Strings: {howMany(userArray)}");

        }
        public static int howMany(string[] num)
        {
            int countString = 0;
            Console.WriteLine("How many characters: ");
            int test = int.Parse(Console.ReadLine());

            for (int x = 0; x < num.Length; x++)
            {
                if (num[x].Length == test)
                {
                    countString++;
                }
            }
            return countString;
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
