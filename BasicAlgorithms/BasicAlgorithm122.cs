/*
//  Author: Jonathan Scholl
//  Date: 10/15/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 122
//  Description: Write a C# Sharp program to check a given array of integers and return true 
//  if the given array contains either 2 even or 2 odd values all next to each other
*/
using System;

namespace BasicAlgorithm122
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");
            printArray(userArray);

            Console.WriteLine($"Consecutive odd or even values: {checkArray(userArray)}");

        }
        public static bool checkArray(int[] numArray)
        {
            int odd = 0, even = 0;

            for (int x = 0; x < numArray.Length; x++) 
            {
                if (odd < 2 && even < 2)
                {
                    if (numArray[x] % 2 == 0)
                    {
                        even++;
                        odd = 0;
                    }
                    else
                    {
                        odd++;
                        even = 0;
                    }
                }
            }

            return odd == 2 || even == 2;
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
