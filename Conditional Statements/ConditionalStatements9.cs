/*
//  Author: Jonathan Scholl
//  Date: 11/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 9    
//  Description: Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
*/
using System;

namespace ConditionalStatement9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x coordinates: ");
            int xCoordinate = int.Parse(Console.ReadLine());

            Console.WriteLine("Input y coordinates: ");
            int yCoordinate = int.Parse(Console.ReadLine());

            Console.WriteLine($"The coordinates of ({xCoordinate},{yCoordinate}) is inside: {whichQuadrant(xCoordinate, yCoordinate)}");
        }

        public static string whichQuadrant(int x, int y)
        {
            if (x > 0 && y > 0) return "Quadrant 1";
            if (x < 0 && y > 0) return "Quadrant 2";
            if (x > 0 && y < 0) return "Quadrant 3";
            if (x < 0 && y < 0) return "Quadrant 4";
            else return "No Quadrant";
        }

    }
}
