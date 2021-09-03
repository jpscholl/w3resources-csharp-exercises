/*
//  Author: Jonathan Scholl
//  Date: 7/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 15
//  Description:  Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. 
//  Return true if 1 or more of them are in the said range otherwise false
*/
using System;

namespace BasicAlgorithm15
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter 3 integers and store into variables
            Console.WriteLine("Enter integer: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter integer: ");
            int userNum3 = Convert.ToInt32(Console.ReadLine());

            //pass user input into checkRange function and output results
            Console.WriteLine("At least one of the values within range 20-50: " + checkRange(userNum1, userNum2, userNum3));
        }
        //bool function that takes three integers as reference
        public static bool checkRange(int num1, int num2, int num3)
        {
            //returns true if input numbers are in range 20-50
            return (num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50);
        }
    }
}
