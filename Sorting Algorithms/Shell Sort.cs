/*
//  Author: Jonathan Scholl
//  Date: 2/16/2022
//  Project: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/index.php Shell Sort
*/

/* Prints the contents of an array*/
static void printArray(int[] num)
{
    for (int i = 0; i < num.Length; ++i)
    {
        Console.Write($"{num[i]} ");
    }    
    Console.WriteLine();
}

//method to sort array with Shell Sort Algorithm
static int[] ShellSort(int[] num)
{
    int n = num.Length;

    // Start with a big gap,
    // then reduce the gap
    for (int gap = n / 2; gap > 0; gap /= 2)
    {
        // Do a gapped insertion sort for this gap size.
        // The first gap elements a[0..gap-1] are already
        // in gapped order keep adding one more element
        // until the entire array is gap sorted
        for (int i = gap; i < n; i += 1)
        {
            // add a[i] to the elements that have
            // been gap sorted save a[i] in temp and
            // make a hole at position i
            int temp = num[i];

            // shift earlier gap-sorted elements up until
            // the correct location for a[i] is found
            int j;
            for (j = i; j >= gap && num[j - gap] > temp; j -= gap)
                num[j] = num[j - gap];

            // put temp (the original a[i])
            // in its correct location
            num[j] = temp;
        }
    }
    return num;
}

//Main method
{
int[] arr = { 12, 34, 54, 2, 3 };
Console.Write("Array before sorting :\n");
printArray(arr);

int[] sortedArray = ShellSort(arr);

Console.Write("Array after sorting :\n");
printArray(arr);
}
