/*
//  Author: Jonathan Scholl
//  Date: 11/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php COnditional Statements 7
//  Description: Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height
*/
using System;

namespace ConditionalStatements7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input height in cm: ");
            double heightInCentimeters = double.Parse(Console.ReadLine());

            Console.WriteLine(outputHeightCategory(heightInCentimeters));
        }

        public static string outputHeightCategory(double height)
        {
            if (height < 150.0)
                return "The person is short. \n\n";
            else if ((height >= 150.0) && (height <= 165.0))
                return "The person is average height. \n\n";
            else if ((height >= 165.0) && (height <= 195.0))
                return "The person is tall. \n\n";
            else
                return "Holy moly is that Shaq?\n\n";
        }
    }
}
