/*
//  Author: Jonathan Scholl
//  Date: 10/22/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 141
//  Description: Write a C# Sharp program to create a new list from a given list of integers where each element is multiplied by 3
*/
using System;

namespace BasicAlgorithm141
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            int[] tripledArray = createNewArray(userArray);
            Console.WriteLine($"\nAfter elements times 3: {printArray(tripledArray)}");
            
        }
        public static int[] createNewArray(int[] num)
        {
            int[] tripleArray = new int[num.Length];
            int pos = 0;

            foreach (int element in num)
            {
                tripleArray[pos] = num[pos] * 3;
                pos++;
            }
            return tripleArray;
        }

        //create a unique array based on how many elements
        public static int[] initializeArray()
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
