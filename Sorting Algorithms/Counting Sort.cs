/*
//  Author: Jonathan Scholl
//  Date: 2/17/2022
//  Project: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/index.php 
*/

//Begin Main

//Opening statement
Console.WriteLine("Testing of Bubble Sort Algorithm");
Console.WriteLine("--------------------------------");

//test list that needs sorting
int[] numArray = {4, 2, 8, 3, 3, 1 };
int n = numArray.Length;

//before sort
Console.Write("Before: ");
foreach (int num in numArray)
{
    Console.Write($"{num} ");
}

Console.WriteLine();
//test method with given list
Console.Write("After: ");
countSort(numArray, n);


//End Main

//Sort Method
static void countSort(int[] array, int size)
{
    // The size of count must be at least the (max+1) but
    // we cannot assign declare it as int count(max+1) in C++ as
    // it does not support dynamic memory allocation.
    // So, its size is provided statically.
    int[] output = new int [10];
    int[] count = new int[10];
    int max = array[0];

    // Find the largest element of the array
    for (int i = 1; i < size; i++)
    {
        if (array[i] > max)
            max = array[i];
    }

    // Initialize count array with all zeros.
    for (int i = 0; i <= max; ++i)
    {
        count[i] = 0;
    }

    // Store the count of each element
    for (int i = 0; i < size; i++)
    {
        count[array[i]]++;
    }

    // Store the cummulative count of each array
    for (int i = 1; i <= max; i++)
    {
        count[i] += count[i - 1];
    }

    // Find the index of each element of the original array in count array, and
    // place the elements in output array
    for (int i = size - 1; i >= 0; i--)
    {
        output[count[array[i]] - 1] = array[i];
        count[array[i]]--;
    }

    // Copy the sorted elements into original array
    for (int i = 0; i < size; i++)
    {
        array[i] = output[i];
    }

    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}
