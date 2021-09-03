/*
//  Author: Jonathan Scholl
//  Date: 7/8/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 88
//  Description: Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given Polygon. Input number of straight line(s).
*/
using System;

namespace BasicExercise88
{
    class Program
    {
        //function for calculating angle degree
        public static int polyAngleDegree(int numLines)
        {
            //returns degree of 
            return  180 * (numLines - 2); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number of straight lines of the polygon: ");
            int polyLines = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Sum of the degrees of the interior angles: " + polyAngleDegree(polyLines) + " degrees");

        }
    }
}
