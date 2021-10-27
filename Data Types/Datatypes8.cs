/*
//  Author: Jonathan Scholl
//  Date: 10/27/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php Data Type 8
//  Description:  Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.
*/
using System;

namespace DataTypes8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            const float Pi = 3.1415926535f;
            float radius;

            //prompt user and store information
            Console.WriteLine("Enter the radius of the sphere: ");
            radius = float.Parse(Console.ReadLine());

            //send to method for calculation
            //output results
            Console.WriteLine($"Surface area of sphere: {calculateSurface(radius, Pi)}");
            Console.WriteLine($"Volume of sphere: {calculateVolume(radius, Pi)}");
        }
        //methods calculate based on parameters and formulas
        public static float calculateSurface(float radius, float pi)
        {
            return 4 * pi * (radius * radius);
        }
        public static float calculateVolume(float radius, float pi)
        {
            return 4f/3f * pi * (radius * radius * radius);
        }
    }
}
