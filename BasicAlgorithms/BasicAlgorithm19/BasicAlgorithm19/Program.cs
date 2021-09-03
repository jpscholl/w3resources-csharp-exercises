/*
//  Author: Jonathan Scholl
//  Date: 7/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 19
//  Description: Write a C# Sharp program to check which number nearest to the value 100 among two given integers. Return 0 if the two numbers are equal
*/
using System;

namespace BasicAlgorithm19
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter 2 integers and store into variables
            Console.WriteLine("Enter integer: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            //pass user input to function and output results
            Console.WriteLine(closestToHundred(userNum1, userNum2));
        }
        //int function that takes two ints as reference
        public static int closestToHundred(int num1, int num2)
        {
            //100 is constand since it's being compared to values
            const int n = 100;

            //to determine which number is closest, the absolute value is needed minus the constant number
            //values are how far away the number is from 100
            var val = Math.Abs(num1 - n);
            var val2 = Math.Abs(num2 - n);

            //if the compared ranges are equal return 0. otherwise if val is less than val 2 return num1 else...return num2 
            return val == val2 ? 0 : (val < val2 ? num1 : num2);
        }
    }
}
