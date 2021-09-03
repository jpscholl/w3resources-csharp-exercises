/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 40
//  Description: Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30
*/
using System;
using System.Linq;

namespace BasicAlgorithm40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(returnSumOrIfRange10To20Return30(userNum1, userNum2));
        }

        public static int returnSumOrIfRange10To20Return30(int userNum1, int userNum2)
        {
            return userNum1 + userNum2 >= 10 && userNum1 + userNum2 <= 20 ? 30 : userNum1 + userNum2;
        }
    }
}
