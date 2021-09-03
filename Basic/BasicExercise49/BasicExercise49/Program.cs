/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 49
//  Description: Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal
//  Comments: 
*/
using System;

namespace BasicExercise49
{
    class Program
    {
        static void Main(string[] args)
        {
            //two arrays established
            int[] intArray1 = { 1, 2, 3, 4, 5, 1 };
            int[] intArray2 = { 1, 2, 3, 4, 5, 6 };

            //first checks to see if both arrays are length of 1 or more before deciding output
            if (intArray1.Length >= 1 && intArray2.Length >= 1)
            {
                Console.Write("First first or last element in the arrays are equal: ");
                //checks to see if the first position or the last position in the arrays are equal then outputs bool based on results
                Console.WriteLine(intArray1[0] == intArray2[0] || intArray1[5] == intArray2[5]);
            }
            else
            {
                //indicates to the user the array length isn't long enough
                Console.WriteLine("At least one array's length is not 1 or more");
            }

        }
    }
}
