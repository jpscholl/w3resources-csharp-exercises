/*
//  Author: Jonathan Scholl
//  Date: 10/14/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 120
//  Description: Write a C# Sharp program to check a given array of integers and return true if the 
//  given array contains two 5's next to each other, or two 5 separated by one element
*/
using System;
using System.Linq;

namespace BasicAlgorithm120
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");
            printArray(userArray);

            Console.WriteLine($"Contains consecutive 5's or 5's with element in between: {checkArray(userArray)}");
        }
        public static bool checkArray(int[] num)
        {
            int length = num.Length;

            for (int x = 0; x < length - 1; x++)
            {
                if (num[x] == 5 && num[x + 1] == 5) return true;
                if (x + 2 < length && num[x] == 5 && num[x + 2] == 5) return true;
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
