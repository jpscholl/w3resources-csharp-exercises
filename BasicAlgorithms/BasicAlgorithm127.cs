/*
//  Author: Jonathan Scholl
//  Date: 10/19/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 127
//  Description: Write a C# Sharp program to shift an element in left direction and return a new array
*/
using System;
using System.Linq;

namespace BasicAlgorithm127
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            int[] shiftArray = newArray(userArray);
            Console.WriteLine("After shift: " + printArray(shiftArray));

        }
        public static int[] newArray(int[] num)
        {
            int size = num.Length;
            int[] shiftNums = new int[size];

            for (int x = 0; x < size; x++)
            {
                shiftNums[x] = num[(x + 1) % size];
            }
            return shiftNums;
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
