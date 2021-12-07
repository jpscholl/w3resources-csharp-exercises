/*
//  Author: Jonathan Scholl
//  Date: 12/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop45 
//  Description: Write a program in C# Sharp to find LCM of any two numbers.
*/
using System;

namespace ForLoop45
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable to hold LCM
            int leastCommonMultiple;

            //prompt and store user input 
            Console.Write("Input first number: ");
            int userInputNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int userInputNum2 = Convert.ToInt32(Console.ReadLine());

            //select the highest number for 
            int largestNumber = userInputNum1 > userInputNum2 ? userInputNum1 : userInputNum2;

            //I didn't know you could use for loops like this
            //checks if both input numbers have a remainder after dividing from the max number
            for (int x = largestNumber; ;x += largestNumber)
            {
                //if both numbers don't have a remainder, then it's the LCM
                if (x % userInputNum1 == 0 && x % userInputNum2 == 0)
                {
                    leastCommonMultiple = x;
                    break;
                }
            }
            //output results
            Console.WriteLine($"\nLCM {userInputNum1} and {userInputNum2}: {leastCommonMultiple}");
        }
    }
}
