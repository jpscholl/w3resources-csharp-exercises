/*
//  Author: Jonathan Scholl
//  Date: 10/30/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 6
//  Description: Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m 
//  is larger than 0, 0 when m is 0 and -1 when m is less than 0.
*/
using System;

namespace ConditionalStatement6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Value of m = " + m);
            Console.WriteLine("Value of n = " + valueOfN(m));
        }
        public static int valueOfN(int m)
        {
            int n = 0;

            if (m > 0) n = 1;
            if (m == 0) n = m;
            if (m < 0) n = -1;

            return n;
        }
    }
}
