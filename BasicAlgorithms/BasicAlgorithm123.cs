/*
//  Author: Jonathan Scholl
//  Date: 10/16/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 123
//  Description: Write a C# Sharp program to check a given array of integers and return true 
//  if the value 5 appears 5 times and there are no 5 next to each other
*/
using System;

namespace BasicAlgorithm123
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");
            printArray(userArray);

            Console.WriteLine($"Conditions met: {checkArray(userArray)}");
        }
        public static bool checkArray(int[] numArray)
        {
            bool flag = false;
            int five = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] == 5 && !flag)
                {
                    five++;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            return five == 5;
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
