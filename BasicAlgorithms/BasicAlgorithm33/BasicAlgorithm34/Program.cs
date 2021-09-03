/*
//  Author: Jonathan Scholl
//  Date: 8/23/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 34
//  Description: Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
*/
using System;
using System.Linq;

namespace BasicAlgorithm34
{
    class Program
    {
        static void Main(string[] args)
        {
            //test arrays
            int[] numArray = { 1, 2, 3, 4, 5 };
            int[] evenArray = { 2, 4, 6, 8, 10};
            int[] oddArray = { 1, 3, 5, 7, 9};
            int[] numArray2 = {1, 3, 5, 7, 2, 5, 29 };

            //outputs results based on function and parameters passed
            Console.WriteLine("Contains 1, 2, and 3: " + check123(numArray));
            Console.WriteLine("Contains 1, 2, and 3: " + check123(evenArray));
            Console.WriteLine("Contains 1, 2, and 3: " + check123(oddArray));
            Console.WriteLine("Contains 1, 2, and 3: " + check123(numArray2));

        }
        //bool function that takes int array as parameter
        static public bool check123(int[] intArray)
        {
            //returns true if the referenced array contains 1 and 2 and 3
            return intArray.Contains(1) && intArray.Contains(2) && intArray.Contains(3);
        }
    }
}
