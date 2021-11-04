/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 14
//  Description: Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene
*/
using System;

namespace ConditionalStatement14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of 3 sides of a triangle");
            Console.WriteLine("Side: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Side: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Side: ");
            int side3 = int.Parse(Console.ReadLine());

            Console.WriteLine(whatTypeOfTriangle(side1, side2, side3));
        }

        public static string whatTypeOfTriangle(int side1, int side2, int side3)
        {
            if (side1 == side2 && side1 == side3) return "Equilateral";
            else if (side1 == side2 || side1 == side3 || side2 == side3) return "Isosceles";
            else return "Scalene";
        }
    }
}
