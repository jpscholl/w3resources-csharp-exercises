/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 50
//  Description: Write a C# program to rotate an array (length 3) of integers in left direction.
//  Comments: Not sure I'll get this one on my own, but I have ideas. 
*/
using System;

namespace BasicExercise50
{
    class Program
    {
        static void Main(string[] args)
        {
            //create test array
            int[] intArray = { 1, 2, 8 };

            //outputs numbers of array without looping
            Console.WriteLine("intArray: [{0}]", string.Join(", ", intArray));

            //variable to temporarily hold numbers
            var temp = intArray[0];

            //loops through array based on length
            for (int x = 0; x < intArray.Length - 1; x++)
            {
                intArray[x] = intArray[x + 1]; 
            }

            intArray[intArray.Length - 1] = temp;

            //outputs numbers of array without looping
            Console.WriteLine("intArray: [{0}]", string.Join(", ", intArray));

        }
    }
}
