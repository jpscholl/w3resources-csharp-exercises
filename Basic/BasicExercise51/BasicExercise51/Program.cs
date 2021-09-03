/*
//  Author: Jonathan Scholl
//  Date: 4/13/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 51
//  Description: Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
*/
using System;

namespace BasicExercise51
{
    class Program
    {
        static void Main(string[] args)
        {
            //test data array
            int[] numArray1 = { 5, 2, 5};

            Console.WriteLine("Testing the array: \n");

            if (numArray1[0] > numArray1[2]) //triggers when the first element is greater
            {
                Console.WriteLine("The first array element is higher: {0}", numArray1[0]); //let's user know that the first element is greater
            }
            else if (numArray1[0] < numArray1[2])//triggers when the last element is greater
            {
                Console.WriteLine("The last array element is higher: {0}", numArray1[2]); //let's user know that the last element is greater 
            }
            else //if neither value is higher or lower than the other then it triggers this statement
            {
                Console.WriteLine("Same value of: {0}", numArray1[0]); //tells user the elements are the same value
            }
        }
    }
}
