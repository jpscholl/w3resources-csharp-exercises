/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional statement 12
//  Description: Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
*/
using System;

namespace ConditionalStatement12
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables, prompts, and store input
            Console.WriteLine("Input student role number: ");
            string userRoleNumber = Console.ReadLine();
            Console.WriteLine("Input the students name: ");
            string userStudentName = Console.ReadLine();
            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application: ");
            double marksPhysics = double.Parse(Console.ReadLine());
            double marksChemistry = double.Parse(Console.ReadLine());
            double marksCompApp = double.Parse(Console.ReadLine());

            //output results based on input
            studentInformation(userRoleNumber, userStudentName, marksPhysics, marksChemistry, marksCompApp );
        }
        //method for calculating input
        public static void studentInformation(string no, string name, double phys, double chem, double comp)
        {
            double total = phys + chem + comp;
            double percent = total / 3.0;
            string division = percent >= 60 ? "Division = First"
                : percent < 60 && percent >= 48 ? "Division = Second"
                : percent < 48 && percent >=36 ? "Division = Pass" : "Division = Fail";

            Console.WriteLine("------------------------------------------------------------------------------- ");
            Console.WriteLine($"Roll No: {no}\n" +
                $"Student Name: {name}\n" +
                $"Marks in Physics: {phys}\n" +
                $"Marks in Chemistry: {chem}\n" +
                $"Marks in Computer Application: {comp}\n" +
                $"Total Marks = {total}\n" +
                $"Percentage = {percent}\n" +
                $"Division = {division}");

        }
    }
}
