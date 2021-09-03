/*
//  Author: Jonathan Scholl
//  Date: 4/13/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 52
//  Description: Write a C# program to create a new array of length containing the middle elements 
//  of three arrays (each length 3) of integers.
*/
using System;

namespace BasicExercise52
{
    class Program
    {
        //takes arrays as input to use values of arrays for newly created array
        static void Main(string[] args)
        {
            //create test arrays
            int[] numArray1 = { 34, 25, 36 };
            int[] numArray2 = { 33, 46, 45 };
            int[] numArray3 = { 23, 54, 36 };

            //prints output of test arrays
            Console.WriteLine("Array1: [{0}]", string.Join(", ", numArray1));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", numArray2));
            Console.WriteLine("Array3: [{0}]", string.Join(", ", numArray3));

            //new array created from values stored in other arrays
            int[] newArray = { numArray1[1], numArray2[1], numArray3[1] };

            //outputs new array
            Console.WriteLine("The new array: [{0}]", string.Join(", ", newArray));

        }
    }
}
