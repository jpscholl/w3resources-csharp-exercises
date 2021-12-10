/*
//  Author: Jonathan Scholl
//  Date: 12/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop54
//  Description: Write a program in C# Sharp to convert an octal number into binary
*/
using System;
using System.Collections.Generic;

namespace ForLoop54
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user and store octal number
            Console.Write("Input an octal number: ");
            int userOctalNumber = int.Parse(Console.ReadLine());

            //if number is octal output binary version
            Console.WriteLine(convertOctalToBinary(userOctalNumber));

        }
        //method to convert octal to binary
        public static int convertOctalToBinary(int num)
        {
            //variables
            string[] octalValues = {"000", "001", "010", "011", "100", "101", "110", "111" };
            string binaryNumFormat = string.Empty;
            int digitCount = 0;
            List <string> reverseBinary = new List<string>();

            //check each digit for range
            for (; num > 0 ; num /= 10)
            {  
                //last digit is stored
                int digit = num % 10;

                //checks the digits range 0 - 7
                if (digit > 7 || digit < 0)
                {
                    //if a number outside 0 - 7 is found, octal number can't be calculated
                    Console.WriteLine("Not octal number");
                    return num;    
                }
                //store values in a list
                reverseBinary.Add(octalValues[digit]);
                digitCount++;
                //Console.WriteLine(digit);     
            }
            
            //since the digits are calculated in reverse order, we have to reverse them before adding them to a string
            reverseBinary.Reverse();

            //add the numbers in the proper order to the output string
            foreach (var item in reverseBinary)
            {
                binaryNumFormat += item;
            }
 
            //shave the 0's off the beginning
            while (binaryNumFormat.StartsWith("0"))
            { 
                binaryNumFormat = binaryNumFormat.Remove(0, 1);
            }

            //return binary number
            return int.Parse(binaryNumFormat);
        }
    }
}
