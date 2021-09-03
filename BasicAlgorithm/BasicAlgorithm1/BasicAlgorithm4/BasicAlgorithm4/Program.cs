/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 4
//  Description: Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
*/
using System;

namespace BasicAlgorithm4
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for integer input and store into int variable
            Console.WriteLine("Please input an integer: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //pass user input to method and output results
            Console.WriteLine("Is number within 10 of 100 or 200: " + withinTen100or200(userNumber));
        }
        //method determines true or false based on condition
        public static bool withinTen100or200(int userNum)
        {
            // if absolute value of user input minus 100 is greater than or equal to 10 OR if user input minus 200 is greater than or equal to 10
            if (Math.Abs(userNum - 100) <= 10 || Math.Abs(userNum - 200) <= 10)
            {
                //if condition met then true
                return true;
            }
            else
            {
                //if condition not met then false
                return false;
            }
        }
    }
}
