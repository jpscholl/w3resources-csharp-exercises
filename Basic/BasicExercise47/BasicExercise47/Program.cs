/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 47
//  Description: Write a C# program to compute the sum of all the elements of an array of integers.
//  Comments: Had the right idea, but failed to use foreach loop in first attempt. 
*/
using System;

namespace BasicExercise47
{
    class Program
    {
        static void Main(string[] args)
        {
            //premade array
            int[] intArray = {1,2,3,4,5,6,7,8,9,10};

            //instantiate sum variable to hold added numbers
            var sum = 0;

            //loops through each number in the array based on length of the array
            for (var x = 0; x < intArray.Length; x++)
            {
                //adds to sum total for each number based on the position in the array
                sum += intArray[x];
            }

            Console.WriteLine("{0} is the sum", sum);
        }
    }
}
