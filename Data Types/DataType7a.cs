/*
//  Author: Jonathan Scholl
//  Date: 10/26/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php Data Types 7
//  Description: Write a C# Sharp program that takes distance and time as input and displays the speed in kilometres per hour and miles per hour.
*/
using System;

namespace DataTypes7
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            float distance, hours, mins, secs;
            float totalSeconds, mps, kph, mph;
            //prompt for input and store
            Console.WriteLine("Input distance (meters): ");
            distance = float.Parse(Console.ReadLine());

            Console.WriteLine("Input hours: ");
            hours = float.Parse(Console.ReadLine());

            Console.WriteLine("Input minutes: ");
            mins = float.Parse(Console.ReadLine());

            Console.WriteLine("Input seconds: ");
            secs = float.Parse(Console.ReadLine());

            //calculate output
            totalSeconds = (hours * 3600) + (mins * 60) + secs;
            mps = distance / totalSeconds;
            kph = (distance/1000.0f) / (totalSeconds/3600.0f);
            mph = kph / 1.609f;

            //print output based on calculation
            Console.WriteLine($"Speed in meters/sec: {mps}");
            Console.WriteLine($"Speed in kph: {kph}");
            Console.WriteLine($"Speed in mph: {mph}");
        }
    }
}
