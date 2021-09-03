/*
//  Author: Jonathan Scholl
//  Date: 2/26/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 15
//  Description:  Write a C# program remove specified a character from a non-empty string 
//  using index of a character.
//
//  Comment: I just looked at the answer for this one, because I'm not great with string
//  manipulation and I don't even remember learning the function used in the exercise.
//  I found a different way to use what I learned to output the same answer.
*/
using System;
using System.Collections.Generic;

namespace BasicExercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "w3resource";
            
            //Don't remember learning the Remove function, but I understand how it works after this after playing around.
            //first number is position in the string and second is how many characters removed after position
            Console.WriteLine(str.Remove(1, 1));
            Console.WriteLine(str.Remove(9, 1));
            Console.WriteLine(str.Remove(0, 1));
        }

    }
}

/*
 * the website's answer:
 * public class Exercise15 {
  static void Main(string[] args)
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));     
        }
       public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
}
 */
