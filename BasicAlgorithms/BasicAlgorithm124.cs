/*
//  Author: Jonathan Scholl
//  Date: 10/19/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 124
//  Description: Write a C# Sharp program to check a given array of integers and return true if 
//  every 5 that appears in the given array is next to another 5
*/
using System;

namespace BasicAlgorithm124
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");
            printArray(userArray);

            Console.WriteLine("Meets conditions: " + checkArray(userArray));
            Console.Read();
        }
        //checks if 5 is next to another 5
        public static bool checkArray(int[] numArray)
        {
            int arr_len = numArray.Length;
            bool flag = true;

            for (int i = 0; i < arr_len; i++)
            {
                if (numArray[i] == 5)
                {
                    if ((i > 0 && numArray[i - 1] == 5) || (i < arr_len - 1 && numArray[i + 1] == 5)) flag = true;
                    else if (i == arr_len - 1) flag = false;
                    else return false;
                }
            }
            return flag;
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
