/*
//  Author: Jonathan Scholl
//  Date: 11/1/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 10
//  Description: Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: 
//  Marks in Maths >=65
//  Marks in Phy >=55
//  Marks in Chem>=50
//  Total in all three subject >=180
//      or
//  Total in Math and Physics >=140 (it didn't state that it was "physics" it said subject...the solution revealed which subject...)
*/
using System;

namespace ConditionalStatements10
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompot user for ints and score into variables
            Console.WriteLine("Input the marks obtained in Physics: ");
            int scorePhysics = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry: ");
            int scoreChemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics: ");
            int scoreMathematics = int.Parse(Console.ReadLine());

            Console.WriteLine(isEligible(scorePhysics, scoreChemistry, scoreMathematics));
        }
        public static string isEligible(int phys, int chem, int math)
        {
            if (math >= 65)
                if (phys >= 55)
                    if (chem >= 50)
                        if (math + phys + chem >= 180 || math + phys >= 140)
                            return"\nEligible for admission";
                        else return"\nIsn't eligible for admission";
                    else return "\nIsn't eligible for admission";
                else return "\nIsn't eligible for admission";
            else return "\nIsn't eligible for admission";

        }
    }
}
