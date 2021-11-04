/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statements 13
//  Description: Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below
*/
using System;

namespace ConditionalStatements13
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store temp
            Console.WriteLine("Input temperature: ");
            int inputTemperature = int.Parse(Console.ReadLine());

            //output based on temp range (Celsius)
            if (inputTemperature < 0) Console.WriteLine("It's Freezing weather");
                else if (inputTemperature < 10) Console.WriteLine("It's very cold weather");
                    else if (inputTemperature < 20) Console.WriteLine("It's cold weather");
                        else if (inputTemperature < 30) Console.WriteLine("It's normal weather");
                            else if (inputTemperature < 40) Console.WriteLine("It's hot weather");
                                else Console.WriteLine("It's very hot weather");

        }
    }
}
