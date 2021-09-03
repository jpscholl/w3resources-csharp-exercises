/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 3
//  Description: Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
*/
using System;

namespace BasicAlgorithm3
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and store into int variable
            Console.WriteLine("Please input a number: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            //prompt user for input and store into int variable
            Console.WriteLine("Please input a number: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            //output results after passing userInput to method for calculation
            Console.WriteLine("One of the numbers or the sum of the numbers is 30: " + checkSum30(userNum1, userNum2));
        }

        //boolean variable for testing. Takes two ints as reference
        public static bool checkSum30(int x, int y)
        {
            //condition: if x equivalent to 30 OR y equivalent to 30 OR x plus y is equivalent to 30
            if (x == 30 || y == 30 || x + y == 30)
            {
                //if above conditions are met, returns true
                return true;
            }
            else
            {
                //if conditions aren't met, return false
                return false; 
            }        
        }
    }
}
