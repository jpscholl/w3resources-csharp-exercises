/*
//  Author: Jonathan Scholl
//  Date: 10/14/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 121
//  Description:  Write a C# Sharp program to check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array.
*/
using System;

namespace BasicAlgorithm121
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");
            printArray(userArray);

            Console.WriteLine($"Meet conditions: {checkArray(userArray)}");
        }
        public static bool checkArray(int[] numArray)
        {
            bool isThree = false;

            for (int x = 0; x < numArray.Length; x++)
            {
                if (isThree && numArray[x] == 5) return true;
                if (numArray[x] == 3) isThree = true;
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
