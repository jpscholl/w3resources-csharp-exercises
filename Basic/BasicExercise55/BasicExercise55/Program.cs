/*
//  Author: w3resources
//  Date: 4/19/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 55
//  Description: Write a C# program to find the pair of adjacent elements that has the 
//  largest product of an given array which is equal to a given value
//  Comments: I get the gist of how it should work, but it was confusing to me. Decided to break down solution
//  Not my work
*/
using System;

namespace BasicExercise55
{
    class Program
    {
        //method to calculate product of the two adjacent elements
        public static int array_adjacent_elements_product(int[] input_array)
        {
            //starts at index 0
            int array_index = 0;
            //stores specific index and multiplys by the very next element (because it's adjacent)
            int product = input_array[array_index] * input_array[array_index + 1];

            array_index++;
            while (array_index + 1 < input_array.Length)
            {
                product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
                           (input_array[array_index] * input_array[array_index + 1]) :
                            product;
                array_index++;
            }

            return product;
        }
        public static void Main()
        {
            Console.WriteLine(array_adjacent_elements_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1, -1, -2 }) == 2);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 3, 0 }) == 16);
        }
    }
}
