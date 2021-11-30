*
//  Author: Jonathan Scholl
//  Date: 11/29/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop36
//  Description: Write a program in C# Sharp to display the such a pattern for n number of rows using a number which 
//  will start with the number 1 and the first and a last number of each row will be 1.
*/
using System;

namespace ForLoop36
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables and input prompt
            Console.Write("Number of rows: ");
            int userInputRows = int.Parse(Console.ReadLine());

            //test output of method based on input
            numPyramid(userInputRows);
        }
        //method to print number pyramid
        public static void numPyramid(int rows)
        {
            for (int i = 0; i <= rows; i++)
            {
                /* spaces */
                for (int x = 1; x <= rows - i; x++)
                    Console.Write(" ");

                /* Display number in ascending order up to middle*/
                for (int x = 1; x <= i; x++)
                    Console.Write("{0}", x);

                /* Display  number in reverse order after middle */
                for (int x = i - 1; x >= 1; x--)
                    Console.Write("{0}", x);

                Console.Write("\n");
            }
        }
    }
}
