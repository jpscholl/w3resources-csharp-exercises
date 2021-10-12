/*
//  Author: Jonathan Scholl
//  Date: 10/12/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 116
//  Description: Write a C# Sharp program to check if the number of 3's is greater than the number of 5's.
*/
using System;

namespace BasicAlgorithm116
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine("\nOriginal Array: ");
            printArray(userArray);

            Console.WriteLine("\nMore 3's than 5's: " + checkArray(userArray));
        }
        public static bool checkArray(int[] num)
        {
            int fiveCount;
            int threeCount = fiveCount = 0;

            for (int x = 0; x < num.Length; x++)
            {
                if (num[x] == 3) 
                {
                    threeCount++;
                }

                if (num[x] == 5)
                {
                    fiveCount++;
                }
            }

            return threeCount > fiveCount;
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
        public static void printArray(int[] numArray)
        {
            foreach (var item in numArray)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");
        }
    }
}
