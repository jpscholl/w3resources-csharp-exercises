/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/

int[] rangeArray = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

int[] givenArray = {10, 11, 12, 13, 14, 16, 17, 18, 19, 20 };

int missingCount = 0;

Array.ForEach(givenArray, Console.WriteLine);

Console.WriteLine($"\nMissing number: {test(givenArray)}");

static int test(int[] arr)
{
    return 165 - arr.Sum();
}
