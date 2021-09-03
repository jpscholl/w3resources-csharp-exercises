/*
//  Author: Jonathan Scholl
//  Date: 8/23/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 32
//  Description: Write a C# Sharp program to check a specified number is present in a given array of integers
*/
using System;
using System.Linq;

namespace BasicAlgorithm32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray= {1, 2, 3, 4, 5 };

            Console.WriteLine("Enter an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The array contains the integer: " + checkArray(numArray, userNum));
        }

        public static bool checkArray(int[] num, int usr)
        {
            if (num.Contains(usr))
            { 
                return true;
            }
            else
            {
                return false;
            }    
            
        }
    }
}
