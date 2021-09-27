/*
//  Author: Jonathan Scholl
//  Date: 9/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 54
//  Description: Write a C# Sharp program to compute the sum of two given non-negative integers 
//  x and y as long as the sum has the same number of digits as x. If the sum has more digits than 
//  x then return x without y.
*/

using System;

namespace BasicAlgorithm54
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDone = false;

            while (isDone != true)
            {
                Console.WriteLine("Please input two integers");

                Console.Write("Integer 1: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Integer 2: ");
                int num2 = int.Parse(Console.ReadLine());

                if (isPositive(num1) && isPositive(num2))
                {
                    Console.WriteLine("Output: " + checkDigits(num1, num2));
                }
                else
                {
                    Console.WriteLine("Both numbers were not positive.");
                }

                char end;
                Console.WriteLine("Go again? Y/N");
                end = Convert.ToChar(Console.ReadLine().ToUpper());
                
                if (end == 'Y')
                {
                    isDone = false;
                }
                else
                {
                    isDone = true;
                }
            }

            Console.WriteLine("Ending program...");
        }

        static public bool isPositive(int num)
        {
            return num >= 0;
        }

        public static int checkDigits(int x, int y)
        {
            int sum = y + x;
            return x / 10 == sum / 10 ? sum : x;
        }

    }
}
