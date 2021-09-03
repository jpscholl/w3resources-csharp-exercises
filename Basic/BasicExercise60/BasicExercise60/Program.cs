/*
//  Author: w3resources
//  Date: 4/20/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 60
//  Description: Write a C# program to calculate the sum of all the intgers of a rectangular 
//  matrix except those integers which are located below an integer of value 0
//  Comments: Studying solution to learn 
*/
using System;

namespace BasicExercise60
{
    class Program
    {
        public static int sum_matrix_elements(int[][] my_matrix)
        {
            //variable to hold sum
            int x = 0;

            //loops through the 
            for ( int i = 0; i < my_matrix[0].Length; i++)
                for (int j = 0; j < my_matrix.Length && my_matrix[j][i] > 0; j++)
                    x += my_matrix[j][i];

            //return sum
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sum_matrix_elements(
                new int[][] {
                    new int[]{0, 2, 3, 2},
                    new int[]{0, 6, 0, 1},
                    new int[]{4, 0, 3, 0}
                }));
            Console.WriteLine(sum_matrix_elements(
                new int[][] {
                    new int[]{1, 2, 1, 0 },
                    new int[]{0, 5, 0, 0},
                    new int[]{1, 1, 3, 10 }
                }));
            Console.WriteLine(sum_matrix_elements(
                new int[][] {
                    new int[]{1, 1},
                    new int[]{2, 2},
                    new int[]{3, 3},
                    new int[]{4, 4}
                }));
        }
    }
}
