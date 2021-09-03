/*
//  Author: Jonathan Scholl
//  Date: 8/25/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 45
//  Description: Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18.
*/
using System;

namespace BasicAlgorithm45
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input and store test integers for function
            Console.WriteLine("Input an integer: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input an integer: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            //output results of integers passed to function
            Console.WriteLine("If one integer is in range of 10-20 return 18 (otherwise sum of integers): " + checkRange(userNum1, userNum2));
        }
        //function to test range. Takes user input as parameters
        public static int checkRange (int num1, int num2)
        {
            //if num1 or num2 is in range of 10 - 20 return 18 (true). Otherwise, return sum of the two numbers (false)
            return (num1 >= 10 && num1 <= 20) || (num2 >= 10 && num2 <= 20) ? 18 : num1 + num2;
        }
    }
}
