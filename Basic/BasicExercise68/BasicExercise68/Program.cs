/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 68
//  Description: Write a C# Sharp program to count a specified character (both cases) in a given string
*/
using System;

namespace BasicExercise68
{
    class Program
    {
        public static int test(string str1, char uc, char lc)
        {
            return str1.Split(uc, lc).Length - 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(test("Fart you, you farting farter", 'F', 'f'));
            Console.WriteLine(test("Latest News, Breaking News LIVE", 'A', 'a'));
        }
    }
}
