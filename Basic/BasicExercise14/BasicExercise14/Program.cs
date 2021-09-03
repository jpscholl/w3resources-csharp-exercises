/*
//  Author: Jonathan Scholl
//  Date: 2/26/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 14
//  Description: Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit
*/
using System;

namespace BasicExercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and save input into variable
            Console.WriteLine("Please input degress in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            //calculate based on user input
            double calcFahrenheit = celsius * 9 / 5 + 32;
            double calcKelvin = celsius + 273.15;

            //prints results of calculation
            Console.WriteLine(celsius + " degrees Celsius = " + calcFahrenheit + " degrees Fahrenheit");
            Console.WriteLine(celsius + " degrees Celsius = " + calcKelvin + " degrees Kelvin");

        }
    }
}
