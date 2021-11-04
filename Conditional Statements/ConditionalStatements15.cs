/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php COnditional Statement 15
//  Description: Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConditionalStatements15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] triangleSides = new int[3];
            Console.WriteLine("Input three angles of a triangle");

            for (int x = 0; x < triangleSides.Length; x++)
            {
                Console.WriteLine("Input angle: ");
                triangleSides[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Is a Triangle: {isTriangle(triangleSides)}");
        }
        public static string isTriangle(int[] triangle) => triangle.Sum().Equals(180) ? "Valid" : "Invalid"; 
    }
}
