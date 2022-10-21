/*
//  Author: Jonathan Scholl
//  Date: 10/20/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String12.cs
*/
using System;

namespace String12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user for number of strings
            Console.Write("Input number of strings: ");
            int numberOfStrings = Int32.Parse(Console.ReadLine());

            //create array based on number of strings
            string[] stringArray = new string[numberOfStrings];

            //ask user for input based on length
            Console.WriteLine($"Input {numberOfStrings} strings below: ");

            //fill the array with strings
            for(int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            //spacing
            Console.WriteLine();

            //output array of strings before sort
            for(int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //bubble sort contents of string array
            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = 0; j < stringArray.Length - 1; j++)
                {
                    if (stringArray[j].CompareTo(stringArray[j + 1]) > 0)
                    {
                        string temp = stringArray[j];
                        stringArray[j] = stringArray[j + 1];
                        stringArray[j + 1] = temp;
                    }
                }
            }

            //output results after bubble sorting string array
            Console.Write("\n\nAfter sorting the array appears like : \n");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i] + " ");
            }

        }
    }
}
