/*
//  Author: Jonathan Scholl
//  Date: 2/21/2022
//  Project: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/index.php
//  Insertion Sort
*/

//Start Main()
//test variables
int[] testArray = {8, 5, 1, 4, 7, 2, 9, 3, 6 };

//output to user messages
Console.WriteLine("Insertion Point test");
Console.WriteLine("--------------------");
Console.Write($"OG array: ");

//output original contents
printArray(testArray);
Console.WriteLine();

//sort the array
int[] sortedArray = insertionSort(testArray);

//print new array after sorting
Console.Write($"Sorted array: ");
printArray(sortedArray);
Console.WriteLine();
//End Main()

//Start printArray()
void printArray(int[] testArray)
{
    for (int i = 0; i < testArray.Length; i++)
    {
        Console.Write($"{testArray[i]} ");
    }
}//End printArray()

//Start insertionSort()
static int[] insertionSort(int[] num)
{
    int size = num.Length;
    //sort through each element of the array
    for (int i = 1; i < size; ++i)
    {
        //store current and previous position values
        int currPosVal = num[i];        //5
        int prevPosElement = i - 1;     //0

        //while the previous position element isn't 0 and
        //the previous position is greater than the current position
        while (prevPosElement >= 0 && num[prevPosElement] > currPosVal)
        {
            //swap value until above condition met
            //current value = previous value
            num[prevPosElement + 1] = num[prevPosElement];
            //decrease element position by 1
            prevPosElement--;
        }
        //original starting point in the loop plus one is the new current position value
        num[prevPosElement + 1] = currPosVal;
    }
    return num;
}//End insertionSort()
