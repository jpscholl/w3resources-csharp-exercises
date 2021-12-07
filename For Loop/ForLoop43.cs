/*
//  Author: Jonathan Scholl
//  Date: 12/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop43
//  Description: Write a C# Sharp program to find HCF (Highest Common Factor) of two numbers.
*/
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace ForLoop43
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable to hold high factor
            int highestCommonFactor = 0;

            //prompt user and store input
            Console.Write("Enter the first number: ");
            int userInputNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int userInputNumber2 = int.Parse(Console.ReadLine());

            //lists to hold factors for each number
            var factorsNum1 = new ArrayList();
            var factorsNum2 = new ArrayList();

            //if number is a factor of input number, store inside factor list
            for (int x = 1; x <= userInputNumber1; x++)
            {
                if (userInputNumber1 % x == 0)
                {
                    factorsNum1.Add(x);
                }
            }

            //if number is a factor of input number, store inside factor list
            for (int x = 1; x <= userInputNumber2; x++)
            {
                if (userInputNumber2 % x == 0)
                {
                    factorsNum2.Add(x);
                }
            }

            //if the factor inside the first list contains the same number as in the second list, it becomes new highest factor
            for (int x = 0; x < factorsNum1.Count; x++)
            {
                if (factorsNum2.Contains(factorsNum1[x]))
                {
                    highestCommonFactor = (int)factorsNum1[x];
                }
            }

            //output factor list for first number
            Console.WriteLine($"\nFactors for {userInputNumber1}: ");
            foreach (var item in factorsNum1)
            {
                Console.Write(item + " ");
            }

            //output factor list for second number
            Console.WriteLine($"\n\nFactors for {userInputNumber2}: ");
            foreach (var item in factorsNum2)
            {
                Console.Write(item + " ");
            }

            //outputs the HCF of the compared numbers
            Console.WriteLine($"\n\nHighest Common Factor of {userInputNumber1} and {userInputNumber2}: {highestCommonFactor}");
        }
    }
}
