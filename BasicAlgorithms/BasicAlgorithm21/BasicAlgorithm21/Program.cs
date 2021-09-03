/*
//  Author: Jonathan Scholl
//  Date: 8/4/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 21
//  Description: Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range
*/
using System;

namespace BasicAlgorithm21
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input and store into int variable
            Console.WriteLine("Please input first integer: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            //prompt user to input and store into int variable
            Console.WriteLine("Please input second integer: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            //outputs results of function
            Console.WriteLine("Returning larger number or 0 if equal or not in range: " + CheckRange(firstNum, secondNum));
        }

        //integer variable that takes two integers as reference
        public static int CheckRange(int x, int y)
        {
            
            if (x >= 20 && x <= 30 && y >= 20 && y <= 30)
            {
                
                if (x >= y)
                {
                    return x;
                }
                
                else
                {
                    return y;
                }
            }
            
            else if (x >= 20 && y <= 30)
            {
                return x;
            }
            
            else if (y >= 20 && y <= 30)
            {
                return y;
            }
           
            else
            {
                return 0;
            }
        }
    }
}
