/*
//  Author: Jonathan Scholl
//  Date: 11/19/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop30
//  Description: Write a C# Sharp program to find the Armstrong number for a given range of number.
*/
using System;

namespace ForLoop30
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables, prompt, and store input
            int startNumber, endNumber;

            Console.Write("Input starting number of range: ");
            startNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range : ");
            endNumber = Convert.ToInt32(Console.ReadLine());

            //output results based on input
            rangeArmstrong(startNumber, endNumber);
        }
        //check the range based on input passed to method
        public static void rangeArmstrong(int start, int end)
        {
            int num, r, sum, temp;
            Console.Write("Armstrong numbers in given range are: ");
            for (num = start; num <= end; num++)
            {
                temp = num;
                sum = 0;

                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == num)
                    Console.Write($"{num} ");
            }
            Console.Write("\n");
        }
    }
}
