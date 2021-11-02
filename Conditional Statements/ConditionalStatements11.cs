/*
//  Author: Jonathan Scholl
//  Date: 11/2/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statements 11
//  Description: Write a C# Sharp program to calculate root of Quadratic Equation.
*/
using System;

namespace ConditionalStatement11
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int a, b, c;

            //prompt user and store input
            Console.WriteLine("Input value of a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input value of b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input value of c: ");
            c = int.Parse(Console.ReadLine());

            calculateQuadraticRoots(a, b, c);
        }
        //calculate the roots
        public static void calculateQuadraticRoots(int a, int b, int c)
        {
            double d, x1, x2;

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root Root2= {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.Write("Both roots are real and diff-2\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root root2= {0}\n", x2);
            }
            else
                Console.Write("Root are imaginary;\nNo Solution. \n\n");
        }
    }
}
