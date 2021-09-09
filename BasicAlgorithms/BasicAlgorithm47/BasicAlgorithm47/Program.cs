/*
//  Author: Jonathan Scholl
//  Date: 9/9/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php Basic Algorithm 47
//  Description: Write a C# Sharp program to check if it is possible to add two integers 
//  to get the third integer from three given integers.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicAlgorithm47
{
    class Program
    {
        //passes a list object to a bool method
        public static bool test(List<int> numList)
        {
            //if the sum of the first two indexes of the list are equal to the third
            if (numList[0] + numList[1] == numList[2])
            {
                //then it's true
                return true;
            }
            else
            {
                //then it's false
                return false;
            }

        }

        static void Main(string[] args)
        {
            //prompts user to input three integers (you can input more but it'll only focus on the first 3 right now.)
            Console.WriteLine("Input three integers with spaces in between");

            //adds each number to the List class object
            List<int> numList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select
                (listTemp => Convert.ToInt32(listTemp)).ToList();

            //outputs results after method calculations
            Console.WriteLine("The third number is the sum of the first two: " + test(numList));
        }
    }
}
