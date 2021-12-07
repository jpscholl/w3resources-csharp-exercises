/*
//  Author: Jonathan Scholl
//  Date: 12/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop44.cs
//  Description: Write a program in C# Sharp to find LCM of any two numbers using HCF.
*/
using System;

namespace ForLoop44
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int highestNumber, highestCommonFactor = 1, leastCommonMultiple;

            //prompt user and store input
            Console.Write("Input 1st number: ");
            int userInputNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            int userInputNumber2 = Convert.ToInt32(Console.ReadLine());

            //determine highest number for highest factor
            highestNumber = (userInputNumber1 < userInputNumber2) ? userInputNumber1 : userInputNumber2;

            //for each number up to highest number
            for (int x = 1; x <= highestNumber; x++)
            {
                //if both numbers divided by x had no remainder then it becomes HCF
                if (userInputNumber1 % x == 0 && userInputNumber2 % x == 0)
                {
                    highestCommonFactor = x;
                }
            }
            //formula for LCM based on input numbers divided by HCF
            leastCommonMultiple = (userInputNumber1 * userInputNumber2) / highestCommonFactor;

            //output results
            Console.Write($"\nThe LCM of {userInputNumber1} and {userInputNumber2} is: {leastCommonMultiple}\n\n");
        }
    }
}
