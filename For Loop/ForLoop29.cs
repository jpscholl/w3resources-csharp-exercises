/*
//  Author: Jonathan Scholl
//  Date: 11/18/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop29
//  Description: Write a C# Sharp program to check whether a given number is an Armstrong number or not.
*/
using System;
using System.Linq;

namespace ForLoop29
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables and store input from user
            Console.Write("Input a three digit number: ");
            string userNumberInput = Console.ReadLine();

            //output results based on user input and method
            Console.WriteLine($"\nIs Armstrong number: {isArmstrongNumber(userNumberInput)}");
        }

        //method to determine Armstrong number
        public static bool isArmstrongNumber(string num)
        {
            //if number isn't 3 digits, then automatically not considered Armstrong number
            if (num.Length != 3) return false;

            int sum = 0;

            char[] seperateDigits = num.ToCharArray();

            for (int x = 0; x < num.Length; x++)
            {
                sum += Convert.ToInt32(num[x].ToString()) * Convert.ToInt32(num[x].ToString()) *
                    Convert.ToInt32(num[x].ToString());
            }
            
            return sum == Convert.ToInt32(num);
        }
    }
}
