/*
//  Author: Jonathan Scholl
//  Date: 7/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 18
//  Description: Write a C# Sharp program to check the largest number among three given integers
*/
using System;

namespace BasicAlgorithm18
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

            Console.WriteLine("\nNumbers entered: "+ userNum1 + ", " + userNum2 + ", " + userNum3);
            //outputs highest value based on user input that is passed as reference
            Console.WriteLine("\nHighest value of the three integers: " + checkGreatest(userNum1, userNum2, userNum3));
        }
        //int function takes 3 ints as reference
        public static int checkGreatest(int num1, int num2, int num3)
        {
            //Max function compares num2 and num3 for the greater value, then Max function compares that value to num1.
            //Higher value is stored into max variable
            var max = Math.Max(num1, Math.Max(num2, num3));
            //returns the highest value number
            return max;
        }
    }
}
