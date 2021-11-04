/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 24
//  Description: Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape
*/
using System;

namespace ConditionalStatement24
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu-like output
            Console.Write("A menu driven program to compute the area of various geometrical shape:\n");
            Console.Write("-------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input 1 for area of circle\n");
            Console.Write("Input 2 for area of rectangle\n");
            Console.Write("Input 3 for area of triangle\n");
            Console.Write("Input your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calculateAreaFromChoice(choice));
        }
        public static double calculateAreaFromChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("-------------------------------------------------------------------------\n");
                    Console.Write("\nInput radius of circle: ");
                    int radius = int.Parse(Console.ReadLine());
                    Console.Write("Area of circle is: ");
                    return 3.14 * radius * radius;

                case 2:
                    Console.Write("-------------------------------------------------------------------------\n");
                    Console.Write("\nLength of rectangle: ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("Width of rectangle: ");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("Area of Rectangle is: ");
                    return length * width;

                case 3:
                    Console.Write("-------------------------------------------------------------------------\n");
                    Console.Write("Input base of triangle: ");
                    int triBase = int.Parse(Console.ReadLine());
                    Console.Write("Input height of triangle: ");
                    int height = int.Parse(Console.ReadLine());
                    Console.Write("Area of triangle is: ");
                    return .5 * triBase * height;

                default:
                    Console.Write("-------------------------------------------------------------------------\n");
                    Console.WriteLine("Invalid choice"); 
                    return 0;
            }
        }
    }
}
