/*
//  Author: Jonathan Scholl
//  Date: 9/21/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 51
//  Description: Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others
//  Note: worked through with whiteboard and didn't need solution
*/
using System;

namespace BasicAlgorithm51
{
    class Program
    {
        public static bool checkInt(int x, int y, int z)
        {
            return Math.Abs(x - y) >= 20 || Math.Abs(x - z) >= 20|| Math.Abs(y - z) >= 20;
        }
        static void Main(string[] args)
        {
            int x, y, z;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            Console.Write("One integer is 20 more or less than another int: ");
            Console.WriteLine(checkInt(x, y, z));
        }
    }
}
