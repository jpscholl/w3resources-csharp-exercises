/*
//  Author: Jonathan Scholl
//  Date: 8/17/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 26
//  Description: Write a C# Sharp program to create a new string which is n (non-negative integer) 
//  copies of the the first 3 characters of a given string. If the length of the given string is less 
//  than 3 then return n copies of the string.
*/
using System;
using System.Linq;
using Data_Validation;

namespace BasicAlgorithm26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string: ");
            var userString = Console.ReadLine();
           //Data_Validation.Data_Validation.preventNullString(userString);

            Console.WriteLine("How many copies: ");
            var userNumCopy = Console.ReadLine();
            //Data_Validation.Data_Validation.validPosNum(userNumCopy);

            Console.WriteLine(test(userString, Convert.ToInt32(userNumCopy)));
        }
        public static string test(string s, int n)
        {
            var result = string.Empty;
            var frontOfString = 3;

            if (frontOfString > s.Length)
                frontOfString = s.Length;

            var front = s.Substring(0, frontOfString);

            for (var i = 0; i < n; i++)
            {
                result += front;
            }
            return result;
        }
    }
}
