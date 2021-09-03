/*
//  Author: Jonathan Scholl
//  Date: 8/23/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 33
//  Description: Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element
*/
using System;
using System.Linq;

namespace BasicAlgorithm33
{
    class Program
    {
        static void Main(string[] args)
        {
            //test array with values;
            int[] intArray = { 1, 2, 3, 4, 5 };

            //prompt user to enter value to check inside the array and store inside int variable
            Console.Write("Please enter an integer to check: ");
            int userInt = Convert.ToInt32(Console.ReadLine());

            //outputs the results after passing array and int to the checkFourElements function
            Console.WriteLine(checkFourElements(intArray , userInt));
        }
        //bool function that takes int array and int as parameters
        public static bool checkFourElements(int[] num, int n)
        {
            //outputs results to user
            Console.Write("The integer is inside the array: ");

            //if the length of the array is greater than 4 then it'll return true/false if the array contains the user input
            //else the array is larger than 4 elements so it takes the first 4 elements and checks if it contains the user input
            return num.Length < 4 ? num.Contains(n) : num.Take(4).Contains(n);
        }

    }
}
