/*
//  Author: Jonathan Scholl
//  Date: 10/19/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 126
//  Description: Write a C# Sharp program to check a given array of integers and return true if 
//  the array contains three increasing adjacent numbers
*/
using System;

namespace BasicAlgorithm126
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            Console.WriteLine("Three consecutive increasing integers: " + checkArray(userArray));
        }
        public static bool checkArray(int[] num)
        {
            for (int x = 0; x <= num.Length - 3; x++)
            {
                if (num[x] == num[x + 1] - 1 && num[x] == num[x + 2] - 2) return true;
            }
            return false;
        }

        //create a unique array based on how many elements
        public static int[] createNewArray()
        {
            Console.Write("How many elements: ");
            var length = int.Parse(Console.ReadLine());

            int[] numArray = new int[length];

            for (int x = 0; x < numArray.Length; x++)
            {
                numArray[x] = int.Parse(Console.ReadLine());
            }

            return numArray;
        }

        //print the contents of an array
        public static string printArray(int[] numArray)
        {
            return "{ " + String.Join(", ", numArray) + " }";
        }
    }
}
