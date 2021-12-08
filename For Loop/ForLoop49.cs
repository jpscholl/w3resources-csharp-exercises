/*
//  Author: Jonathan Scholl
//  Date: 12/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop49
//  Description: Write a C# Sharp program to find out the sum of in A.P. series.
*/
using System;

namespace ForLoop49
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfAP = 0;

            Console.Write("Input starting number: ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.Write("Input number of items: ");
            int itemsNumber = int.Parse(Console.ReadLine());

            Console.Write("Input common difference: ");
            int differenceNumber = int.Parse(Console.ReadLine());

            Console.Write($" = {calculateAP(startNumber, itemsNumber, differenceNumber)}");
        }
        static public int calculateAP(int start, int items, int difference)
        {
            int sumOfRange = start;
            int temp = start + difference;

            Console.Write($"{start} + ");
            for (int x = 1; x < items; x++)
            {
                Console.Write($"{temp} + ");
                sumOfRange += temp;
                temp += difference;
            }

            return sumOfRange;
        }
    }
}
