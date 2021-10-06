/*
//  Author: Jonathan Scholl
//  Date: 10/5/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 101
//  Description: Write a C# Sharp program to check a given array of integers, length 3 and 
//  create a new array. If there is a 5 in the given array immediately followed by a 7 then set 7 to 1.
*/
using System;
using System.Linq;

namespace BasicAlgorithm101
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {1, 5, 7};
            
            Console.WriteLine(String.Join(", ", intArray));

            Console.WriteLine("After method: " + String.Join(", ", newArray(intArray)));


        }

        public static int[] newArray(int[] numArray)
        {
            for (int x = 0; x < numArray.Length - 1; x++)
            {
                if (numArray[x].Equals(5) && numArray[x + 1].Equals(7))
                {
                    numArray[x + 1] = 1;
                }
            }
            return numArray;
        }
    }
}
