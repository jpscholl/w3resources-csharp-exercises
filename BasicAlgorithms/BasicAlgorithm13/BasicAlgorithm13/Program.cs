/*
//  Author: Jonathan Scholl
//  Date: 7/18/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 13
//  Description: Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100
*/
using System;

namespace BasicAlgorithm13
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for two temps and store them
            Console.WriteLine("Enter temp 1: ");
            double userTemp1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter temp 2: ");
            double userTemp2 = Convert.ToDouble(Console.ReadLine());

            //pass results to function and output results
            Console.WriteLine("Results: " + checkTemp(userTemp1, userTemp2));
        }
        //function to check temps
        public static bool checkTemp(double temp1, double temp2)
        {
            return (temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100) ;
        }
    }
}
