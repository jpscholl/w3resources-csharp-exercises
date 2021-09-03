/*
//  Author: Jonathan Scholl
//  Date: 7/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 14
//  Description: Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
*/
using System;

namespace BasicAlgorithm14
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and store into variables
            Console.WriteLine("Please input integer one: ");
            int inputNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input integer two: ");
            int inputNum2 = Convert.ToInt32(Console.ReadLine());

            //pass variables into function and output results
            Console.WriteLine(numberRange(inputNum1, inputNum2));
        }
        //function to check range of the user input that takes two ints as reference
        static public bool numberRange(int num1, int num2)
        {
            //returns true if the range of either number is 100-200
            return (num1 >= 100 && num1 <= 200) || (num2 >= 100 && num1 <= 200);
        }
    }
}
