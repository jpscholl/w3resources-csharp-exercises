/*
//  Author: Jonathan Scholl
//  Date: 7/14/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 2
//  Description: Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference
*/
using System;

namespace BasicAlgorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input then store number into integer variable
            Console.WriteLine("Please input a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //outputs the results after userNumber is passed into the AbsolTriple51 method
            Console.WriteLine("The results after calculation are: " + AbsolTriple51(userNumber));
        }
        //method for calculation
        public static int AbsolTriple51(int input)
        {
            //since we know the number 51 is constant
            const int x = 51;

            //beginning of if statement (condidtion checks if input is greater than x)
            if (input > x)
            {
                //if the userinput is greater than 51 then it'll output the difference times 3
                return (input - x) * 3;
            }
            //else it'll return just the difference
            return x - input;
        }
    }
}
