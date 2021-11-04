/*
//  Author: Jonathan Scholl
//  Date: 11/4/2021
//  Project: https://www.w3resource.com/csharp-exercises/conditional-statement/index.php Conditional Statement 18
//  Description: Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., 
//  name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. 
//  The charge are as follow
*/
using System;

namespace ConditionalStatement18
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string customerID, customerName;
            double units = 0;

            //prompt and store information
            Console.WriteLine("----------------------------------------");
            Console.Write("Customer ID: ");
            customerID = Console.ReadLine();
            Console.Write("Customer name: ");
            customerName = Console.ReadLine();
            Console.Write("Units used: ");
            units = double.Parse(Console.ReadLine());

            //pass to method and output results
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Customer ID NO: {customerID}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Units consumed: {units}");

            calculateBill(units);
        }
        public static void calculateBill(double units)
        {
            double surcharge, subTotal;
            surcharge = subTotal = 0;

            if (units > 400) surcharge = units * .15;

            double chargeUnitRate = (units < 200) ? 1.20 : (units < 400) ? 1.50
                : (units < 600) ? 1.80 : 2.00;

            subTotal = units * chargeUnitRate;

            Console.WriteLine($"Amount Charges @Rs - {chargeUnitRate} per unit : {subTotal}");
            Console.WriteLine($"Surcharge amount: {surcharge}");
            Console.WriteLine($"Net Amount Paid By The Customer: {subTotal + surcharge}");

        }
    }
}
