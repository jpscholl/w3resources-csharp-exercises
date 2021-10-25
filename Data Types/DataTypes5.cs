/*
//  Author: Jonathan Scholl
//  Date: 10/25/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php 5
//  Description: Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
*/
using System;

namespace DataTypes5
{
    class Program
    {
        const double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Input the radius of a circle: ");
            double radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Perimeter of circle: {circlePerimeter(radius)}");

            Console.WriteLine($"Area of circle: {circleArea(radius)}");
        }
        public static double circlePerimeter(double radius)
        {
            return Math.Round((Pi * 2) * radius, 2);
        }
        public static double circleArea(double radius)
        {
            return Math.Round(Pi * Math.Pow(radius, 2),2);
        }
    }
}
