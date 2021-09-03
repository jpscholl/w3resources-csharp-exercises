/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 44
//  Description: Write a C# program to create a new string of every other character (odd position) 
//  from the first position of a given string.
//  Comment: I have an idea of how it's supposed to work, but not sure if I'll get it 100% without solution.
//  **Update** Had the proper idea, but I didn't set up the modulus check properly.  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise44
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt users and store input in string variable
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();

            //create instance of variable for final output.
            string str = String.Empty;

            for (int x = 0; x < userInput.Length; x++)      //checks through string based on the length of the string
            {   
                if (x % 2 == 0)             //checks for a modulus of 0 because all even numbers don't leave a remainder
                {
                    str += userInput[x];    //adds letter to the output string based on the position in the string
                }
                
            }
            Console.WriteLine(str);         //outputs final combined string
        }
    }
}
