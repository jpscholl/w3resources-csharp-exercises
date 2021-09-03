/*
//  Author: Jonathan Scholl
//  Date: 4/19/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 53
//  Description: Write a C# program to check if an array contains an odd number.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise53
{

    class Program
    {
        //created method to check arrays for odd numbers
        public static bool CheckOdd(int[] numArray)
        {
            //loops through all numbers of the array
            foreach (var x in numArray)
            {
                if (x % 2 != 0)     //if the remainder isn't equal to 0 then it's an odd number
                    return true;    //returns true because odd number
            }
            return false;           //returns false if number isn't odd
        }
        static void Main(string[] args)
        {
            //two test arrays to prove it returns true/false properly
            int[] evenArray = { 2, 4, 6, 8 };
            int[] oddArray = { 1, 3, 5, 7 };

            Console.WriteLine("Even array: [{0}]", string.Join(", ", evenArray));   //prints contents of the array and formats it with commas
            Console.WriteLine("Does the array contain an odd number: " + CheckOdd(evenArray));  //outputs false because the array doesn't contain odd numbers

            Console.WriteLine("\nOdd array: [{0}]", string.Join(", ", oddArray));   //prints contents of the array and formats it with commas
            Console.WriteLine("Does the array contain an odd number: " + CheckOdd(oddArray));   //outputs true because the array contains odd numbers


        }
    }
}
