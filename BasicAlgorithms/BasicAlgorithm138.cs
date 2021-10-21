/*
//  Author: Jonathan Scholl
//  Date: 10/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 137
//  Description: Write a C# Sharp program to create a new array using the first n strings from a given 
//  array of strings. (n>=1 and <=length of the array)
*/
using System;

namespace BasicAlgorithm137
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            string[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");


            string[] stringArray = newStringArray(userArray);
            Console.WriteLine($"\nNew Array: {printArray(stringArray)}");

        }
        public static string[] newStringArray(string[] str)
        {
            Console.WriteLine("How many elements: ");
            int size = int.Parse(Console.ReadLine());

            string[] newStringArr = new string[size];

            for (int x = 0; x < size; x++)
            {
                newStringArr[x] = str[x];
            }

            return newStringArr;
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
