/*
//  Author: Jonathan Scholl
//  Date: 3/4/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 36
//  Description: Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10
*/
using System;

namespace BasicExercise36
{
    class Program
    {
        public static void CheckRange (int x)
        {
            Console.WriteLine("Is number in range of (-10 - 10)");
            if (x >= -10 && x <= 10)
            {
                Console.WriteLine((x >= -10 && x <= 10));
            }
            else
            {
                Console.WriteLine("Not in range");
            }
        }

        static void Main(string[] args)
        {
            //prompts user for input number and stores into variable
            Console.WriteLine("Input number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            CheckRange(userNumber);
        }
    }
}
