/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 48
//  Description:  Write a C# program to check if the first element and the last element 
//  are equal of an array of integers and the length is 1 or more.
//  Comments: Came to a solution based on previous solutions I've seen
*/
using System;

namespace BasicExercise48
{
    class Program
    {
        static void Main(string[] args)
        {
            //created two arrays to prove that one is true and one is false
            int[] numArray1 = { 1, 2, 3, 4, 5, 1 };
            int[] numArray2 = { 1, 2, 3, 4, 5, 6 };

            //outputs statement and bool based on meeting the requirements
            Console.WriteLine("The first element and last element the same: " + (numArray1[0] == numArray1[5]));
            Console.WriteLine("Output greater than 1: " + (numArray1.Length > 1));
            Console.WriteLine("The first element and last element the same: " + (numArray2[0] == numArray2[5]));
            Console.WriteLine("Output greater than 1: " + (numArray2.Length > 1));
        }
    }
}
